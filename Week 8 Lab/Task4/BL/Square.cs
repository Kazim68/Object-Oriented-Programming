using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.BL
{
    internal class Square : Shape
    {
        // parameterized constructor
        public Square(int length) : base(length) { }

        // return area
        public override double getArea()
        {
            return base.length * base.length;
        }

        // return info of shape
        public override string toString()
        {
            return "Square[" + base.toString() + "]";
        }

        // return type of shape
        public string type() { return "Square"; }

        // returns the name of shape width area
        public override string printInfo()
        {
            return "The Shape is " + this.type() + " and its area is " + this.getArea();
        }
    }
}
