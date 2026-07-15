using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Fractions one = new Fractions();
        one.GetFractionString();
        one.GetDecimalValue();
        Fractions two = new Fractions(5);
        two.GetFractionString();
        two.GetDecimalValue();
        Fractions three = new Fractions(3,4);
        three.GetFractionString();
        three.GetDecimalValue();
        Fractions four = new Fractions(1,3);
        four.GetFractionString();
        four.GetDecimalValue();
        
    }
}