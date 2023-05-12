using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using Challenge01.BL;
using Challenge01.UI;
using Challenge01.DL;

namespace Challenge01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            MyLine line = null;
            do
            {
                option = Menu.menu();
                if (option == "1")
                {
                    line = Line.makeLine();
                }
                else if (option == "2")
                {
                    updateBegin(line);
                }
                else if (option == "3")
                {
                    updateEnd(line);
                }
                else if (option == "4")
                {
                    Menu.printCoordinate(line.getBegin());  // show begin
                }
                else if (option == "5")
                {
                    Menu.printCoordinate(line.getEnd());  // show end
                }
                else if (option == "6")
                {
                    Menu.printDoubleValue(line.getLength(), "Length of line");
                }
                else if (option == "7")
                {
                    Menu.printDoubleValue(line.getGradient(), "Gradient of line");
                }
                else if (option == "8")
                {
                    Menu.printDoubleValue(line.begin.distanceFromZero(), "Distance of begin point from origin");
                }
                else if (option == "9")
                {
                    Menu.printDoubleValue(line.end.distanceFromZero(), "Distance of end point form origin");
                }
                Menu.transition();
            }
            while (option != "0");
        }

        // update the begin coordinate
        static void updateBegin(MyLine line)
        {
            if (line == null) { return; }
            string option = Menu.updatePointMenu();
            do
            {
                if (option == "1")
                {
                    line.begin.setX(int.Parse(Menu.takeInput("new value of x-coordinate of begin point")));
                }
                else if (option == "2")
                {
                    line.begin.setY(int.Parse(Menu.takeInput("new value of y-coordinate of begin point")));
                }
                else if (option == "3")
                {
                    MyPoint begin = new MyPoint(int.Parse(Menu.takeInput("new value of x-coordinate of begin point")), int.Parse(Menu.takeInput("new value of y-coordinate of begin point")));
                    line.setBegin(begin);
                }
                Menu.transition();
            }
            while (option != "0");
        }

        // update the end coordinate
        static void updateEnd(MyLine line)
        {
            if (line == null) { return; }
            string option = Menu.updatePointMenu();
            do
            {
                if (option == "1")
                {
                    line.end.setX(int.Parse(Menu.takeInput("new value of x-coordinate of begin point")));
                }
                else if (option == "2")
                {
                    line.end.setY(int.Parse(Menu.takeInput("new value of y-coordinate of begin point")));
                }
                else if (option == "3")
                {
                    MyPoint begin = new MyPoint(int.Parse(Menu.takeInput("new value of x-coordinate of begin point")), int.Parse(Menu.takeInput("new value of y-coordinate of begin point")));
                    line.setEnd(begin);
                }
                Menu.transition();
            }
            while (option != "0");
        }
    }
}
