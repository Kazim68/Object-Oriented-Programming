using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_1.BL;

namespace Test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Pathan", 123, 3, 720, 1075, 117, "Peshawar", false, false);
            Console.WriteLine(s.merit());
            Console.WriteLine(s.isElegibleForScholarship(s.merit()));
            Console.ReadKey();
        }
    }
}
