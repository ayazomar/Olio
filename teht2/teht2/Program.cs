
namespace Harjoitus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija1= new Opiskelija("Ayaz", "DATV22", 0);
            opiskelija1.MuokkaaOpintopisteitä(5);
            opiskelija1.TulostaData();
        }
    }
}
