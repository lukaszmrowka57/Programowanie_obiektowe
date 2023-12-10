
using System;

class Wyjatki
{
    static void Main()
    {
        try
        {
            int liczba1;
            int liczba2 = 30;
            int liczba3 = 0; // Aby uniknąć bezpośredniego dzielenia przez zero
            liczba1 = liczba2 / liczba3;

            int[] table = new int[2];
            table[25] = 2; // Próba wyjścia poza zakres tablicy

            throw new IndexOutOfRangeException(); // Rzucenie wyjątku celowo
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Nie lubię dzielić przez zero: " + e.Message);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Próba dostępu poza zakres tablicy: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Wyjątek: " + e.Message);
        }
        finally
        {
            Console.WriteLine("FINALLY");
        }
    }
}
