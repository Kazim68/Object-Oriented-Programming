using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class Enemy
    {
        public int x;
        public int y;
        public string direction;

        // default constructor
        public Enemy()
        {
            this.x = 0;
            this.y = 0;
            this.direction = null;
        }

        // parametrized constructor
        public Enemy(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.direction = "right";
        }

        // parameterized constructor with direction
        public Enemy(int x, int y, string direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
        }

        // print  enemy
        public void printEnemy(char[,] body)
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
