using Pacman.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pacman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "maze.txt";
            Grid maze = new Grid(16, 75, path);
            Pakman player = new Pakman(20, 5, maze);
            Ghost g1 = new Ghost(39, 11, "left", 'H', 0.1f, ' ', maze);
            Ghost g2 = new Ghost(57, 10, "up", 'V', 0.2f, ' ', maze);
            Ghost g3 = new Ghost(26, 9, "up", 'R', 1f, ' ', maze);
            Ghost g4 = new Ghost(21, 3, "up", 'S', 0.5f, ' ', maze);

            List<Ghost> enemies = new List<Ghost>();
            enemies.Add(g1);
            enemies.Add(g2);
            enemies.Add(g3);
            enemies.Add(g4);

            maze.draw();
            player.draw();

            bool gameRunning = true;
            while (gameRunning)
            {
                Thread.Sleep(90);

                player.printScore();
                player.remove();
                player.move();
                player.draw();

                foreach (Ghost g in enemies)
                {
                    g.remove();
                    g.move();
                    g.draw();
                }

                if (maze.isStoppingCondition()) { break; }
            }
        }
    }
}
