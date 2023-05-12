using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;
using Challenge1.DL;
using Challenge1.UI;

namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option = "0";
            while (option !="8")
            {
                option = MainMenu.Menu();
                Console.Clear();
                if (option == "1" && DegreeProgramCrud.count() > 0)
                {
                    StudentsCrud.AddNewStudent(addStudent());
                }
                else if (option == "2")
                {
                    DegreeProgramCrud.AddNewDegree(addDegreeProgram());
                }
                else if (option == "3")
                {
                    GenerateMerit();
                }
                else if (option == "4")
                {
                    viewRegisteredStudents();
                }
                else if (option == "5")
                {
                    specificProgram();
                }
                else if (option == "6")
                {
                    registerSubjects();
                }
                else if (option == "7")
                {
                    generateFeeChallan();
                }
                transition();
            }
        }

        // adds a student and return the student as an object
        static Student addStudent()
        {
            string name = MainMenu.TakeInput("Student Name");
            int age = int.Parse(MainMenu.TakeInput("Student Age"));
            int fsc = int.Parse(MainMenu.TakeInput("Student FSC Marks"));
            int ecat = int.Parse(MainMenu.TakeInput("Student Ecat Marks"));
            Console.WriteLine("Available Degree Programs: ");
            foreach (DegreeProgram degree in DegreeProgramCrud.GetDegreePrograms())
            {
                Console.WriteLine(degree.name);
            }
            int prefCount = int.Parse(MainMenu.TakeInput("how many preferences to Enter"));
            List<DegreeProgram> preferences = new List<DegreeProgram>();
            for (int i = 0; i < prefCount; i++)
            {
                string degreeName = MainMenu.TakeInput("Degree Name");
                foreach (DegreeProgram degree in DegreeProgramCrud.GetDegreePrograms())
                {
                    if (degreeName == degree.name && !preferences.Contains(degree))
                    {
                        preferences.Add(degree);
                    }
                }
            }
            Student s = new Student(name, age, fsc, ecat, preferences);
            return s;
        }

        // adds a new degree program and returns it as an object
        static DegreeProgram addDegreeProgram()
        {
            string name = MainMenu.TakeInput("Degree Name");
            int duration = int.Parse(MainMenu.TakeInput("Degree Duration"));
            int seats = int.Parse(MainMenu.TakeInput("Seats for Degree"));

            DegreeProgram dP = new DegreeProgram(name, duration, seats);

            // subjects 
            int subjectCount = int.Parse(MainMenu.TakeInput("How many subjects to Enter"));
            for (int i = 0; i < subjectCount; i++)
            {
                dP.addSubject(addSubject());
            }
            return dP;
        }

        // creats a subject object and returns it
        static Subject addSubject()
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
        static void viewSubjects(Student student)
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

        // generates merit
        static void GenerateMerit()
        {
            List<Student> sortedStudents = sortStudents();
            giveAdmission(sortedStudents);
            foreach (Student student in sortedStudents)
            {
                if (student.degree != null)
                {
                    Console.WriteLine("{0} got admission in {1}", student.name, student.degree.name);
                }
                else
                {
                    Console.WriteLine("{0} did not get admission", student.name);
                }
            }
        }

        // view registered students
        static void viewRegisteredStudents()
        {
            Console.WriteLine("Name\t\tFsc\t\tEcat\t\tAge");
            foreach (Student student in StudentsCrud.GetAllStudents())
            {
                if (student.degree != null)
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", student.name, student.fscMarks, student.ecatMarks, student.age);
                }
            }
        }

        // view students of a specific program
        static void specificProgram()
        {
            Console.WriteLine("Enter Degree Name: ");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Name\t\tFsc\t\tEcat\t\tage");
            foreach (Student student in StudentsCrud.GetAllStudents())
            {
                if (student.degree != null && student.degree.name == degreeName)
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", student.name, student.fscMarks, student.ecatMarks, student.age);
                }
            }
        }

        // registers subjects for a student
        static void registerSubjects()
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
                    while(opt != "2") // asking for subjects
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

        // menu for adding a subject for a student while registering for them
        static string subjectRegisterMenu()
        {
            Console.WriteLine("1.Add subject");
            Console.WriteLine("2.Done Registering");
            return Console.ReadLine();
        }

        // sort students list based on merit
        static List<Student> sortStudents()
        { 
            List<Student> sortedList = new List<Student> ();
            foreach (Student s in StudentsCrud.GetAllStudents())
            {
                s.calculateMerit();
            }
            sortedList = StudentsCrud.GetAllStudents().OrderByDescending(o => o.merit).ToList();
            return sortedList;
        }

        // give admissions
        static void giveAdmission(List<Student> students)
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

        // generates fee challan
        static void generateFeeChallan()
        {
            Console.WriteLine("Name\t\tFees");
            int fees = 0;
            foreach(Student student in StudentsCrud.GetAllStudents())
            {                
                if (student.degree != null)
                {
                    fees = 0;
                    foreach (Subject subject in student.subjects)
                    {
                        fees += subject.fees;
                    }
                    Console.WriteLine("{0}\t\t{1}", student.name, fees);
                }
            }
        }

        // checks if a student is available 
        static Student studentPresent(string name, List<Student> students)
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

        // transitions between new screens
        static void transition()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
