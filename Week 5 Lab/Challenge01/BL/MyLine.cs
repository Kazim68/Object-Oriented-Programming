using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge01.BL
{
    internal class MyLine
    {
        public MyPoint begin;
        public MyPoint end;

        // parameterized constructor
        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }

        // returns the starting point
        public MyPoint getBegin()
        {
            return this.begin;
        }

        // set a value for begin point -changes it
        public void setBegin(MyPoint begin)
        {
            this.begin = begin;
        }

        // returns the ending point
        public MyPoint getEnd()
        {
            return this.end;
        }

        // set a value of end point -changes it
        public void setEnd(MyPoint end)
        {
            this.end = end;
        }

        // returns a distance of line formed between two points
        public double getLength()
        {
            return Math.Sqrt(Math.Pow((begin.x- end.x), 2) + Math.Pow((begin.y-end.y), 2));
        }

        // returns the gradient of line 
        public double getGradient()
        {
            return (begin.y - end.y) / Math.Sqrt(Math.Pow((begin.x - end.x), 2));
        }
    }
}
