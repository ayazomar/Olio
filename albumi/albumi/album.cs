using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albumi
{
    internal class Album
    {
        public string artisti;

        public string nimi;

        public string genre;

        public int hinta;

        public List<string> kappale=new List<string>();
        public void Kappaleenlista(string kappaleet)
        {
            kappale.Add(kappaleet);
        }
        public void TulostaDataa()
        {
            Console.WriteLine("albumi: ");
            Console.WriteLine("artisti: " + artisti);
            Console.WriteLine("nimi: " + nimi);
            Console.WriteLine("genre: " + genre);
            Console.WriteLine("hinta: " + hinta + " euroa");
            Console.WriteLine();
        }

        public void MusiikinTulostus()
        {
            Console.WriteLine("\n*" + kappale[0]);
            Console.WriteLine("*"+kappale[1]);
            Console.WriteLine("*"+kappale[2]);
            Console.WriteLine("*"+kappale[3]);
            Console.WriteLine("*"+kappale[4]);
            Console.WriteLine("*" +kappale[5]);
        }

    }
}