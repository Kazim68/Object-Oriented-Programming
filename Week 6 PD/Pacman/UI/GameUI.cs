using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.UI
{
    internal class GameUI
    {
        // prints a char on screen given it's coordinates
        public static void printChar(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }

        // prints the score on console
        public static void printScore(int score)
        {
            Console.SetCursorPosition(90, 28);
            Console.Write("Score: "+score);
        }
    }
}
