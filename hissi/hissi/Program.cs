using System;

namespace Harjoitus_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi(1, 6);

            int uusiKerros;
            string i;

            Console.WriteLine("Tämä on hissi voit poistua kirjoittamalla 'ulos'.");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Anna uusi kerros ({0}) < ", hissi.PalautaMinMax());

                i = Console.ReadLine();

                if (i.Equals("ulos"))
                    break;

                bool tarkistus = int.TryParse(i, out uusiKerros);

                if (tarkistus)
                {
                    hissi.Kerros = uusiKerros;
                }
                else
                {
                    Console.WriteLine("Virheellinen kerros ");
                }

                hissi.TulostaNykyinenKerros();
            }

            Console.WriteLine("Poistuit hissistä!");
        }
    }
}