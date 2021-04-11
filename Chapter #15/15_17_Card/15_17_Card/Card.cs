namespace _15_17_Card
{
    class Card
    {
        public string Face {get; private set;}
        public string Suit { get; private set; }

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Face} : {Suit}";
        }
    }
}
