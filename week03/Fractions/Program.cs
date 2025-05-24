using System;

class Program
{
    static void Main(string[] args)
    {
       
        Fraction f1 = new Fraction();
        Console.WriteLine($"Fraction 1: {f1.GetFractionString()} = {f1.GetDecimalValue()}");

        
        Fraction f2 = new Fraction(5);
        Console.WriteLine($"Fraction 2: {f2.GetFractionString()} = {f2.GetDecimalValue()}");

        
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction 3: {f3.GetFractionString()} = {f3.GetDecimalValue()}");

     
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine($"Fraction 4: {f4.GetFractionString()} = {f4.GetDecimalValue()}");

        
        f4.SetTop(7);
        f4.SetBottom(10);
        Console.WriteLine($"Updated Fraction 4: {f4.GetFractionString()} = {f4.GetDecimalValue()}");
    }
}
