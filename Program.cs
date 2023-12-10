
using System;

class Program
{
    static void Main()
    {
        Car car1 = new Car("Toyota", 2020, "Corolla", 4, 1.8, 6.5);
        Console.WriteLine($"Marka: {car1.Marka}, Model: {car1.Model}, Rok: {car1.Rok}, Ilość Drzwi: {car1.IloscDrzwi}, Pojemność Silnika: {car1.PojemnoscSilnika}, Średnie Spalanie: {car1.SrednieSpalanie}");

        double kosztPrzejazdu = car1.ObliczKosztPrzejazdu(100, 5.5);
        Console.WriteLine($"Koszt przejazdu na 100 km przy cenie paliwa 5.5 zł/l to: {kosztPrzejazdu} zł");
    }
}
