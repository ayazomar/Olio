using System;
using Tehtävä5;

    class Program
    {
        static void Main(string[]args)
        {
            float a = 3.5f;

            float b = 2.5f;

            float summa = laskin.Summa(a, b);
            float erotus = laskin.Erotus(a, b);
            float kertolasku = laskin.Kertolasku(a, b);
            float jakolasku = laskin.Jakolasku(a, b);
            Console.WriteLine("Numeroiden " +a+" ja "+b);

            Console.WriteLine("Summa: " +summa);

            Console.WriteLine("Erotus: " +erotus);

            Console.WriteLine("Kertolasku: " + kertolasku);


            Console.WriteLine("Jakolask: " + jakolasku);
        }
    }