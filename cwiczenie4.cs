// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ile pieniędzy wpłacisz na konto oszczędnościowe? ");
        decimal kwotaPoczatkowa = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Jakie ma być oprocentowanie konta w skali roku? (%) ");
        decimal oprocentowanie = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ile miesięcy będziesz oszczędzać? ");
        int liczbaMiesiecy = Convert.ToInt32(Console.ReadLine());

        decimal kwotaKoncowa = ObliczKwoteKoncowa(kwotaPoczatkowa, oprocentowanie, liczbaMiesiecy);

        Console.WriteLine("Kwota końcowa oszczędności (uwzględniając podatek Belki): " + kwotaKoncowa);

        Console.ReadLine();
    }

    static decimal ObliczKwoteKoncowa(decimal kwotaPoczatkowa, decimal oprocentowanie, int liczbaMiesiecy)
    {
        decimal oprocentowanieMiesieczne = oprocentowanie / 12 / 100;
        decimal kwotaKoncowa = kwotaPoczatkowa * (decimal)Math.Pow((double)(1 + oprocentowanieMiesieczne), liczbaMiesiecy);

        kwotaKoncowa = kwotaKoncowa * (decimal)Math.Pow((double)(1 - 0.19), liczbaMiesiecy);

        return kwotaKoncowa;
    }
}

