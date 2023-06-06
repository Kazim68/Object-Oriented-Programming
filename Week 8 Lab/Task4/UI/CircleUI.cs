using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.BL;

namespace Task4.UI
{
    internal class CircleUI
    {
        // take input
        public static Circle takeInput()
        {
            int width = int.Parse(takeStringInput("Enter Radius: "));
            return new Circle(width);
        }

        // take input in string 
        public static string takeStringInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
