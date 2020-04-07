using System;

namespace _04_04
{
    class Converter1
    {
        static void Main()
        {
          Converter course=new Converter(10.2183,11.0174,0.1316);
          Console.WriteLine("If you want to exchange Somoni for DOLAR or EURO or RUBLE, press 1:");
          Console.WriteLine("If you want to change DOLLAR or EURO or RUBLE to SOMONI, press 2:");
          int choice=Int32.Parse(Console.ReadLine());
          if(choice==1)

          {
            Console.WriteLine($"Somoni to Dollar 1: "+" Somoni to Euro 2:"+" Somoni Rubl 3:");
            int choice1=Int32.Parse(Console.ReadLine());
          Console.WriteLine("Enter the amount you want to change:");
          double answer=Int32.Parse(Console.ReadLine());
          switch(choice1)
          {
              case 1:
              course.somtousd(answer); break;
              case 2:
              course.somtoeur(answer); break;
              case 3:
              course.somtorubl(answer); break;
              }
          }
          else
          {
            Console.WriteLine($"Dolar to Somoni 1:"+" Evro to Somoni 2:"+" Rubl to Somoni 3:"); 
            int choice2=Int32.Parse(Console.ReadLine());
          Console.WriteLine("Enter the amount you want to change");
          double answer1=Int32.Parse(Console.ReadLine());
          switch(choice2)
          {
              case 1:
              course.usdtosom(answer1);
              break;
              case 2:
              course.eurtosom(answer1);
              break;
              case 3:
              course.rubltosom(answer1);
              break;
              }
          }
        }
    }
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

