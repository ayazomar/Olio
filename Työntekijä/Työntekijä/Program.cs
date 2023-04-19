internal class Program
{
    static void Main(string[] args)
    {
        Henkilö työntekijä1 = new Työntekijä("Ayaz", "Volvo", 4500, 5);
        Henkilö työntekijä2 = new Työntekijä("Omar", "Apple", 5000, 5);
        Pomo pomo1 = new Pomo();
        Pomo pomo2 = new Pomo();
        pomo1.pomolasku();
    }
}