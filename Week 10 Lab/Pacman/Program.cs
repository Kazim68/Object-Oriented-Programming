using Pacman.GL;
using Pacman.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;

namespace Pacman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameGrid grid = new GameGrid("Maze.txt", 24, 71);

            GameCell start = new GameCell(12, 22, grid);
            PacmanPlayer pacman = new PacmanPlayer('p', start, GameObjectType.PLAYER);
            GridUI.printMaze(grid);
            pacman.printPacman();

            while (true)
            {
                Thread.Sleep(90);

                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    pacman.move(GameDirection.Up);
                }
                else if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    pacman.move(GameDirection.Down);
                }
                else if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    pacman.move(GameDirection.Right);
                }
                else if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    pacman.move(GameDirection.Left);
                }
            }
        }
    }
}
