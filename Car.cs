
public class Car
{
    private string marka;
    private int rok;
    private string model;
    private int iloscDrzwi;
    private double pojemnoscSilnika;
    public double SrednieSpalanie { get; set; }

    public string Marka
    {
        get { return marka; }
        set { marka = value; }
    }

    public int Rok
    {
        get { return rok; }
        set
        {
            if (value >= 1769 && value <= 2017)
            {
                rok = value;
            }
            else
            {
                rok = 0; // Ustawienie wartości domyślnej w przypadku nieprawidłowego roku
                Console.WriteLine("Nieprawidłowy rok produkcji. Ustawiono wartość domyślną.");
            }
        }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int IloscDrzwi
    {
        get { return iloscDrzwi; }
        set { iloscDrzwi = value; }
    }

    public double PojemnoscSilnika
    {
        get { return pojemnoscSilnika; }
        set { pojemnoscSilnika = value; }
    }

    // Konstruktor
    public Car(string marka, int rok, string model, int iloscDrzwi, double pojemnoscSilnika, double srednieSpalanie)
    {
        this.marka = marka;
        this.rok = rok;
        this.model = model;
        this.iloscDrzwi = iloscDrzwi;
        this.pojemnoscSilnika = pojemnoscSilnika;
        this.SrednieSpalanie = srednieSpalanie;
    }

    // Prywatna metoda ObliczSpalanie
    private double ObliczSpalanie(double dlugoscTrasy)
    {
        return SrednieSpalanie * dlugoscTrasy;
    }

    // Publiczna metoda ObliczKosztPrzejazdu
    public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
    {
        double spalanie = ObliczSpalanie(dlugoscTrasy);
        return spalanie * cenaPaliwa;
    }
}
