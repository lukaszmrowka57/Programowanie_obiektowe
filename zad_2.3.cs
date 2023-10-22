using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoją wagę w kilogramach:");
            double waga;
            while (!double.TryParse(Console.ReadLine(), out waga) || waga <= 0)
            {
                Console.WriteLine("Proszę podać poprawną wartość dla wagi.");
            }

            Console.WriteLine("Podaj swój wzrost w centymetrach:");
            double wzrostWcm;
            while (!double.TryParse(Console.ReadLine(), out wzrostWcm) || wzrostWcm <= 0)
            {
                Console.WriteLine("Proszę podać poprawną wartość dla wzrostu.");
            }
            
            double wzrost = wzrostWcm / 100;  // przeliczenie z cm na m

            double bmi = waga / (wzrost * wzrost);
            Console.WriteLine($"Twój wskaźnik BMI wynosi: {bmi:F2}.");
        }
    }
}
