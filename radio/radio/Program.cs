class Program
{
    private static void Main(string[] args)
    {
        Radio radio = new Radio();
        radio.Kytkin();
        radio.Taajuus1();
        radio.Ääni1();
        Kanava kanava1 = new Kanava();
        kanava1.kanava("Moi", 88.2f);
        if (radio.Taajuus == kanava1.TaajuusP)
        {
            Console.WriteLine("Toimii");
        }
        while (true)
        {
            Console.WriteLine("paina r näppäintä, jotta voit muuttaa äänenvoimakkuutta. Paina t näppäintä, jotta voit mmuokkaa taajuutta. paina y, jotta voit nähdä missä kanavssa olet, Paina u näppäintä jotta suljet radion kiinni.");
            string tark = "";
            tark = Console.ReadLine();
            if (tark == "r")
            {
                radio.Ääni1();
            }
            else if (tark == "t")
            {
                radio.Taajuus1();
            }
            else if (tark == "y")
            {
                Console.WriteLine("Lähdet radiosta.");
                break;
            }
            else if (tark == "u")
            {
            }
            else
            {
                Console.WriteLine("Painoit väärää kirjainta");
                continue;
            }
        }
        if (radio.Taajuus == kanava1.TaajuusP)
        {
            Console.WriteLine("toimii");
        }
    }
}