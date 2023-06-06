using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDepartment.BL
{
    internal class Person
    {
        protected string name;

        // parameterized constructor
        public Person(string name)
        {
            this.name = name;
        }

        // get name
        public string getName() { return this.name; }

        // set name
        public void setName(string name) { this.name = name;}

        // extinguish fire
        public bool extinguishFire()
        {
            return true;
        }

        // drive fire truck
        public bool drive()
        {
            return true;
        }
    }
}
