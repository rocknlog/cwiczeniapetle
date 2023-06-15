// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Wprowadź liczbę x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        int n = FindFactorial(x);

        if (n != -1)
        {
            Console.WriteLine(x + " jest silnią liczby " + n);
        }
        else
        {
            Console.WriteLine(x + " nie jest silnią żadnej liczby.");
        }
    }

    static int FindFactorial(int x)
    {
        int n = 0;
        int factorial = 1;

        while (factorial < x)
        {
            n++;
            factorial *= n;
        }

        if (factorial == x)
        {
            return n;
        }
        else
        {
            return -1; // Jeśli x nie jest silnią żadnej liczby, zwracamy -1
        }
    }
}

