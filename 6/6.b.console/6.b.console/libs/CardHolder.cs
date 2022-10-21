using System;
using System.Collections.Generic;
using System.Text;

namespace _6.b.console.libs
{
    class Card
    {
        protected string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        protected string[] suitsSimbols = { "♥", "♦", "♣", "♠" };
        protected string[] ranls = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private int suit;
        private int rank;
        public Card()
        {
            this.suit = 0;
            this.rank = 0;
        }
        /// <summary>
        /// card gen
        /// </summary>
        /// <param name="suit">0-3</param>
        /// <param name="rank">0-12</param>
        public Card(int suit, int rank)
        {
            if ((suit >= 0 && suit <= 3) && (rank >= 0 && rank <= 12))
            {
                this.suit = suit;
                this.rank = rank;
            }
            else
            {
                throw new InvalidOperationException("incorrect parametors");
            }
        }
        new public string ToString()
        {
            return ranls[rank] + suits[suit];
        }
        public string ToStringASKII()
        {
            return ranls[rank] + suitsSimbols[suit];
        }
    }
    public class Deck
    {
        Card[] card = new Card[52];
        public Deck()
        {
            int cardAmmount = 0;
            for (int i = 0; i <= 3; i++)
            {
                for (int n = 0; n <= 12; n++)
                {
                    card[cardAmmount] = new Card(i, n);
                    cardAmmount++;
                }
            }
        }
        public void SetCard(int index, int suit, int rank)
        {
            if ((index >= 0 && index <= 51) && (suit >= 0 && suit <= 3) && (rank >= 0 && rank <= 12))
            {
                this.card[index] = new Card(suit, rank);
            }
            else
            {
                throw new InvalidOperationException("incorrect parametors");
            }
        }
        public string GetCard(int index)
        {
            return this.card[index].ToString();
        }
        public string GetCardASKII(int index)
        {
            return this.card[index].ToStringASKII();
        }
        public void Shuffle()
        {
            for (int i = 0; i < 52; i++)
            {
                Card temp = card[i];
                Random rnd = new Random();
                int k = rnd.Next(i, 51);
                card[i] = card[k];
                card[k] = temp;
            }
        }
    }
}
