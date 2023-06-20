using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignInGUIAPP.BL;

namespace SignInGUIAPP.DL
{
    internal class MUserDL
    {
        protected static List<MUser> users = new List<MUser>();

        // add in list
        public static void addInList(MUser user) { users.Add(user); }

        // sign in
        public static MUser SignIn(MUser user)
        {
            foreach (MUser u in users)
            {
                if (u.getName() ==  user.getName() && u.getPassword() == user.getPassword())
                {
                    return u;
                }
            }
            return null;
        }

        // write data
        public static void writeData(MUser user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            
            file.WriteLine(user.getName() + "," + user.getPassword() + "," + user.getRole());
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
