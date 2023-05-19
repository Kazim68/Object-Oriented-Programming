using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;

namespace Challenge1.DL
{
    internal class StudentsCrud
    {
        public static List<Student> students = new List<Student>();

        // add data
        public static void AddNewStudent(Student student)
        {
            students.Add(student);
        }

        // return length of the list
        public static int count()
        {
            return students.Count;
        }

        // returns students list
        public static List<Student> GetAllStudents() 
        {
            return students;
        }

        // checks if a student is available 
        public static Student studentPresent(string name, List<Student> students)
        {
            foreach (Student s in students)
            {
                if (name == s.name && s.degree != null)
                {
                    return s;
                }
            }
            return null;
        }

        // sort students list based on merit
        public static List<Student> sortStudents()
        {
            List<Student> sortedList = new List<Student>();
            foreach (Student s in StudentsCrud.GetAllStudents())
            {
                s.calculateMerit();
            }
            sortedList = StudentsCrud.GetAllStudents().OrderByDescending(o => o.merit).ToList();
            return sortedList;
        }

        // give admissions
        public static void giveAdmission(List<Student> students)
        {
            foreach (Student student in students)
            {
                foreach (DegreeProgram degree in student.preferences)
                {
                    if (degree.seats > 0 && student.degree == null)
                    {
                        student.degree = degree;
                        degree.seats--;
                        break;
                    }
                }
            }
        }

        // store data in file
        public static void writeData(string path, Student s)
        {
            StreamWriter file = new StreamWriter(path, true);
            string degree = "";
            for (int i = 0; i < s.preferences.Count -1; i++)
            {
                degree += s.preferences[i].name + ";";
            }
            degree += s.preferences[s.preferences.Count - 1].name;
            file.WriteLine(s.name + "," + s.age + "," + s.fscMarks + "," + s.ecatMarks + "," + degree);
            file.Flush();
            file.Close();
        }

        // load data from file
        public static bool loadData(string path)
        {
            string line;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while ((line = file.ReadLine()) != null) 
                {
                    string[] data = line.Split(',');
                    string[] pref = data[4].Split(';');
                    List<DegreeProgram> prefs = new List<DegreeProgram>();
                    for (int i = 0; i < pref.Length; i++) 
                    {
                        DegreeProgram d = DegreeProgramCrud.isDegreeExist(pref[i]);
                        if (d != null)
                        {
                            if (!prefs.Contains(d))
                            {
                                prefs.Add(d);
                            }
                        }
                    }
                    Student s = new Student(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), prefs);
                    StudentsCrud.AddNewStudent(s);
                }
                file.Close();
                return true;
            }
            return false;
        }
    }
}
