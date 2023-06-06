using Pacman.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.UI
{
    internal class GridUI
    {
        // print the grid
        public static void print(Cell[,] maze , int rowSize,int colSize)
        {
            for (int x = 0; x < rowSize; x++)
            {
                for (int y = 0; y < colSize; y++)
                {
                    Console.Write(maze[x, y].value);
                }
                Console.WriteLine();
            }
        }
    }
}
