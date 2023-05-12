using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    internal class DegreeProgram
    {
        public string name;
        public int duration;
        public int seats;
        public List<Subject> subjects;

        // parameterized constructor
        public DegreeProgram(string name, int duration, int seats, List<Subject> subjects)
        {
            this.name = name;
            this.duration = duration;
            this.seats = seats;
            this.subjects = subjects;
        }

        // parameterized constructor without subjects list
        public DegreeProgram(string name, int duration, int seats)
        {
            this.name = name;
            this.duration = duration;
            this.seats = seats;
            this.subjects = new List<Subject>();
        }

        // calculate credit hours
        public int calculateCreditHours()
        {
            if (subjects == null || subjects.Count == 0)
            {
                return 0;
            }
            int hours = 0;
            foreach (Subject subject in subjects)
            {
                hours += subject.creditHour;
            }
            return hours;
        }

        // add a subject takes a subject object and returns bool 
        public bool addSubject(Subject subject)
        {
            int hours = calculateCreditHours();
            if (hours + subject.creditHour <= 20)
            {
                this.subjects.Add(subject);
                return true;
            }
            return false;
        }

        // checks if a subject exists in the degree program
        public bool isSubjectExist(Subject subject)
        {
            foreach (Subject s in subjects)
            {
                if (s.code == subject.code)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
