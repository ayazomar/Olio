using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus
{
    internal class Ajoneuvo
    {
        public string nimi;
        public int nopeus;
        public int renkaat;

        public string TulostaData()
        {
            string AjoneuvonTiedot = "Nimi: " + nimi + "Nopeus:  " + nopeus.ToString() + "Renkaat:  " + renkaat.ToString();
            return AjoneuvonTiedot;
        }
    }
}