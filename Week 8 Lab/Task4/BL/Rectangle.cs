using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.BL
{
    internal class Rectangle : Shape
    {
        protected int width;

        // parameterized constructor
        public Rectangle(int length, int width) : base(length)
        { this.width = width; }

        // return area
        public override double getArea()
        {
            return base.length * this.width;
        }

        // return info of shape
        public override string toString()
        {
            return "Rectangle[" + base.toString() + ", width= " + this.width + "]";
        }

        // return type of shape
        public string type() { return "Rectangle"; }

        // returns the name of shape width area
        public override string printInfo()
        {
            return "The Shape is " + this.type() +" and its area is " + this.getArea();
        }
    }
}
