using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            Cylinder c2 = new Cylinder(3);
            Cylinder c3 = new Cylinder(3, 5, "White");

            c1.setRadius(1);
            c1.setColor("Blue");
            c1.setHeight(1);

            c2.setColor("Green");
            c2.setHeight(10);

            Console.WriteLine(c1.toString());
            Console.WriteLine("Volume of cylinder 2 is: "+c2.getVolume());
            Console.WriteLine(c3.toString());

            Console.ReadKey();
        }
    }
}
