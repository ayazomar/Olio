internal class Radio
    {
        private bool Tila { get; set; }
        public void Kytkin()
        {
            Console.WriteLine("y kirjainta painamalla laitat radion päälle ");
            string tarkistus = Console.ReadLine();

            if (tarkistus == null)
            {
                Console.WriteLine(" Käynnistä uudelleen.");
            }
            else if (tarkistus == "p")
            {
                Tila = true;
                Console.WriteLine("Radio laitettu päälle");
            }
            else
            {
                Console.WriteLine("Käynnistä uudelleen");
            }
        }
        public string TaajuusYksikkö = "MHz";
        private readonly double Minimitaajuus = 57.0f;
        private readonly double Maksimitaajuus = 166.3f;
        private double taajuus;
        public double Taajuus
        {
            get { return taajuus; }
            set
            {
                if (value > Maksimitaajuus)
                {
                    value = Maksimitaajuus;
                }
                else if (value < Minimitaajuus)
                {
                    value = Minimitaajuus;
                }
                taajuus = value;
            }
        }
        private readonly int MaxÄäni = 15;
        private readonly int MinÄäni = 0;

        private int ääni;

        public int Ääni
        {
            get { return ääni; }
            set
            {
                if (value < MinÄäni)
                {
                    value = MinÄäni;
                }
                else if (value > MaxÄäni)
                {
                    value = MaxÄäni;
                }
            }
        }
        public void Ääni1()
        {
            Console.WriteLine("Pistä äänen voimakkuutta 0-15 väliltä.");
            int Äänicheck = int.Parse(Console.ReadLine());
            Ääni = Äänicheck;
            if (Äänicheck < MinÄäni)
            {
                Console.WriteLine("Et pysty laittaa vähemmän ääntä enään : " + MinÄäni.ToString());
            }
            else if (Äänicheck > MaxÄäni)
            {
                Console.WriteLine("Äänen voimakkuus on jo täysillä : " + MaxÄäni.ToString());
            }
        }
        public void Taajuus1()
        {
            Console.WriteLine("Laita taajuutta 57,0 - 166,3 väliltä");
            double Taajuuscheck = double.Parse(Console.ReadLine());
            Taajuus = Taajuuscheck;
            if (Taajuuscheck < Minimitaajuus)
            {
                Console.WriteLine("Et pysty laittaa vähemmän taajuutta enään : " + Minimitaajuus.ToString()
                    + " " + TaajuusYksikkö);
            }
            else if (Taajuuscheck > Maksimitaajuus)
            {
                Console.WriteLine("Taajuus on jo täysillä : " + Maksimitaajuus.ToString()
                    + " " + TaajuusYksikkö);
            }

        }
        private string tark;

        public string Tark
        {
            get { return tark; }
            set { tark = value; }
        }
}