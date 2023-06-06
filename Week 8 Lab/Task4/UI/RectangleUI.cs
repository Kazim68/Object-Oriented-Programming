using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.BL;

namespace Task4.UI
{
    internal class RectangleUI
    {
        // take input
        public static Rectangle takeInput()
        {
            int width = int.Parse(takeStringInput("Enter Width: "));
            int height = int.Parse(takeStringInput("Enter Height: "));
            return new Rectangle(height, width);
        }

        // take input in string 
        public static string takeStringInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
