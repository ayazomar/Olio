    class card
    {
        private string luku;
        private string maa;
        public card(string cardLuku, string cardMaa)
        {
            luku = cardLuku;
            maa = cardMaa;
        }
        public override string ToString()
        {
            return luku + " of " + maa;
        }
    }   