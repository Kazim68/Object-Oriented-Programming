using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    internal class Cat : Mammal
    {
        // parameterized construcotor
        public Cat(string name) : base(name) { }

        // greets 
        public void greets()
        {
            Console.WriteLine("Meow");
        }

        // return animal info
        public override string toString()
        {
            return "Cat[" + base.toString() + "]";
        }
    }
}
