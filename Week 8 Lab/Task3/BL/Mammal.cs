using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    internal class Mammal : Animal
    {
        // parameterized constructor
        public Mammal(string name) : base(name){ }

        // return animal info
        public virtual string toString()
        {
            return "Mammal[" + base.toString() + "]";
        }
    }
}
