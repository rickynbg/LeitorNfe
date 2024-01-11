using Microsoft.EntityFrameworkCore;
using LeitorNfe.Models;

namespace LeitorNfe.Data
{
    public class NotaFiscalContext(DbContextOptions<NotaFiscalContext> options) : DbContext(options)
    {
        public DbSet<NotaFiscal> NotaFiscal { get; set; } = default!;

        public DbSet<NotaFiscalItem> NotaFiscalItem { get; set; } = default!;
    }
}
