using albumi;
using albumi;

internal class Program
{
    private static void Main(string[] args)
    {
        Album albumit = new Album();

        albumit.artisti = "Nle Choppa";
        albumit.nimi = "Top shotta";
        albumit.genre = "Hip Hop";
        albumit.hinta = 10;
        albumit.Kappaleenlista("Capo");
        albumit.Kappaleenlista("Beat box");
        albumit.Kappaleenlista("Shotta Flow");
        albumit.Kappaleenlista("Famous hoes");
        albumit.Kappaleenlista("Do it Again");
        albumit.Kappaleenlista("Little Miss");

        albumit.TulostaDataa();
        albumit.MusiikinTulostus();
    }
}