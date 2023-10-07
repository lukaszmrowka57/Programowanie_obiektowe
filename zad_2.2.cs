using System;

namespace DeltaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Podaj b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Podaj c: ");
            double c = double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;
            Console.WriteLine($"Delta wynosi: {delta}");
        }
    }
}