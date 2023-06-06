using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.BL;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat("Tom");
            Cat c2 = new Cat("Butch");

            Dog d1 = new Dog("Spike");
            Dog d2 = new Dog("Tide");

            c1.greets();
            d1.greets();
            d2.greets(d1);

            Console.WriteLine(c1.toString());
            Console.WriteLine(d2.toString());

            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
