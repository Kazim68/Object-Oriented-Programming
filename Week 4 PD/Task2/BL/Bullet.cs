using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class Bullet
    {
        public int x;
        public int y;
        public string direction;
        public bool isActive;
        public string user;
        public string shape;

        // parameterized constructor
        public Bullet(int x, int y, string direction, bool isActive, string user, string shape)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
            this.isActive = isActive;
            this.user = user;
            this.shape = shape;
        }

        // print bullet
        public void printBullet()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(this.shape);
        }

        // erases bullet
        public void eraseBullet()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(" ");
        }

        // move bullet
        public void moveBullet()
        {
            if (this.isActive)
            {
                eraseBullet();
                if (this.direction == "right")
                {
                    this.x++;
                }
                else if (this.direction == "left")
                {
                    this.x--;
                }
                printBullet();
            }
        }
    }
}
