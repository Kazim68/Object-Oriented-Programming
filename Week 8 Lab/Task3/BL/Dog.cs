using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    internal class Dog : Mammal
    {
        // parameterized construcotor
        public Dog(string name) : base(name) { }

        // greets 
        public void greets()
        {
            Console.WriteLine("Woof");
        }

        // greets another dog
        public void greets(Dog d)
        {
            Console.WriteLine("Woooooof");
        }

        // return animal info
        public override string toString()
        {
            return "Dog[" + base.toString() + "]";
        }
    }
}
