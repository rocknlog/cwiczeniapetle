// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Wprowadź liczbę n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pary liczb naturalnych o sumie " + n + ":");

        FindNumberPairs(n);
    }

    static void FindNumberPairs(int n)
    {
        for (int i = 0; i <= n / 2; i++)
        {
            int j = n - i;
            Console.WriteLine("(" + i + ", " + j + ")");
        }
    }
}

