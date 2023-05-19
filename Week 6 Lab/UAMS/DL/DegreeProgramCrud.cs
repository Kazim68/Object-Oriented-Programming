using Challenge1.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.DL
{
    internal class DegreeProgramCrud
    {
        public static List<DegreeProgram> degreePrograms = new List<DegreeProgram>();

        // add data
        public static void AddNewDegree(DegreeProgram degree)
        {
            degreePrograms.Add(degree);
        }

        // return length of the list
        public static int count()
        {
            return degreePrograms.Count;
        }

        // returns the list of degrees
        public static List<DegreeProgram> GetDegreePrograms()
        {
            return degreePrograms;
        }

        // checks if degree exist
        public static DegreeProgram isDegreeExist(string name)
        {
            foreach(DegreeProgram degree in degreePrograms) 
            {
                if (degree.name == name)
                {
                    return degree;
                }
            }
            return null;
        }

        // write data on file
        public static void storeDataInFile(string path, DegreeProgram d)
        {
            StreamWriter file = new StreamWriter(path, true);
            string subjects = "";
            for (int i = 0; i < d.subjects.Count - 1; i++)
            {
                subjects = subjects + d.subjects[i].type + ";";
            }
            subjects = subjects + d.subjects[d.subjects.Count-1].type;
            file.WriteLine(d.name + "," + d.duration + "," + d.seats + "," + subjects);
            file.Flush();
            file.Close();
        }

        // loads data from file
        public static bool loadDataFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string line;
            if (File.Exists(path))
            {
                while ((line = file.ReadLine()) != null) 
                {
                    string[] data = line.Split(',');
                    string[] subjects = data[3].Split(';');
                    DegreeProgram d = new DegreeProgram(data[0], int.Parse(data[1]), int.Parse(data[2]));
                    for (int i = 0; i < subjects.Length; i++) 
                    {
                        Subject s = SubjectCrud.isSubjectExist(subjects[i]);
                        if (s != null) { d.addSubject(s); }
                    }
                    AddNewDegree(d);
                }
                file.Close();
                return true;
            }
            file.Close();
            return false;
        }
    }
}
