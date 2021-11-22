using Exercise4_ClassLibrary;
using System;

namespace Exercise4_ClassLibrary
{
    public class Deck
    {
        public int CardsLeft;
        private Card[] cards;

        public void Shuffle()
        {

        }
        public Card DealCard()
        {
            Card card = new Card();
            return card;
        }
    }
}
