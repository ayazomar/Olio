using harjoituss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        ajo Ajo = new ajo();

        Ajo.nimi = "Jaguar";
        Ajo.nopeus = 200;
        Ajo.renkaat = 4;

        Console.WriteLine(Ajo.TulostaData());
    }
}
