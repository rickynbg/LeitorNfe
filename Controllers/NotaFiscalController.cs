using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeitorNfe.Models;
using LeitorNfe.Data;
using System.Xml.Serialization;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Diagnostics;


namespace LeitorNfe.Controllers
{
    //public class NotaFiscalController (ILogger<NotaFiscalController> logger) : Controller
    public class NotaFiscalController(ILogger<NotaFiscalController> logger, NotaFiscalContext context) : Controller
    {
        private readonly ILogger<NotaFiscalController> _logger = logger;
        private readonly NotaFiscalContext _context = context;

        private bool NotaFiscalExists(int id)
        {
            return _context.NotaFiscal.Any(e => e.Id == id);
        }

        static T Deserialize<T>(string input) where T : class
        {
            XmlSerializer ser = new(typeof(T));
            using FileStream fileStream = System.IO.File.Open(input, FileMode.Open);
            var t = ser.Deserialize(fileStream) ?? throw new Exception($"Error to read XML file");
            return (T)t;
        }

        private static string SaveFileXML(string path, IFormFile file)
        {
            string fullPath = Path.Combine(Directory.GetCurrentDirectory(), path);
            if (!Directory.Exists(fullPath))
                Directory.CreateDirectory(fullPath);

            string fileNameWithPath = Path.Combine(fullPath, file.FileName);
            using var stream = new FileStream(fileNameWithPath, FileMode.Create);
            file.CopyTo(stream);

            return fileNameWithPath;
        }


        private static NotaFiscal FillNFe(NotaFiscal notaFiscal, string fileNameWithPath)
        {
            var nf = Deserialize<NfeProc>(fileNameWithPath);
         
            notaFiscal.NumNota = nf.NFe.InfNFe.Ide.NNF.ToString();
            notaFiscal.ChaveAcesso = nf.ProtNFe.InfProt.ChNFe.ToString();
            notaFiscal.DataEmissao = nf.NFe.InfNFe.Ide.DhEmi;
            
            notaFiscal.Emitente = nf.NFe.InfNFe.Emit.XNome;
            notaFiscal.EmitCNPJ = nf.NFe.InfNFe.Emit.CNPJ;
            notaFiscal.EmitEmail = nf.NFe.InfNFe.Emit.Email;
            notaFiscal.EmitEndereco = nf.NFe.InfNFe.Emit.EnderEmit.XLgr + " " + 
                nf.NFe.InfNFe.Emit.EnderEmit.Nro + " , " + 
                nf.NFe.InfNFe.Emit.EnderEmit.XBairro + " / " +
                nf.NFe.InfNFe.Emit.EnderEmit.XMun + " - " +
                nf.NFe.InfNFe.Emit.EnderEmit.UF + " CEP " +
                nf.NFe.InfNFe.Emit.EnderEmit.CEP;
            
            notaFiscal.Destinatario = nf.NFe.InfNFe.Dest.XNome;
            notaFiscal.DestCPF = nf.NFe.InfNFe.Dest.CPF;
            notaFiscal.DestCNPJ = nf.NFe.InfNFe.Dest.CNPJ;
            notaFiscal.DestEmail = nf.NFe.InfNFe.Dest.Email;
            notaFiscal.DestEndereco = nf.NFe.InfNFe.Dest.EnderDest.XLgr + " " + 
                nf.NFe.InfNFe.Dest.EnderDest.Nro + " , " + 
                nf.NFe.InfNFe.Dest.EnderDest.XBairro + " / " +
                nf.NFe.InfNFe.Dest.EnderDest.XMun + " - " +
                nf.NFe.InfNFe.Dest.EnderDest.UF + " CEP " +
                nf.NFe.InfNFe.Dest.EnderDest.CEP;

            notaFiscal.NotaFiscalItems = [];
            
            foreach ( var item in nf.NFe.InfNFe.Det)
            {
                NotaFiscalItem prod = new()
                {
                    NumItem = item.NItem,
                    CodProd = item.Prod.CProd,
                    Nome = item.Prod.XProd,
                    QuantidadeComprada = item.Prod.QCom,
                    ValUnit = item.Prod.VUnCom,
                    ValTotal = item.Prod.VProd,
                    NotaFiscal = notaFiscal
                };

                notaFiscal.NotaFiscalItems.Add(prod);
            }
            notaFiscal.TotalNotaFiscal = nf.NFe.InfNFe.Total.ICMSTot.VNF;

            return notaFiscal;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // GET: NotaFiscal
        public async Task<IActionResult> Index(DateTime? searchDate, int? searchNum, string? searchEmit, string? searchDest)
        {
            var filterNFe =  from n in _context.NotaFiscal
                            select n;
            
            if (searchDate != null)
            {
                filterNFe = filterNFe.Where(s => s.DataEmissao >= searchDate);
            }
            if (searchNum != null)
            {
                filterNFe = filterNFe.Where(s => s.NumNota == searchNum.ToString());
            }
            if (!string.IsNullOrEmpty(searchEmit))
            {
                filterNFe = filterNFe.Where(s => s.Emitente!.ToUpper().Contains(searchEmit.ToUpper()));
            }
            if (!string.IsNullOrEmpty(searchDest))
            {
                filterNFe = filterNFe.Where(s => s.Destinatario!.ToUpper().Contains(searchDest.ToUpper()));
            }

            var filterVM = new FilterViewModel
            {
                NotasFiscais = await filterNFe.ToListAsync(),
                SearchDate = searchDate,
                SearchNum = null,
                SearchEmit = searchEmit,
                SearchDest = searchDest
            };

            return View(filterVM);
            //return View(await _context.NotaFiscal.ToListAsync());
        }

        // GET: NotaFiscal/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaFiscal = await _context.NotaFiscal
                .Include(n => n.NotaFiscalItems)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notaFiscal == null)
            {
                return NotFound();
            }

