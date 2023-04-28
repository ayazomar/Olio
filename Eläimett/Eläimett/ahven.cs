using System.Xml.Linq;

class Kala : Eläin, ICanSwim
{
    public int SwimSpeed { get; set; }
    public string Sound { get; set; }
    public Kala(string nimi, int nopeus, string ääni)
    {
        Name = nimi;
        SwimSpeed = nopeus;
        Sound = ääni;
    }
    public override void MakeASound()
    {
        Console.WriteLine(Sound);
    }
    public void Swim()
    {
        Console.WriteLine("{0} ui nopeudella {1}", Name, SwimSpeed);
    }
}
