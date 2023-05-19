using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.UI
{
    internal class GameObjectUI
    {
        // print the shape at desired location
        public static void printCharacter(int x, int y, char[,] shape)
        {
            foreach (char c in shape)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(c);
                y++;
            }
        }
    }
}
