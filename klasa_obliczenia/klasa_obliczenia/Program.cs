
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wybierz operację: +, -, *, /, ^, √ (dla pierwiastka druga liczba zostanie zignorowana)");
            string operacja = Console.ReadLine();

            double wynik;

            switch (operacja)
            {
                case "+":
                    wynik = Obliczenia.Dodawanie(num1, num2);
                    break;
                case "-":
                    wynik = Obliczenia.Odejmowanie(num1, num2);
                    break;
                case "*":
                    wynik = Obliczenia.Mnozenie(num1, num2);
                    break;
                case "/":
                    wynik = Obliczenia.Dzielenie(num1, num2);
                    break;
                case "^":
                    wynik = Obliczenia.Potegowanie(num1, num2);
                    break;
                case "√":
                    wynik = Obliczenia.Pierwiastkowanie(num1);
                    break;
                default:
                    throw new InvalidOperationException("Nieznana operacja.");
            }

            Console.WriteLine($"Wynik: {wynik}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Błąd formatu liczby.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Błąd: próba dzielenia przez zero.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Nieoczekiwany błąd: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Koniec działania programu.");
        }
    }
}
