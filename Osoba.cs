
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
}
