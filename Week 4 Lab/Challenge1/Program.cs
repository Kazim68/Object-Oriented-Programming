using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;

namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<DegreeProgram> degreePrograms = new List<DegreeProgram>();
            string option = "0";
            while (option !="8")
            {
                option = Menu();
                Console.Clear();
                if (option == "1")
                {
                    students.Add(addStudent(degreePrograms));
                }
                else if (option == "2")
                {
                    degreePrograms.Add(addDegreeProgram());
                }
                else if (option == "3")
                {
                    GenerateMerit(students, degreePrograms);
                }
                else if (option == "4")
                {
                    viewRegisteredStudents(students);
                }
                else if (option == "5")
                {
                    specificProgram(students);
                }
                else if (option == "6")
                {
                    registerSubjects(students);
                }
                else if (option == "7")
                {
                    generateFeeChallan(students);
                }
                transition();
            }
        }

        // menu returns a string indicating chosen option
        static string Menu()
        {
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Add Degree Program");
            Console.WriteLine("3.Generate Merit List");
            Console.WriteLine("4.View Registered Students");
            Console.WriteLine("5.View Students of a specific program");
            Console.WriteLine("6.Register Subjects for a specific Student");
            Console.WriteLine("7.Calculate fees for all registered students");
            Console.WriteLine("8.Exit");
            Console.Write("Enter Your choice: ");
            return Console.ReadLine();
        }

        // adds a student and return the student as an object
        static Student addStudent(List<DegreeProgram> degreePrograms)
        {
            Console.WriteLine("Enter student Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student FSC Marks: ");
            int fsc = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Ecat Marks: ");
            int ecat = int.Parse(Console.ReadLine());
            Console.WriteLine("Available Degree Programs: ");
            foreach (DegreeProgram degree in degreePrograms)
            {
                Console.WriteLine(degree.name);
            }
            Console.WriteLine("Enter how many preferences to Enter: ");
            int prefCount = int.Parse(Console.ReadLine());
            List<string> preferences = new List<string>();
            for (int i = 0; i < prefCount; i++)
            {
                preferences.Add(Console.ReadLine());
            }
            Student s = new Student(name, age, fsc, ecat, preferences);
            return s;
        }

        // adds a new degree program and returns it as an object
        static DegreeProgram addDegreeProgram()
        {
            Console.WriteLine("Enter Degree Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Degree Duration: ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seats for Degree: ");
            int seats = int.Parse(Console.ReadLine());
            // subjects 
            Console.WriteLine("Enter How many subjects to Enter: ");
            int subjectCount = int.Parse(Console.ReadLine());
            List<Subject> subjects = new List<Subject>();
            int hours = 0; // for validation of total number of credit hours in a program
            for (int i = 0; i < subjectCount; i++)
            {
                if (hours < 20)
                {
                    subjects.Add(addSubject());
                }
                else if (hours + subjects[i].creditHour >=20)
                {
                    subjects[i].creditHour = 20 - hours;
                    break;
                }
                hours += subjects[i].creditHour;
            }
            DegreeProgram dP = new DegreeProgram(name, duration, seats, subjects);
            return dP;
        }

        // creats a subject object and returns it
        static Subject addSubject()
        {
            Console.WriteLine("Enter Subject Code: ");
            string code = Console.ReadLine();
            Console.WriteLine("Enter Subject Type: ");
            string type = Console.ReadLine();
            int hours = 0;
            while (hours > 3 || hours <= 0)
            {
                Console.WriteLine("Enter Subject Credit Hour: ");
                hours = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Subject Fees: ");
            int fees = int.Parse(Console.ReadLine());
            Subject s = new Subject(code, type, hours, fees);
            return s;
        }

        // generates merit
        static void GenerateMerit(List<Student> students, List<DegreeProgram> degreePrograms)
        {
            int degreeCount = 0;
            foreach (Student student in students)
            {
                if (degreeCount <= degreePrograms.Count-1 && degreePrograms[degreeCount].seats > 0)
                {
                    student.degree = degreePrograms[degreeCount];
                    degreePrograms[degreeCount].seats--;
                    Console.WriteLine(student.name + " got Admission in " + student.degree.name);
                }
                else if (degreeCount > degreePrograms.Count)
                {
                    student.degree = null;
                    Console.WriteLine(student.name + " didn't get Admission");
                }
                if (degreePrograms[degreeCount].seats == 0)
                {
                    degreeCount++;
                }
            }
        }

        // view registered students
        static void viewRegisteredStudents(List<Student> students)
        {
            Console.WriteLine("Name\t\tFsc\t\tEcat\t\tAge");
            foreach (Student student in students)
            {
                if (student.degree != null)
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", student.name, student.fscMarks, student.ecatMarks, student.age);
                }
            }
        }

        // view students of a specific program
        static void specificProgram(List<Student> students)
        {
            Console.WriteLine("Enter Degree Name: ");
            string degree = Console.ReadLine();
            Console.WriteLine("Name\t\tFsc\t\tEcat\t\tage");
            foreach (Student student in students)
            {
                if (student.degree.name == degree)
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", student.name, student.fscMarks, student.ecatMarks, student.age);
                }
            }
        }

        // registers subjects for a student
        static void registerSubjects(List<Student> students)
        {
            Console.WriteLine("Enter name of Student: ");
            string name = Console.ReadLine();
            int hours = 0;
            string opt = "", code = "";
            for (int i = 0; i < students.Count; i++) // finds the student
            {
                if (name == students[i].name) // found the student
                {
                    while(opt != "2") // asking for subjects
                    {
                        opt = subjectRegisterMenu(); // subject menu returns the choice of user
                        if (opt == "1")
                        {
                            Console.WriteLine("Enter Code of Subject: ");
                            code = Console.ReadLine();
                            Subject s = null;
                            if ((s = findSubject(code, students[i].degree)) != null) // checks if the subject was found in the program
                            {
                                if (hours + s.creditHour <= 9) // checks if the hours are within 9
                                {
                                    students[i].subjects.Add(s);
                                    hours += s.creditHour;
                                }
                                else
                                {
                                    Console.WriteLine("Credit hours should be less than or equal to 9");
                                }
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

        // generates fee challan
        static void generateFeeChallan(List<Student> students)
        {
            Console.WriteLine("Name\t\tFees");
            int fees = 0;
            foreach(Student student in students)
            {
                if (student.degree != null)
                {
                    foreach(Subject subject in student.subjects)
                    {
                        fees += subject.fees;
                    }
                    Console.WriteLine("{0}\t\t{1}", student.name, fees);
                }
            }
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
