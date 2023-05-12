using Challenge01.BL;
using Challenge01.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge01.DL
{
    internal class Line
    {
        // makes a line
        public static MyLine makeLine()
        {
            int x = int.Parse(Menu.takeInput("x-coordinate of first coordinate"));
            int y = int.Parse(Menu.takeInput("y-coordinate of first coordinate"));
            int x2 = int.Parse(Menu.takeInput("x-coordinate of first coordinate"));
            int y2 = int.Parse(Menu.takeInput("y-coordinate of first coordinate"));

            MyPoint p1 = new MyPoint(x, y);
            MyPoint p2 = new MyPoint(x2, y2);

            MyLine line = new MyLine(p1, p2);
            return line;
        }
    }
}
