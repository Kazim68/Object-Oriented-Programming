using Challenge1.BL;
using Challenge1.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.UI
{
    internal class StudentUI
    {
        // adds a student and return the student as an object
        public static Student takeStudentInput()
        {
            string name = MainMenu.TakeInput("Student Name");
            int age = int.Parse(MainMenu.TakeInput("Student Age"));
            int fsc = int.Parse(MainMenu.TakeInput("Student FSC Marks"));
            int ecat = int.Parse(MainMenu.TakeInput("Student Ecat Marks"));
            Console.WriteLine("Available Degree Programs: ");
            DegreeUI.viewDegreePrograms();
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

        // generates merit
        public static void GenerateMerit()
        {
            List<Student> sortedStudents = StudentsCrud.sortStudents();
            StudentsCrud.giveAdmission(sortedStudents);
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
        public static void viewRegisteredStudents()
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
        public static void specificProgram()
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

        // generates fee challan
        public static void generateFeeChallan()
        {
            Console.WriteLine("Name\t\tFees");
            int fees = 0;
            foreach (Student student in StudentsCrud.GetAllStudents())
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
    }
}
