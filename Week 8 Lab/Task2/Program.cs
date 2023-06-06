using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("ark", "lahore", "cs", 2022, 55000);
            Student s2 = new Student("gmd", "lahore", "cs", 2030, 60000);

            Staff staff1 = new Staff("john", "usa", "crescent", 100000);
            Staff staff2 = new Staff("kim", "karachi", "none", 0);

            staff2.setSchool("lgs");
            staff2.setPay(100000);

            Console.WriteLine(s1.toString());
            Console.WriteLine(s2.toString());
            Console.WriteLine(staff1.toString());
            Console.WriteLine(staff2.toString());

            Console.ReadKey();


        }
    }
}
