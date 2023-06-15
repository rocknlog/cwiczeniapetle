// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj podstawę: ");
        int podstawa = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj wykładnik: ");
        int wykladnik = Convert.ToInt32(Console.ReadLine());

        int wynik = Potegowanie(podstawa, wykladnik);

        Console.WriteLine("Wynik potęgowania: " + wynik);

        Console.ReadLine();
    }

    static int Potegowanie(int podstawa, int wykladnik)
    {
        int wynik = 1;

        for (int i = 1; i <= wykladnik; i++)
        {
            wynik *= podstawa;
        }

        return wynik;
    }
}

