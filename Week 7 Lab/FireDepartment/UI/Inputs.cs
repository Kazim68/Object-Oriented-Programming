using FireDepartment.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDepartment.UI
{
    internal class Inputs
    {
        // ladder input
        public static Ladder ladder()
        {
            int length = int.Parse(takeInput("Enter Length of ladder: "));
            string color = takeInput("Enter color of ladder: ");
            return new Ladder(length, color);
        }

        // return the string from user
        public static  string takeInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
