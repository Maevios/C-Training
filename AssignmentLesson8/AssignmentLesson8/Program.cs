using System;

namespace AssignmentLesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            Console.WriteLine("Add your balance");
            double balance = Convert.ToDouble(Console.ReadLine());

            Program program = new Program();
            
            while (balance > 0)
            {
                Console.WriteLine("How much do you want to bet? 0 to quit game");
                double stake = Convert.ToDouble(Console.ReadLine());
                while (stake > balance)
                {
                    Console.WriteLine("How much do you want to bet? 0 to quit game");
                    stake = Convert.ToDouble(Console.ReadLine());
                }
                if (stake != 0)
                {
                    bool result = program.PlayBlackjack();

                    if (result == true)
                    {
                        Console.WriteLine("You won the round!");
                        balance += stake;
                        Console.WriteLine($"Your balance is {balance}");
                    }
                    else
                    {
                        Console.WriteLine("You lost the round");
                        balance -= stake;
                        Console.WriteLine($"Your balance is {balance}");
                    }
                } else 
                {
                    Console.WriteLine("User quit the game");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Insufficient funds");

        }
        public bool PlayBlackjack()
        {
            BlackJackHand player = new BlackJackHand();
            BlackJackHand dealer = new BlackJackHand();

            dealer.AddCard(returnCard());
            dealer.AddCard(returnCard());

            player.AddCard(returnCard());
            player.AddCard(returnCard());

            if (player.GetBlackjackValue() == 21 && dealer.GetBlackjackValue() != 21 || dealer.GetBlackjackValue() > 21)
            {
                return true;
            }
            if (player.GetBlackjackValue() > 21)
            {
                return false;
            }

            Console.WriteLine($"The one card of dealer is {dealer.cards[0].GetValueAsString()} of {dealer.cards[0].GetSuitAsString()}");

            Console.WriteLine($"You have {player.GetBlackjackValue()}");

            while (player.GetBlackjackValue() < 21)
            {
                Console.WriteLine("Do you want to hit another card? [y/n] ");
                var response = Console.ReadKey(false).Key;
                if (response == ConsoleKey.Y)
                {
                    player.AddCard(returnCard());
                    Console.WriteLine($"You have {player.GetBlackjackValue()}");
                    if (player.GetBlackjackValue()>21)
                    {
                        return false;
                    }
                    while (dealer.GetBlackjackValue() <= 16)
                    {
                        dealer.AddCard(returnCard());
                    }
                }
                if (response == ConsoleKey.N)
                {
                    while (dealer.GetBlackjackValue() <= 16 || dealer.GetBlackjackValue() < player.GetBlackjackValue())
                    {
                        dealer.AddCard(returnCard());
                        if (dealer.GetBlackjackValue() > 21)
                        {
                            return true;
                        }
                    }
                    break;
                }
            }

            Console.WriteLine($"You have: {player.GetBlackjackValue()}");
            player.cards.ForEach(i => Console.WriteLine("{0} of {1}", i.GetValueAsString(),i.GetSuitAsString()));

            Console.WriteLine($"The dealer has: {dealer.GetBlackjackValue()}");
            dealer.cards.ForEach(i => Console.WriteLine("{0} of {1}", i.GetValueAsString(), i.GetSuitAsString()));

            if (player.GetBlackjackValue() <= dealer.GetBlackjackValue())
            {
                return false;
            }else return true;
        }

        public Card returnCard()
        {
            Array values = Enum.GetValues(typeof(Value));
            Array suits = Enum.GetValues(typeof(Suit));

            Random random = new Random();
            Value randomValue = (Value)values.GetValue(random.Next(values.Length));
            Suit randomSuit = (Suit)values.GetValue(random.Next(suits.Length - 1));

            Card card = new Card(randomValue, randomSuit);

            return card;
        }
    }
}
