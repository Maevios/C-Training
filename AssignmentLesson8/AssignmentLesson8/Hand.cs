using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentLesson8
{
    class Hand
    {
        public List<Card> cards = new List<Card>();

        public int numberOfCards;


        public int NumberOfCards
        {
            get { return numberOfCards; }
            set { numberOfCards = cards.Count; }
        }

        public Hand()
        {

        }
        public void AddCard(Card card)
        {
            this.cards.Add(card);
        }

        public void RemoveCard(Card card)
        {
            this.cards.Remove(card);
        }

        public void RemoveCard(int position)
        {
            this.cards.RemoveAt(position);
        }

        public void SortBySuit()
        {
            this.cards.Sort();
        }

        public void SortByNumber()
        {

        }
    }
}
