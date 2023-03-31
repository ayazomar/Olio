using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoituss
{
    internal class ajo
    {
        public string nimi;
        public int nopeus;
        public int renkaat;

        public string TulostaData()
        {
            string AjoneuvonTiedot = "Nimi: " + nimi +  " Nopeus: " + nopeus.ToString() + " Renkaaiden määrä: " + renkaat.ToString();
            return AjoneuvonTiedot;
        }
    }
}
