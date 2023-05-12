using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Admin
    {
        public string name;
        public string password;

        // parameterized constructor
        public Admin(string name, string password)
        {
            this.name = name;
            this.password = password;   
        }
    }
}
