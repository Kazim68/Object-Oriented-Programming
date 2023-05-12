using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge01.BL
{
    internal class MyPoint
    {
        public int x;
        public int y;

        // default constructor
        public MyPoint() { }

        // parameterized constructor
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // returns the value of x-coordinate
        public int getX()
        {
            return this.x;
        }

        // returns the y-coordinate
        public int getY()
        {
            return this.y;
        }

        // set a value of x-coordinate
        public void setX(int x)
        {
            this.x = x;
        }

        // set a value of y-coordinate
        public void setY(int y)
        {
            this.y = y;
        }

        // set or change the values of the whole xy-coordinate
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // returns the distance with a point passed as a chord
        public double distanceWithChord(int x, int y)
        {
            return Math.Sqrt((this.x - x) ^ 2 + (this.y - y) ^ 2);
        }

        // returns the distance with a point passed as an object
        public double distanceWithObject(MyPoint another)
        {
            return distanceWithChord(another.x, another.y);
        }

        // returns the distance from origin
        public double distanceFromZero()
        {
            return distanceWithChord(0, 0);
        }

    }
}
