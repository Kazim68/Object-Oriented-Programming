using Challenge1.BL;
using Challenge1.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.UI
{
    internal class SubjectUI
    {
        // creats a subject object and returns it
        public static Subject takeSubjectInput()
        {
            string code = MainMenu.TakeInput("Subject Code");
            string type = MainMenu.TakeInput("Subject Type");
            int hours = 0;
            while (hours > 3 || hours <= 0)
            {
                hours = int.Parse(MainMenu.TakeInput("Subject Credit Hour"));
            }
            int fees = int.Parse(MainMenu.TakeInput("Subject Fees"));
            Subject s = new Subject(code, type, hours, fees);
            return s;
        }

        // view registered subjects
        public static void viewSubjects(Student student)
        {
            if (student.degree != null)
            {
                Console.WriteLine("Code\t\tType");
                foreach (Subject subject in student.degree.subjects)
                {
                    Console.WriteLine("{0}\t\t{1}", subject.code, subject.type);
                }
            }
        }

        // registers subjects for a student
        public static void registerSubjects()
        {
            Console.WriteLine("Enter name of Student: ");
            string name = Console.ReadLine();
            string opt = "", code = "";
            List<Student> students = StudentsCrud.GetAllStudents();
            for (int i = 0; i < StudentsCrud.count(); i++) // finds the student
            {
                if (name == students[i].name) // found the student
                {
                    viewSubjects(students[i]);
                    while (opt != "2") // asking for subjects
                    {
                        opt = subjectRegisterMenu(); // subject menu returns the choice of user
                        if (opt == "1")
                        {
                            Console.WriteLine("Enter Code of Subject: ");
                            code = Console.ReadLine();
                            Subject s = null;
                            if ((s = findSubject(code, students[i].degree)) != null && !students[i].subjects.Contains(s)) // checks if the subject was found in the program
                            {
                                students[i].registerSubjects(s);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Subject Code!");
                            }
                        }
                    }
                    break;
                }
            }
        }

        // menu for adding a subject for a student while registering for them
        public static string subjectRegisterMenu()
        {
            Console.WriteLine("1.Add subject");
            Console.WriteLine("2.Done Registering");
            return Console.ReadLine();
        }

        // returns the subject object when found
        static Subject findSubject(string name, DegreeProgram degree)
        {
            foreach (Subject subject in degree.subjects)
            {
                if (name == subject.code)
                {
                    return subject;
                }
            }
            return null;
        }
    }
}
