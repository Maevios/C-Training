using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentLesson8
{
    class Card
    {
        public Value value { get; set; }
        public Suit suit{ get; set; }

        public Card(Value value, Suit suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public string GetSuitAsString()
        {
           return this.suit.ToString();
        }

        public string GetValueAsString()
        {
            return this.value.ToString();
        }

        public override string ToString()
        {
            return $"{value} of {suit}";
        }

       
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Spades,
        Hearts
    }

    public enum Value
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
}
