class Program
{
    static void Main(string[] args)
    {
        Kala ahven = new Kala("ahven", 63, "plump");
        ahven.Swim();
        ahven.MakeASound();
        Sorsa sorsa = new Sorsa("sorsa", 83, 13);
        sorsa.MakeASound();
        sorsa.Swim();
        sorsa.MakeASound();
        sorsa.Fly();
    }
}
