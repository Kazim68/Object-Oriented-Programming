using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.BL;

namespace Task4.DL
{
    internal class ShapeDL
    {
        protected static List<Shape> shapes = new List<Shape>();
        
        // add in list
        public static void addIntoList(Shape s)
        { shapes.Add(s); }

        // get list
        public static List<Shape> getShapes() { return shapes;}

    }
}
