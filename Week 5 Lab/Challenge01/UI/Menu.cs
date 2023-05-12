using Challenge01.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge01.UI
{
    internal class Menu
    {

        // menu returns a string value indicating chosen choice
        public static string menu()
        {
            Console.WriteLine("1.Make a Line");
            Console.WriteLine("2.Update the begin point");
            Console.WriteLine("3.Update the end point");
            Console.WriteLine("4.Show the begin point");
            Console.WriteLine("5.Show the end point");
            Console.WriteLine("6.Get the Length of the Line");
            Console.WriteLine("7.Get the gradient of the Line");
            Console.WriteLine("8.Find the distance of begin point from zero coordinates");
            Console.WriteLine("9.Find the distance of end point from zero coordinate");
            Console.WriteLine("0.Exit");
            return takeInput("your choice");
        }

        // menu for updating menu
        public static string updatePointMenu()
        {
            Console.WriteLine("1.Change x-coordinate");
            Console.WriteLine("2.Change y-coordinate");
            Console.WriteLine("3.Change both values of coordinate");
            Console.WriteLine("0.Back");
            return takeInput("your choice");
        }

        // prints the prompt for an input and return the input in string
        public static string takeInput(string message)
        {
            Console.Write("Enter " + message + ": ");
            return Console.ReadLine();
        }

        // print a double value
        public static void printDoubleValue(double value, string message)
        {
            Console.WriteLine("{0} is: {1}", message, value);
        }

        // show coordinates on screen
        public static void printCoordinate(MyPoint point)
        {
            Console.WriteLine("{0}, {1}", point.getX(), point.getY());
        }

        // screen transition
        public static void transition()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
