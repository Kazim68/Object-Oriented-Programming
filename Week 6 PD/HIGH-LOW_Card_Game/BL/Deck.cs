using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIGH_LOW_Card_Game.BL
{
    internal class Deck
    {
        private List<Card> deck;

        // parameter which creates a deck of 52 cards
        public Deck()
        {
            this.deck = new List<Card>();
            this.fillDeck();
        }

        // add the 52 cards in the deck
        public void fillDeck()
        {
            this.deck.Clear();
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    this.deck.Add(new Card(j, i));
                }
            }
        }

        // shuffle the deck 
        public void Shuffle()
        {
            this.fillDeck();
            Random rand = new Random();
            this.deck = this.deck.OrderBy(o => rand.Next()).ToList();
        }

        // deal one card from deck and returns it
        public Card dealCard()
        {
            Card card = this.deck[0];
            this.deck.RemoveAt(0);
            return card;
        }

        // returns the number of cards left in deck
        public int cardsLeft()
        {
            return this.deck.Count;
        }
    }
}
