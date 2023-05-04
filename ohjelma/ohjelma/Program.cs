    class Program
    {
        static void Main(string[] args)
        {
            string lukija = "";
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Anna komento. näytä,lisää,poista,poistu-");
                lukija = Console.ReadLine().ToLower();
                switch (lukija)
                {
                    case "näytä":
                        KokoelmaManageri.TulostaKokoelma();
                        break;
                    case "lisää":
                        Lisää();
                        break;
                    case "poista":
                        Poista();
                        break;
                    case "poistu":
                        Console.WriteLine("poistutaan sovelluksesta");
                        return;
                    default:
                        Console.WriteLine("virheellinen, yritä uudelleen");
                        break;
                }
            }
        }
        static void Lisää()
        {
            string etunimi = "";
            string sukunimi = "";
            Console.WriteLine();
            Console.WriteLine("---");
            Console.WriteLine("laita uuden opiskelijan tiedot: ");
            Console.WriteLine();
            Console.Write("etunimi: ");
            etunimi = Console.ReadLine();
            Console.Write("sukunimi: ");
            sukunimi = Console.ReadLine();
            KokoelmaManageri.LisääOpiskelija(etunimi, sukunimi);
        }
        static void Poista()
        {
            if (KokoelmaManageri.Opiskelijat.Count == 0)
            {
                Console.WriteLine("opiskelija kokoelma on tyhjänä");
                return;
            }
            KokoelmaManageri.TulostaKokoelma();
            int lukijaIndex;
            int opiskelijaMäärä = KokoelmaManageri.Opiskelijat.Count;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("kenet haluaisit poistaa. Valitse {0} - {1} välistä- ", 1, opiskelijaMäärä);
                bool result = int.TryParse(Console.ReadLine(), out lukijaIndex);
                if (result)
                {
                    if (lukijaIndex <= opiskelijaMäärä && lukijaIndex > 0)
                    {
                        KokoelmaManageri.PoistaOpiskelija(lukijaIndex - 1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("virheellinen. laita uusi valintasi");
                    }
                }
                else
                {
                    Console.WriteLine("virheellimem. vain numerot kelpaavat");
                }
            }
        }
    }