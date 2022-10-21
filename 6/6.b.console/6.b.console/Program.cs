using System;
using _6.b.console.libs;

namespace _6.b.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Card game!");
            Deck deck = new Deck();
            for(int i = 0; i < 52; i++)
            {
                Console.Write(" " + deck.GetCard(i));
                if ((i+1) % 4 == 0) { Console.WriteLine(); }
            }

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            for (int i = 0; i < 52; i++)
            {
                Console.Write(" " + deck.GetCardASKII(i));
                if ((i + 1) % 4 == 0) { Console.WriteLine(); }
            }

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            deck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Console.Write(" " + deck.GetCardASKII(i));
                if ((i + 1) % 4 == 0) { Console.WriteLine(); }
            }

        }
    }
}
