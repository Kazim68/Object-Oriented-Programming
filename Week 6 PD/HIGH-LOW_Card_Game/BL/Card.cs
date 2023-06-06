using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIGH_LOW_Card_Game.BL
{
    internal class Card
    {
        private int value;
        private int suit;

        // parameterized constructor
        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }

        // get the value instance of class
        public int getValue() { return this.value; }

        // get the suit instance of class
        public int getSuit() { return this.suit; }

        // make the suit in human readable form
        public string getSuitAsString()
        {
            if (this.suit == 1) { return "Spades"; }
            else if (this.suit == 2) { return "Hearts"; }
            else if (this.suit == 3) { return "Diamonds"; }
            else if (this.suit == 4) { return "Club"; }
            return null;
        }

        // make the value in human readable form
        public string getValueAsString()
        {
            if (this.value == 1) { return "Ace"; }
            else if (this.value == 11) { return "Jack"; }
            else if (this.value == 12) { return "Queen"; }
            else if (this.value == 13) { return "King"; }
            return this.value.ToString();
        }

        // make both value and suit in human readable form
        public string toString()
        {
            return this.getValueAsString() + " of " + this.getSuitAsString();
        }
    }
}
