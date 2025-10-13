using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        fraction1.SetTop(2);
        fraction2.SetBottom(6);

        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} ({fraction1.GetDecimalValue()})");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()} ({fraction2.GetDecimalValue()})");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()} ({fraction3.GetDecimalValue()})");
    }
}