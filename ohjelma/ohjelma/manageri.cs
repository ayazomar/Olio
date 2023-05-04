class KokoelmaManageri
{
    public static Dictionary<string, Opiskelija> Opiskelijat = new Dictionary<string, Opiskelija>();
    public static void LisääOpiskelija(string etunimi, string sukunimi)
    {
        bool sallittu = false;
        string opiskelijaID = "";
        while (!sallittu)
        {
            try
            {
                Console.Write("OpiskelijaID: ");
                opiskelijaID = Console.ReadLine();
                sallittu = TarkistaID(opiskelijaID);
            }
            catch (poikkeus)
            {

            }
        }
        if (sallittu)
        {
            Opiskelijat.Add(opiskelijaID, new Opiskelija(etunimi, sukunimi, opiskelijaID));
            TulostaViesti(string.Format("uusi opiskelija {0} lisätty kokoelmaan", Opiskelijat[opiskelijaID].HaeDataa()));
        }
    }
    public static bool TarkistaID(string id)
    {
        if (Opiskelijat.ContainsKey(id))
        {
            throw new poikkeus("ppiskelijaID " + id + " ei ole erilainen, anna uusi ID");
        }
        else if (id.Length <= 4 || id.Length >= 6)
        {
            throw new poikkeus("OpiskelijaID " + id + " on liian pitkä/lyhyt. Opiskelija ID pituus täytyy olla 5");
        }
        else
        {
            return true;
        }
    }
    public static void PoistaOpiskelija(int syötettyIndex)
    {
        int i = 0;

        foreach (string avain in Opiskelijat.Keys)
        {
            if (i == syötettyIndex)
            {
                TulostaViesti("Opiskelija " + Opiskelijat[avain].HaeDataa() + " poistettu kokoelmasta");
                Opiskelijat.Remove(avain);
                break;
            }
            i++;
        }
    }
    public static void TulostaKokoelma()
    {
        if (Opiskelijat.Count == 0)
        {
            TulostaViesti("Opiskelija kokoelma on tyhjä");
            return;
        }
        int i = 1;
        TulostaViesti("Opiskelijat kokoelmassa: ");

        foreach (Opiskelija opiskelija in Opiskelijat.Values)
        {
            Console.WriteLine("{0}: {1}", i, opiskelija.HaeDataa());
            i++;
        }
    }
    public static void TulostaViesti(string message)
    {
        Console.WriteLine();
        Console.WriteLine("---");
        Console.WriteLine(message);
    }
}
