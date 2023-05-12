using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge02.BL;

namespace Challenge02.DL
{
    internal class MuserList
    {
        public static List<Muser> users = new List<Muser>();
        public static List<Customer> customers = new List<Customer>();

        // add a new user
        public static void addUser(Muser user)
        {
            users.Add(user);
        }

        // add a new customer
        public static void addCustomer(Customer customer) { customers.Add(customer); }

        // sign in check
        public static Muser signInCheck(string name, string password)
        {
            foreach (Muser user in users)
            {
                if (user.name == name && user.password == password)
                {
                    return user;
                }
            }
            return null;
        }

        // loads data from file
        public static void loadData()
        {
            string path = "data.txt";
            if (File.Exists(path))
            {
                string[] data = new string[3];
                StreamReader file = new StreamReader(path);
                string line = "";
                while ((line = file.ReadLine()) != null)
                {
                    data = line.Split(',');
                    Muser user = new Muser(data[0], data[1], data[2]);
                    MuserList.addUser(user);
                    if (data[2] == "Customer")
                    {
                        Customer customer = new Customer(user);
                        addCustomer(customer);
                    }
                }
                file.Close();
            }
        }

        // write data in file
        public static void saveData(Muser user)
        {
            StreamWriter file = new StreamWriter("data.txt", true);
            file.WriteLine(user.name + "," + user.password + "," + user.role);
            file.Flush();
            file.Close();
        }
    }
}
