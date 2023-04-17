using System;
using System.Collections.Generic;
using System.Text;
namespace eläimet
{
    class kissa : Eläin
    {
        private string kissanääni { get; set; }

        public override int MaxIkä { get => maxIkä; set => maxIkä = value; }

        private static int määrä = 0;

        public kissa(string nimi, int ikä, string ääni)
        {
            MaxIkä=15;
            Nimi=nimi;
            Ikä=ikä;
            kissanääni=ääni;
            määrä++;
            Console.WriteLine("kissa on luotu nimi: " + Nimi);
        }
        public static new void Määrä()
        {
            Console.WriteLine("Kissoja on yhteensä luotu " + määrä + " kappaletta");
        }
        public override void Ääni()
        {
            Console.WriteLine(Nimi + " sanoo: meow");
        }
    }
}