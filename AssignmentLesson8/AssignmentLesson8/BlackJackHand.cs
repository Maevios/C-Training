using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentLesson8
{
    class BlackJackHand : Hand
    {
        public int GetBlackjackValue()
        {
            int value = 0;
            foreach (var card in cards)
            {
                value = value + (int)card.value;
            }
            return value;
        }
    }
}
