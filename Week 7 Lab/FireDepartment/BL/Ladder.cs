using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDepartment.BL
{
    internal class Ladder
    {
        protected int length;
        protected string color;

        // parameterized constructor
        public Ladder(int length, string color)
        {
            this.length = length;
            this.color = color;
        }
    }
}
