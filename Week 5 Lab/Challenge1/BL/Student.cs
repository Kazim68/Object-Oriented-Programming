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
        public float merit;
        public string degreeProgram;
        public List<DegreeProgram> preferences;
        public DegreeProgram degree;
        public List<Subject> subjects;

        // default constructor
        public Student() { }

        // parameterized constructor
        public Student(string name, int age, int fscMarks, int ecatMarks, List<DegreeProgram> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.preferences = preferences;
            this.degree = null;
            this.subjects = new List<Subject>();
        }

        // calculates merit
        public void calculateMerit()
        {
            this.merit = (((fscMarks/1100) * 0.45F) + ((ecatMarks/400)*0.55F)) * 100;
        }

        // register subject for a student
        public bool registerSubjects(Subject subject)
        {
            int hours = getCreditHours();
            if (this.degree != null && this.degree.isSubjectExist(subject) && hours + subject.creditHour <= 9)
            {
                subjects.Add(subject);
                return true;
            }
            return false;
        }

        // returns total number of credit hours a student is taking
        public int getCreditHours()
        {
            int hours = 0;
            foreach (Subject subject in subjects)
            {
                hours += subject.creditHour;
            }
            return hours;
        }

        // calculates fee for subjects 
        public int calculateFee()
        {
            int fee = 0;
            if (degree != null)
            {
                foreach (Subject subject in subjects)
                {
                    fee += subject.fees;
                }
            }
            return fee;
        }
    }
}
