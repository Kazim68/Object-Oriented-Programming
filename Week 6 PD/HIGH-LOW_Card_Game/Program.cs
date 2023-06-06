using HIGH_LOW_Card_Game.BL;
using HIGH_LOW_Card_Game.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIGH_LOW_Card_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            Card current = deck.dealCard();
            Card next = null;

            string option = "";
            float totalScore = 0;
            int score = 0, count = 0;
            char play;

            while (option != "3")
            {
                option = Game.Menu();
                if (option == "1")
                {
                    // game play
                    while (deck.cardsLeft() > 0)
                    {
                        Console.WriteLine(current.toString());
                        play = Game.playerChoice();
                        next = deck.dealCard();

                        if (play == 'H')
                        {
                            if (next.getValue() >= current.getValue()) { score++; }
                            else { break; }
                        }
                        else if (play == 'L')
                        {
                            if (next.getValue() < current.getValue()) { score++; }
                            else { break; }
                        }

                        current = next;
                    }
                    count++;
                    totalScore += score;
                }
                else if (option == "2")
                {
                    Console.WriteLine("Average score: " + totalScore / count);
                }
                Game.transtition();
            }
            Console.ReadKey();
        }
    }
}
