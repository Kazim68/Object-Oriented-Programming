using Pacman.GL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.UI
{
    internal class GridUI
    {
        // print maze
        public static void printMaze(GameGrid grid)
        {
            for (int y = 0; y < grid.Height; y++) // 24
            {
                for (int x = 0; x < grid.Width ; x++) // 71
                {
                    Console.SetCursorPosition(x, y);
                    GameCell cell = grid.getCell(x, y);
                    Console.Write(cell.Object.Character);
                }
                Console.Write("\n");
            }
        }

        // print character
        public static void printCharacter(int x, int y, char character)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(character);
        }
    }
}
