using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.BL
{
    internal class Circle : Shape
    {
        // parameterized constructor
        public Circle(int length) : base(length) { }

        // return area
        public override double getArea()
        {
            return base.length * base.length * Math.PI;
        }

        // return info of shape
        public override string toString()
        {
            return "Circle[" + base.toString() + "]";
        }

        // return type of shape
        public string type() { return "Circle"; }

        // returns the name of shape width area
        public override string printInfo()
        {
            return "The Shape is " + this.type() + " and its area is " + this.getArea();
        }
    }
}
