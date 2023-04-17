using System;
using System.Collections.Generic;
using System.Text;
namespace eläimet
{
    abstract class Eläin
    {
        public int maxIkä;
        public abstract int MaxIkä { get; set; }
        private string nimi;
        public string Nimi {get; set;}
        private int ikä;
        public virtual int Ikä
        {
            get { return ikä; }
            set
            {
                if (value < 10)
                {
                    Console.WriteLine("Antamasi ikä on pienempi kuin 10, joten eläimesi iäksi on laitettu 0");
                    value = 0;
                }
                else if (value > MaxIkä)
                {
                    Console.WriteLine(Nimi + " Antamasi ikä ylittää 10, joten iäksi laitetaan 0 ", MaxIkä, MaxIkä - 1);
                    value=MaxIkä - 1;
                }
                ikä = value;
            }
        }
        private static int määrä = 0;
        public Eläin()
        {
            määrä++;
        }
        public static void Määrä()
        {
            Console.WriteLine("Eläimiä on yhteensä " + määrä + " kappaletta");
        }
        public abstract void Ääni();
    }
}
