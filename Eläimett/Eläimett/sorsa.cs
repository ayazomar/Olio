 class Sorsa : Eläin, ICanSwim, ICanFly
{
    public int SwimSpeed { get; set; }
    public float WingSize { get; set; }
    public Sorsa(string nimi, float siipikoko, int nopeus)
    {
        Name = nimi;
        WingSize = siipikoko;
        SwimSpeed = nopeus;
    }
    public void Fly()
    {
        Console.WriteLine("{0} lentää ja {0}n siipien koko on {1}", Name, WingSize);
    }
    public override void MakeASound()
    {
        Console.WriteLine("kwaak");
    }

    public void Swim()
    {
        Console.WriteLine("{0} ui nopeudella {1}", Name, SwimSpeed);
    }
}