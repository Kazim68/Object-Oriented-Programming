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
    }
}
