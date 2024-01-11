namespace LeitorNfe.Models;

public class FilterViewModel
{
    public required IEnumerable<NotaFiscal> NotasFiscais { get; set; }
    public DateTime? SearchDate { get; set; }
    public int? SearchNum { get; set; }
    public string? SearchEmit { get; set; }
    public string? SearchDest { get; set; }

}