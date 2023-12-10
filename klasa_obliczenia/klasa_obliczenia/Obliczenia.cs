
using System;

public static class Obliczenia
{
    public static double Dodawanie(double a, double b)
    {
        return a + b;
    }

    public static double Odejmowanie(double a, double b)
    {
        return a - b;
    }

    public static double Mnozenie(double a, double b)
    {
        return a * b;
    }

    public static double Dzielenie(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Nie można dzielić przez zero.");
        return a / b;
    }

    public static double Potegowanie(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public static double Pierwiastkowanie(double a)
    {
        if (a < 0)
            throw new ArgumentException("Nie można obliczyć pierwiastka z liczby ujemnej.");
        return Math.Sqrt(a);
    }
}
