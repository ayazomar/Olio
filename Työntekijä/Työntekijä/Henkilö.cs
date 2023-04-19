using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
    abstract class Henkilö
    {
        public string Nimi { get; set; }
        public string Työpaikka { get; set; }
        public int Palkka { get; set; }
        public int tunnit { get; set; }
        public void Tuntilasku()
        {
            Console.WriteLine("Työntekijän tunnit");
            Console.WriteLine(Nimi);
            Console.WriteLine(tunnit);
        }
        private static int määrä = 0;
        public Henkilö()
        {
            määrä++;
        }
        public static void Määrä()
        {
            Console.WriteLine("Henkilöitä on "+ määrä);
        }
    }