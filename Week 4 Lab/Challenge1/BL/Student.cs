using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    internal class Student
    {
        public string name;
        public int age;
        public int fscMarks;
        public int ecatMarks;
        public string degreeProgram;
        public List<string> preferences;
        public DegreeProgram degree;
        public List<Subject> subjects;

        // default constructor
        public Student() { }

        // parameterized constructor
        public Student(string name, int age, int fscMarks, int ecatMarks, List<string> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.preferences = preferences;
            this.degree = null;
            this.subjects = null;
        }
    }
}
