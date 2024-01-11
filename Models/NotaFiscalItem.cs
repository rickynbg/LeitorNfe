using System.ComponentModel.DataAnnotations;

namespace LeitorNfe.Models;


public class NotaFiscalItem
{
    public int Id {get; set;}
    
    [Display(Name = "Número do item")]
    public int? NumItem {get; set;}

    [Display(Name = "Código do produto")]
    public string? CodProd {get; set;}

    public string? Nome {get; set;}

    [Display(Name = "Quantidade comprada")]
    public double QuantidadeComprada {get; set;}

    [DataType(DataType.Currency)]
    [Display(Name = "Valor unitário")]
    public double ValUnit {get; set;}

    [DataType(DataType.Currency)]
    [Display(Name = "Valor total")]
    public double ValTotal {get; set;}

    public int NotaFiscalId {get; set;}
    public required NotaFiscal NotaFiscal {get; set;}
}