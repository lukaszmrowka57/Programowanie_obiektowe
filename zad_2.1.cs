using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj temperaturę w stopniach Celsjusza: ");

            
            string input = Console.ReadLine();

            
            if (double.TryParse(input, out double celsius))
            {
                
                double fahrenheit = CelsiusToFahrenheit(celsius);

                
                Console.WriteLine($"{celsius} stopni Celsjusza to {fahrenheit:F2} stopni Fahrenheita.");
            }
            else
            {
                
                Console.WriteLine("Proszę wprowadzić prawidłową wartość liczbową.");
            }
        }

        
        static double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32;
        }
    }
}