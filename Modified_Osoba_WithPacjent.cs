
using System;

public class Osoba
{
    public string imie;
    public string nazwisko;
    public int rokUrodzenia;
    public int waga;
    public int wzrost;
    public bool okulary;

    public enum Plec { K, M };
    public Plec plec;

    public int obliczWiek()
    {
        return DateTime.Now.Year - rokUrodzenia;
    }
    public string GetTytul()
    {
        return this.plec == Plec.K ? "Pani" : "Pan";
    }

}


public class Pacjent
{
    public string imie;
    public string nazwisko;
    public int wzrost; // Height in centimeters
    public int waga;   // Weight in kilograms

    public double ObliczBMI()
    {
        double heightInMeters = wzrost / 100.0;
        return waga / (heightInMeters * heightInMeters);
    }

    public string KategoriaWagi()
    {
        double bmi = ObliczBMI();
        if (bmi < 18.5) return "Niedowaga";
        if (bmi >= 18.5 && bmi < 25) return "Waga prawidłowa";
        if (bmi >= 25 && bmi < 30) return "Nadwaga";
        return "Otyłość";
    }
}