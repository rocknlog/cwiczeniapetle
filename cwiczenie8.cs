// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        int lowerBound = 1; // Dolna granica przedziału
        int upperBound = 20; // Górna granica przedziału

        Console.WriteLine("Wybierz liczbę całkowitą od 1 do 20.");

        int guess;
        int attempts = 0;
        bool guessed = false;

        while (!guessed)
        {
            guess = (lowerBound + upperBound) / 2;

            Console.WriteLine("Czy Twoja liczba to " + guess + "?");
            Console.WriteLine("Odpowiedz ujemną, jeśli Twoja liczba jest mniejsza, dodatnią, jeśli Twoja liczba jest większa, lub zero, jeśli odgadłem:");

            int response = Convert.ToInt32(Console.ReadLine());

            attempts++;

            if (response < 0)
            {
                upperBound = guess - 1;
            }
            else if (response > 0)
            {
                lowerBound = guess + 1;
            }
            else
            {
                Console.WriteLine("Odgadłem! Twoja liczba to " + guess + ".");
                Console.WriteLine("Liczba prób: " + attempts);
                guessed = true;
            }
        }
    }
}

