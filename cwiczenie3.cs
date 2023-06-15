// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        int n, k;

        do
        {
            Console.Write("Wprowadź liczbę n (większą lub równą 5): ");
            n = Convert.ToInt32(Console.ReadLine());
        } while (n < 5);

        do
        {
            Console.Write("Wprowadź liczbę k (większą lub równą 5): ");
            k = Convert.ToInt32(Console.ReadLine());
        } while (k < 5);

        int m = ObliczM(n, k);

        Console.WriteLine("M wynosi " + m);

        Console.ReadLine();
    }

    static int ObliczM(int n, int k)
    {
        int nSilnia = ObliczSilnie(n);
        int kSilnia = ObliczSilnie(k);

        int m = (nSilnia - kSilnia) / kSilnia;

        return m;
    }

    static int ObliczSilnie(int x)
    {
        int silnia = 1;

        for (int i = 2; i <= x; i++)
        {
            silnia *= i;
        }

        return silnia;
    }
}

