namespace kiuas
{
    class Kiuas
    {
        public string Nimi { get; set; }
        private bool Tila { get; set; }
        private int Lämpötila { get; set; }
        private int Kosteus { get; set; }
        public void TulostaDataa()
        {
            Console.WriteLine("kiukan tiedot ");
            Console.WriteLine("nimi: " + Nimi);
            Console.WriteLine("tila: " + NäytäTila());
            Console.WriteLine("lämpötila: " + Lämpötila + " Celsius");
            Console.WriteLine("kosteus: " + Kosteus + "%");
            Console.WriteLine();
        }
        public string NäytäTila()
        {
            string nykyinenTila = "pois Päältä";
            if(Tila == true)
            {
                nykyinenTila = "päällä";
            }
            return nykyinenTila;
        }

        public void KiuasOnOff(bool a)
        {
            Tila = a;
            Console.Write("kiuas on nyt " + NäytäTila() + "\n");
        }

        public void MuutaLämpötilaa(int uusiLämpötila)
        {
            if (Tila == false)
            {
                Console.WriteLine("kiuas ei ole päällä. lämpötilaa ei voida muuttaa\n");
                return;
            }
            Lämpötila = uusiLämpötila;
            Console.WriteLine("Lämpötila muutettu. Uusi lämpötila: " + Lämpötila + " celsius\n");
        }
        public void MuutaKosteutta(int uusiKosteus)
        {
            if (Tila == false)
            {
                Console.WriteLine("Kiuas ei ole päällä, kosteutta ei voi muuttaa\n");
                return;
            }
            Kosteus = uusiKosteus;
            Console.WriteLine("Kosteutta on muutettu. Uusi kosteus: " + Kosteus + "%\n");
        }
    }
}
