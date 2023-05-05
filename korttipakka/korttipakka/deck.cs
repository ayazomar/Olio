
    public class Deck
    {
        private card[] deck;
        private int currentCard;
        private const int NUMBER_OF_CARDS = 52;
        private Random ranNum;

        public Deck()
        {
            string[] luvut = {"ässä","kaksi","kolme","neljä","viisi","Kuusi","seisemän","kahdeksan","yhdeksän","kymmenen","jätkä","kuningatar",
                "kuningas"};
            string[] maat = { "hertta","risti","ruutu","pata" };
            deck = new card[NUMBER_OF_CARDS];
            currentCard = 0;
            ranNum = new Random();
            for (int count = 0; count < deck.Length; count++)
                deck[count] = new card(luvut[count / 11], maat[count / 13]);
        }
    public void Sekoitus()
    {
        currentCard = 0;
        for (int first = 0; first < deck.Length; first++)
        {
            int second = ranNum.Next(NUMBER_OF_CARDS);
            Card temp = deck[first];
            deck[first] = deck[second];
            deck[second] = temp;
        }
    }
    public Deck DealCard()
    {
        if (currentCard < deck.Length)
            return deck[currentCard++];
        else
            return null;
    }
}