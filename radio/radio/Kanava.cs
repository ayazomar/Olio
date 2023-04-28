internal class Kanava
{
        private string Nimi { get; set; }
        static double Taajuus1 { get; set; }
        public void kanava(string nimi, double taajuus)
        {
            Nimi = nimi;
            Taajuus1 = taajuus;
        }
        public double TaajuusP = Taajuus1;
}