using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;

namespace Challenge1.DL
{
    internal class SubjectCrud
    {
        public static List<Subject> subjects = new List<Subject>();

        // add subject in list
        public static void addSubjectinList(Subject s)
        {
            subjects.Add(s);
        }

        // checks if a subject exists 
        public static Subject isSubjectExist(string type)
        {
            foreach (Subject s in subjects)
            {
                if (s.type == type)
                {
                    return s;
                }
            }
            return null;
        }

        // write data into file
        public static void storeDataInFile(string path, Subject s)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(s.code + "," + s.type + "," + s.creditHour + "," + s.fees);
            file.Flush();
            file.Close();
        }

        // read data from file
        public static bool readDataFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string line;
            if (File.Exists(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    Subject s = new Subject(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]));
                    addSubjectinList(s);
                }
                file.Close();
                return true;
            }
            file.Close();
            return false;
        }
    }
}
