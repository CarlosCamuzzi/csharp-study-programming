using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
  public class Calculadora
  {    
    public Calculadora(decimal primeiroNumero, decimal segundoNumero)
    {
      PrimeiroNumero = primeiroNumero;
      SegundoNumero = segundoNumero;
    }
    private decimal PrimeiroNumero { get; set; }
    private decimal SegundoNumero { get; set; }

  public decimal Soma { get; set; }  

    public decimal Somar()
    {
      Soma = PrimeiroNumero + SegundoNumero;
      return Soma;
    }
  }
}