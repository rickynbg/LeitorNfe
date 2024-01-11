using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace LeitorNfe.Models;

public class NotaFiscal
{
    public int Id {get; set;}

    [Required]//[Required(ErrorMessage = "O nome do arquivo XML não foi informado")]
    public string? NomeArquivo {get; set;}

    [Display(Name = "Num. pedido/compra")]    
    public int NumPedidoCompra {get; set;}

    [StringLength(255)]
    public string? Comentario {get; set;}

    [Display(Name = "Data de emissão")]  
    public DateTime DataEmissao {get; set;}

    [Display(Name = "Nota Fiscal")]    
    [StringLength(9)]
    [Required]
    public string? NumNota {get; set;}

    [Required]
    public string? Emitente {get; set;}

    [Required]
    public string? Destinatario {get; set;}

    [Display(Name = "Chave de acesso")]
    public required string ChaveAcesso {get; set;}

    [Display(Name = "CNPJ do emitente")]
    public double EmitCNPJ {get; set;}

    [Required]
    [Display(Name = "Endereço do emitente")]
    public string? EmitEndereco {get; set;}

    [Display(Name = "E-mail do emitente")]
    public string? EmitEmail {get; set;}

    [Display(Name = "CNPJ do destinatário")]
    public double? DestCNPJ {get; set;}

    [Display(Name = "CPF do destinatário")]
    public double? DestCPF {get; set;}

    [Display(Name = "E-mail do destinatário")]
    public string? DestEmail {get; set;}

    [Required]
    [Display(Name = "Endereço do destinatário")]
    public string? DestEndereco {get; set;}

    [DataType(DataType.Currency)]
    [Display(Name = "Total da nota fiscal")]
    public double? TotalNotaFiscal {get; set;}

    public ICollection<NotaFiscalItem> NotaFiscalItems {get; set;} = new List<NotaFiscalItem>();

    [NotMapped]
    [Display(Name = "Arquivo XML")]
    public IFormFile? ArquivoXML {get; set;}
}
