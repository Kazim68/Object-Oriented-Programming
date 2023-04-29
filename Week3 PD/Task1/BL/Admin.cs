using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Admin
    {
        public string name;
        public string password;
        public string role;

        // default constructor
        public Admin()
        {
            this.name = "";
            this.password = "";
            this.role = "";
        }

        // parameterized name and password constructor
        public Admin(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        // parameterized name, password and role constructor
        public Admin(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }

        // sign in check
        public bool signInCheck(List<Admin> users, string name, string password)
        {
            foreach (Admin user in users)
            {
                if (user.name == name && user.password == password)
                {
                    Console.WriteLine("Welcome " + user.role);
                   return true;
                }
            }
            return false;
            
        }
    }
}
