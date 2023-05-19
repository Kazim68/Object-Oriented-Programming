using Challenge1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.UI
{
    internal class MainMenu
    {

        // main menu returns a string indicating chosen option
        public static string Menu()
        {
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Add Degree Program");
            Console.WriteLine("3.Generate Merit List");
            Console.WriteLine("4.View Registered Students");
            Console.WriteLine("5.View Students of a specific program");
            Console.WriteLine("6.Register Subjects for a specific Student");
            Console.WriteLine("7.Calculate fees for all registered students");
            Console.WriteLine("8.Exit");
            return MainMenu.TakeChoice();
        }

        // take an option in string and return it
        public static string TakeChoice()
        {
            return TakeInput("your Choice");
        }

        // take data and return it in string format
        public static string TakeInput(string message)
        {
            Console.Write("Enter {0}: ", message);
            return Console.ReadLine();
        }

        // transitions between new screens
        public static void transition()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
