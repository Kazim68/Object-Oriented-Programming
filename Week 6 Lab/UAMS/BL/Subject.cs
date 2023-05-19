using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    internal class Subject
    {
        public string code;
        public string type;
        public int creditHour;
        public int fees;

        // default constructor
        public Subject() { }

        // parameterized constructor
        public Subject(string code, string type, int creditHour, int fees)
        {
            this.code = code;
            this.type = type;
            this.creditHour = creditHour;
            this.fees = fees;
        }

    }
}
