
using System.Windows.Forms;

public class Car
{
    private double pojemnoscSilnika;
    private string marka;

    private Car() 
    {
        // Domyślny konstruktor teraz prywatny
    }

    public Car(double pojemnoscSilnika, string marka)
    {
        this.pojemnoscSilnika = pojemnoscSilnika;
        this.marka = marka;
    }

    public static Car Create()
    {
        return new Car();
    }

    private static int iloscKol;

    static Car()
    {
        iloscKol = 4;
    }

    ~Car()
    {
        MessageBox.Show("Zwalniam pamięć");
    }
}
