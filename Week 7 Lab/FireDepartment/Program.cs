using FireDepartment.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDepartment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HosePipe hosePipe = new HosePipe("Soft Plastic", "Cylendrical", 10, 5);
            FireFighter fireFighter = new FireFighter("John");
            FireChief fireChief = new FireChief("Kim");
            FireTruck fireTruck = new FireTruck(hosePipe, fireFighter, fireChief);
            Console.ReadLine();
        }
    }
}
