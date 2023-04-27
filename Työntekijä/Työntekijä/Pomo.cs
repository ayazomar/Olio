using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    class Pomo:Henkilö
    {
        private static int määrä = 0;
        public Pomo()
        {
            määrä++;
        }
        public void pomolasku()
        {
            if (Pomo.määrä > 1)
            {
                Console.WriteLine("Pomoja ei pysty olla kuin vain yksi. Nyt on " + Pomo.määrä);
            }
        }
    }