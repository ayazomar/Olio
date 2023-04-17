using System;
using System.Collections.Generic;
using System.Text;
namespace eläimet
{
    class Koira : Eläin
    {
        public override int MaxIkä { get => maxIkä; set => maxIkä = value; }

        private static int määrä = 0;

        public Koira(string nimi, int ikä)
        {
            MaxIkä = 22;
            Nimi = nimi;
            Ikä = ikä;
            määrä++;
            Console.WriteLine("Uusi Koira luotu ja koiran nimi: " + Nimi);
        }

        public static new void Määrä()
        {
            Console.WriteLine("Koiria on yhteensä luotu " + määrä + " kappaletta");
        }
        public override void Ääni()
        {
            Console.WriteLine(Nimi + " sanoo: Woof");
        }
    }
}