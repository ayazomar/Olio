using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Työntekijä : Henkilö
    {
        public Työntekijä(string nimi,string työpaikka,int palkka,int tunti)
        {
            Nimi = nimi;
            Työpaikka = työpaikka;
            Palkka = palkka;
            tunnit = tunti;
        }
        public void Tuntilasku()
        {
            Console.WriteLine("Työntekijän tunnit:  ");
            Console.WriteLine(Nimi);
            Console.WriteLine(tunnit);
        }
    }