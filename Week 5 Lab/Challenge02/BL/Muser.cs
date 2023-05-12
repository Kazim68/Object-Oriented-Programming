using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Challenge02.BL
{
    internal class Muser
    {
        public string name;
        public string password;
        public string role;

        // default constructor
        public Muser() { }

        // parameterized constructor
        public Muser(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
    }
}
