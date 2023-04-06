using kiuas;
using System;

namespace Harjoitus_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas = new Kiuas();
            kiuas.Nimi = "Ayaz";
            kiuas.TulostaDataa();
            kiuas.KiuasOnOff(true);
            kiuas.NäytäTila();
            kiuas.MuutaLämpötilaa(57);
            kiuas.MuutaKosteutta(10);
            kiuas.TulostaDataa();

        }
    }
}