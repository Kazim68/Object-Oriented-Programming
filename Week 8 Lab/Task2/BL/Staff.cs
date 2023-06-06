using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class Staff : Person
    {
        protected string school;
        protected double pay;

        // parameterized constructor
        public Staff(string name, string address, string school, double pay) : base(name, address)
        { 
            this.school = school;
            this.pay = pay;
        }

        // return school
        public string getSchool() { return this.school; }

        // set new school
        public void setSchool(string school) { this.school = school; }

        // return pay
        public double getPay() { return this.pay; }

        // set new pay
        public void setPay(double pay) { this.pay = pay; }

        // return info on staff
        public override string toString()
        {
            return "Staff[" + base.toString() + ", school= " + this.school + ", pay= " + this.pay + "]";
        }

    }
}
