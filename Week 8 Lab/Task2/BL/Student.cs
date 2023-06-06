using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class Student : Person
    {
        protected string program;
        protected int year;
        protected double fee;

        // parameterized constructor
        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        // return program
        public string getProgram() { return this.program; }

        // set new program
        public void setProgram(string program) { this.program = program; }

        // return year
        public int getYear() { return this.year; }
        
        // set new year
        public void setYear(int year) { this.year = year;}

        // return fee
        public double getFee() { return this.fee;}

        // set new fee
        public void setFee(double fee) { this.fee = fee; }

        // return string giving info of student
        public override string toString()
        {
            return "Student[" + base.toString() + ", program=" + this.program + ", year= " + this.year + ", fee= " + this.fee + "]";
        }
    }
}
