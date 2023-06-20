using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInGUIAPP.BL
{
    internal class MUser
    {
        protected string name;
        protected string password;
        protected string role;

        // constructor
        public MUser(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }

        public MUser(string name, string password)
        {
            this.name = name;
            this.password = password;
            this.role = "NA";
        }

        // getters
        public string getName() { return this.name; }
        public string getPassword() { return this.password; }
        public string getRole() { return this.role; }

        // is admin
        public bool isAdmin()
        {
            if (this.role.ToLower() == "admin") { return true; }
            return false;
        }


    }
}