            //var nfItems = await _context.N

            return View(notaFiscal);
        }

        public IActionResult Create()
        {
            return View();
        }

        // GET: NotaFiscal/Create
        [HttpPost, ActionName("UploadFile")]
        public IActionResult UploadFile(NotaFiscal notaFiscal)
        {
            if (notaFiscal.ArquivoXML == null || notaFiscal.ArquivoXML.Length == 0) 
                return BadRequest("No file selected for upload..."); 
            
            notaFiscal = FillNFe(notaFiscal, SaveFileXML("wwwroot/files", notaFiscal.ArquivoXML));
            notaFiscal.NomeArquivo = notaFiscal?.ArquivoXML?.FileName;
        
            return View("Create", notaFiscal);
        }

        // POST: NotaFiscal/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> 
        Create([Bind("NomeArquivo,NumPedidoCompra,Comentario,NumNota,Emitente,Destinatario,DataEmissao,ChaveAcesso,EmitCNPJ,EmitEndereco,EmitEmail,DestCNPJ,DestCPF,DestEmail,DestEndereco,TotalNotaFiscal,NotaFiscalItems")] 
        NotaFiscal notaFiscal)
       {
            if (notaFiscal.NomeArquivo != null)
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files");
                if (!Directory.Exists(fullPath))
                    Directory.CreateDirectory(fullPath);
                string fileNameWithPath = Path.Combine(fullPath, notaFiscal.NomeArquivo);

                notaFiscal = FillNFe(notaFiscal,fileNameWithPath);

                _context.Add(notaFiscal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(notaFiscal);
        }

        // GET: NotaFiscal/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaFiscal = await _context.NotaFiscal.FindAsync(id);
            if (notaFiscal == null)
            {
                return NotFound();
            }
            return View(notaFiscal);
        }

        // POST: NotaFiscal/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeArquivo,NumPedidoCompra,Comentario,NumNota,Emitente,Destinatario,DataCriacao,DataModificacao,ArquivoXML")] NotaFiscal notaFiscal)
        {
            if (id != notaFiscal.Id)
            {
                return NotFound();
            }

            if (notaFiscal.ArquivoXML != null && notaFiscal.ArquivoXML.Length > 0)
            {
                notaFiscal = FillNFe(notaFiscal, SaveFileXML("wwwroot/files", notaFiscal.ArquivoXML));
            }
        
            try
            {
                _context.Update(notaFiscal);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotaFiscalExists(notaFiscal.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));

        }

        // GET: NotaFiscal/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaFiscal = await _context.NotaFiscal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notaFiscal == null)
            {
                return NotFound();
            }

            return View(notaFiscal);
        }

        // POST: NotaFiscal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notaFiscal = await _context.NotaFiscal.FindAsync(id);
            if (notaFiscal != null)
            {
                _context.NotaFiscal.Remove(notaFiscal);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
