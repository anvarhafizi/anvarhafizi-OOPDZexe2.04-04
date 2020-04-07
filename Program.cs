using System;

namespace _04_04
{
    class Converter
    {
    public double usd{set;get;}
     public double eur{set;get;}
     public double rub{set;get;}
     public Converter(double usd, double eur, double rub)
     {
       this.usd=usd;
       this.eur=eur;
       this.rub=rub;
     }
     public void somtousd(double m)
     {
        double answer2=m/usd;
        Console.WriteLine($"Amount of money {answer2}$");
     }
    public void somtoeur(double m)
     {
        double answer2=m/eur;
        Console.WriteLine($"Amount of money {answer2} euro");
     }
      public void somtorubl(double m)
     {
        double answer2=m/rub;
        Console.WriteLine($"Amount of money {answer2} Rubl");
     }

     public void usdtosom(double m)
     {
        double answer2=m*usd;
        Console.WriteLine($"Amount of money {answer2} Somon");
     }
    public void eurtosom(double m)
     {
        double answer2=m*eur;
        Console.WriteLine($"Amount of money {answer2} Somon");
     }
      public void rubltosom(double m)
     {
        double answer2=m*rub;
        Console.WriteLine($"Amount of money {answer2} Somon");
     }

    }
}

