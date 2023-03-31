
namespace Ajoneuvo
{
    class koira
    {
        public string nimi { get; set; }
        public string rotu { get; set; }
        public int ikä { get; set; }
        public string väri { get; set; }
        public float paino { get; set; }


        public string HaeTiedot()
        {
            string koirantiedot = "nimi: " + nimi + "rotu: " + rotu + "ikä: " + ikä.ToString() + ". väri: " + väri + ". paino" + paino.ToString();
            return koirantiedot;
        }
        public void hauku()
        {
            Console.WriteLine("woof woof");
        }
        
    }
}
