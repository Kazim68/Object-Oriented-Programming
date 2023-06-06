using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.BL
{
    internal class Shape
    {
        protected int length;

        // parameterized constructor
        public Shape(int length)
        {
            this.length = length;
        }

        // get area
        public virtual double getArea() { return 0; }
        
        // return info of shape
        public virtual string toString()
        {
            return "Shape[length= " + this.length + "]";
        }

        // returns the name of shape width area
        public virtual string printInfo()
        {
            return "";
        }
    }
}
