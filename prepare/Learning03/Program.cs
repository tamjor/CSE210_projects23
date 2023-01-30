using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();

        Fraction frac2 = new Fraction(1);

        Fraction frac3 = new Fraction(5,1);

        Console.WriteLine();
        Console.WriteLine("Frac1");
        frac1.GetFractionString();
        frac1.GetDecimalString();
        
        Console.WriteLine();
        Console.WriteLine("Frac2");
        frac2.GetFractionString();
        frac2.GetDecimalString();

        Console.WriteLine();
        Console.WriteLine("Frac3");
        frac3.GetFractionString();
        frac3.GetDecimalString();
       

    }
}