using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.BL;

namespace Task4.UI
{
    internal class SquareUI
    {
        // take input
        public static Square takeInput()
        {
            int width = int.Parse(takeStringInput("Enter Side: "));
            return new Square(width);
        }

        // take input in string 
        public static string takeStringInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
