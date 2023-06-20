using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BL
{
    public class MUser
    {
        private string name;
        private string password;
        private string role;

        // getters
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        // constructor
        public MUser(string name, string password, string role)
        {
            this.Name = name;
            this.Password = password;
            this.Role = role;
        }

        public MUser(string name, string password)
        {
            this.Name = name;
            this.Password = password;
            this.Role = "NA";
        }

        

        // is admin
        public bool isAdmin()
        {
            if (this.Role.ToLower() == "admin") { return true; }
            return false;
        }
    }
}
