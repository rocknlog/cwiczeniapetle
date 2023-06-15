// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Wprowadź wartość x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        int n = 10; // Liczba pierwszych wyrazów do uwzględnienia w szeregu
        double result = CalculateExponential(x, n);

        Console.WriteLine("Szacowana wartość funkcji e^x: " + result);
    }

    static double CalculateExponential(double x, int n)
    {
        double sum = 1.0; // Pierwszy wyraz szeregu

        double term = 1.0;
        double factorial = 1.0;

        for (int i = 1; i <= n; i++)
        {
            term *= x / i;
            factorial *= i;
            sum += term;
        }

        return sum;
    }
}

