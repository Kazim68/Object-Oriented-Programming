using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BL
{
    internal class Point
    {
        public int x;
        public int y;

        // default constructor
        public Point() { this.x = 0; this.y = 0; }

        // parameterized constructor
        public Point(int x, int y) 
        {
            this.x = x; 
            this.y = y; 
        }

        // get the value of x coordinate
        public int getX() { return this.x; }

        // get the value of y coordinate
        public int getY() { return this.y; }

        // set value of x-coordinate

        public void setX(int x) {  this.x = x; }

        // set the value of y-coordinate
        public void setY(int y) { this.y = y;}

        // set values of both coordinates
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
