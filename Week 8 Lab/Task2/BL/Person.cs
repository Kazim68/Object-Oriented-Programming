using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class Person
    {
        protected string name;
        protected string address;

        // parameterized constructor
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        // return name
        public string getName() { return this.name; }

        // return address
        public string getAddress() { return this.address; }

        // set new address
        public void setAddress(string address) { this.address = address; }

        // return a string giving info of person
        public virtual string toString()
        {
            return "Person[name= " + this.name + ", address= " + this.address + "]"; 
        }
    }
}
