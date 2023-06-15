// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Jaką liczbę wyrazów wygenerować? ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ciąg Fibonacciego:");

        for (int i = 0; i < n; i++)
        {
            int fib = Fibonacci(i);
            Console.Write(fib + " ");
        }

        Console.ReadLine();
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        int fibPrev = 0;
        int fibCurr = 1;

        for (int i = 2; i <= n; i++)
        {
            int temp = fibCurr;
            fibCurr = fibPrev + fibCurr;
            fibPrev = temp;
        }

        return fibCurr;
    }
}

