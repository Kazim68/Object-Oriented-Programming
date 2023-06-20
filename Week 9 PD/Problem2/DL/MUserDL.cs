using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Problem2.BL;
using System.Windows.Forms;

namespace Problem2.DL
{
    internal class MUserDL
    {
        protected static List<MUser> users = new List<MUser>();

        // get list
        public static List<MUser> getUsers() { return users; }

        // add in list
        public static void addInList(MUser user) { users.Add(user); }

        // remove from list
        public static void removeFromList(MUser user) { users.Remove(user); }

        // edit user from list
        public static void editUser(MUser prev, MUser updated)
        {
            foreach (MUser user in users)
            {
                if (user.Name == prev.Name && user.Password == prev.Password)
                {
                    user.Name = updated.Name;
                    user.Password = updated.Password;
                    user.Role = updated.Role;
                    break;
                }
            }
        }

        // search in list
        public static bool searchInList(string name)
        {
            foreach (MUser user in users)
            {
                if (user.Name == name) { return true; }
            }
            return false;
        }

        // sign in
        public static MUser SignIn(MUser user)
        {
            foreach (MUser u in users)
            {
                if (u.Name == user.Name && u.Password == user.Password)
                {
                    return u;
                }
            }
            return null;
        }

        // write data
        public static void writeData(string path)
        {
            StreamWriter file = new StreamWriter(path);

            foreach (MUser user in users)
            {

                file.WriteLine(user.Name + "," + user.Password + "," + user.Role);
            }
            file.Flush();
            file.Close();
        }

        // read data from file
        public static bool ReadData(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    addInList(new MUser(data[0], data[1], data[2]));
                }
                file.Close();
                return true;
            }
            return false;
        }
    }
}
