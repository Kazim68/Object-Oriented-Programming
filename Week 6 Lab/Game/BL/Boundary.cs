using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.BL;

namespace Game.BL
{
    internal class Boundary
    {
        public Point topLeft;
        public Point topRight;
        public Point bottomLeft;
        public Point bottomRight;

        // default constructor
        public Boundary() 
        {
            this.topLeft = new Point(0, 0);
            this.topRight= new Point(0, 90);
            this.bottomLeft = new Point(90, 0);
            this.bottomRight = new Point(90, 90);
        }

        // parameterized constructor
        public Boundary(Point topLeft, Point topRight) 
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomLeft = topLeft;
            this.bottomRight = topRight;
        }


    }
}
