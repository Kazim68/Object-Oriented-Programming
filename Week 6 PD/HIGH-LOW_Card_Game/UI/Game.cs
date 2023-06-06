using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIGH_LOW_Card_Game.UI
{
    internal class Game
    {
        // menu returns the option chosen
        public static string Menu()
        {
            Console.WriteLine("1.Play");
            Console.WriteLine("2.See Average");
            Console.WriteLine("3.Exit");
            return takeInput("Enter your choice: ");
        }

        // returns the user input
        public static string takeInput(string message)
        {
            Console.WriteLine(message);
            return  Console.ReadLine();
        }

        // returns a char of player chosen high-low option
        public static char playerChoice()
        {
            Console.WriteLine("Is next High or Low? (H/L)");
            return char.Parse(Console.ReadLine());
        }

        // screen transition
        public static void transtition()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
