using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    internal class Animal
    {
        protected string name;

        // parameterized cosntructor
        public Animal(string name) { this.name = name; }

        // return animal info
        public virtual string toString()
        {
            return "Animal[name= " + this.name + "]";
        }
    }
}
