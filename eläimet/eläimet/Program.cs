using System;
namespace eläimet
{
    class Program
    {
        static void Main(string[] args)
        {
            kissa ayaz = new kissa("Ayaz", 17, "moi");
            kissa omar = new kissa("Omar", 73, "moro");
            ayaz.Ääni();
            omar.Ääni();
            Koira ayaaz = new Koira("vapinpystykoira", 4);
            Koira omaar = new Koira("beagle", 1);
            ayaaz.Ääni();
            Eläin.Määrä();
            kissa.Määrä();
            Koira.Määrä();
        }
    }
}