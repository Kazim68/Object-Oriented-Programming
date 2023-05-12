using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class Player
    {
        public int x;
        public int y;
        public int health;

        // default constructor
        public Player()
        {
            this.x = 0;
            this.y = 0;
            this.health = 100;
        }

        // parametrized constructor
        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.health = 100;
        }

        // parameterized constructor with health
        public Player(int x, int y, int health)
        {
            this.x = x;
            this.y = y;
            this.health = health;
        }

        // print player
        public void printPlayer(char[,] body)
        {
            int bx = x, by = y;
            for (int row = 0; row < body.GetLength(0); row++)
            {
                bx = x;
                for (int col = 0; col < body.GetLength(1); col++)
                {
                    Console.SetCursorPosition(bx, by);
                    Console.Write(body[row, col]);
                    bx++;
                }
                by++;
            }
        }
    }
}
