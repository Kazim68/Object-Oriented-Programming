using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Student s1 = new Student();
            clearScreen();
            while (true)
            {
                int choice = Menu();
                clearScreen();
                if (choice == 1)
                {
                    s1.Add_student(ref count);
                }
                else if (choice == 2)
                {
                    s1.View_Students(count);
                }
                else if (choice == 3)
                {
                    s1.TopStudents(s1, count);
                }
                else
                {
                    break;
                }
                clearScreen();
            }
            Console.ReadKey();

        }

        static int Menu()
        {
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.View Student");
            Console.WriteLine("3.Top three Students");
            Console.WriteLine("4.Exit");
            return ValidInt(4, "Enter your choice: ");
        }


        static int ValidInt(int limit, string message)
        {
            string option = "";
            bool found = false;
            while (!found)
            {
                Console.Write(message);
                option = Console.ReadLine();
                if (option.Length > 0 && option.Length < 5)
                {
                    for (int i = 0; i < option.Length; i++)
                    {
                        if (option[i] < 58 && option[i] > 47) // 48 -> 0 | 57 -> 9
                        {
                            if (i == option.Length - 1 && int.Parse(option) <= limit)
                            {
                                return int.Parse(option);
                            }
                            continue;
                        }
                        break;
                    }
                }
                Console.WriteLine("Invalid input!");
            }
            return -1;
        }

        // for next screen transition
        static void clearScreen()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
    class Student
    {
        public string sname;
        public int age;
        public float cgpa;
        public char is_hostilide;
        public string department;
        Student[] arr = new Student[100];

        public void Add_student(ref int count)
        {
            Console.Clear();
            Student obj = new Student();
            arr[count] = obj;
            Console.Write("Enter name of Student: ");
            arr[count].sname = Console.ReadLine();
            arr[count].age = ValidInt(100, "Enter age of student: ");
            arr[count].cgpa = ValidFloat(4, "Enter cgpa of student: ");
            arr[count].is_hostilide = ValidChar('y', 'n', "Is the student hostilide: ");
            Console.Write("Enter name of Department: ");
            arr[count].department = Console.ReadLine();
            //Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", arr[count].sname, arr[count].age, arr[count].cgpa, arr[count].is_hostilide, arr[count].department);
            count++;
            Console.WriteLine("Student data added successfully!");
        }

        public void View_Students(int count)
        {
            Console.WriteLine("Name\t\tAge\t\tcgpa\t\tHostilide\t\tDepartment");
            if (count == 0)
            {
                Console.WriteLine("No records...");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(arr[i].sname + "\t\t" + arr[i].age + "\t\t" + arr[i].cgpa + "\t\t" + arr[i].is_hostilide + "\t\t\t" + arr[i].department);
                }
            }
        }

        public void TopStudents(Student s, int count)
        {
            if (count == 0)
            {
                Console.WriteLine("No records!");
            }
            else if (count < 3 )
            {
                s.View_Students(count);
            }
            else
            {
                int idx = 0;
                Student temp;
                for (int i = 0; i < 3; i++)
                {
                    idx = Large(i, count);
                    temp = arr[idx];
                    arr[idx] = arr[i];
                    arr[i] = temp;
                }
                s.View_Students(3);
            }
        }

        public int Large(int start, int count)
        {
            int max = 0;
            for (int i = start; i<count; i++)
            {
                if (arr[i].cgpa >= arr[max].cgpa)
                {
                    max = i;
                }
            }
            return max;
        }

        static int ValidInt(int limit, string message)
        {
            string option = "";
            bool found = false;
            while (!found)
            {
                Console.Write(message);
                option = Console.ReadLine();
                if (option.Length > 0 && option.Length < 5)
                {
                    for (int i = 0; i < option.Length; i++)
                    {
                        if (option[i] < 58 && option[i] > 47) // 48 -> 0 | 57 -> 9
                        {
                            if (i == option.Length - 1 && int.Parse(option) <= limit)
                            {
                                return int.Parse(option);
                            }
                            continue;
                        }
                        break;
                    }
                }
                Console.WriteLine("Invalid input!");
            }
            return -1;
        }

        static float ValidFloat(int limit, string message)
        {
            string option = "";
            bool found = false;
            int dot = 0;
            while (!found)
            {
                Console.Write(message);
                option = Console.ReadLine();
                if (option.Length > 0 && option.Length < 5)
                {
                    for (int i = 0; i < option.Length; i++)
                    {
                        if ((option[i] < 58 && option[i] > 47 ) || option[i] == '.') // 48 -> 0 | 57 -> 9
                        {
                            if (option[i] == '.')
                            {
                                dot++;
                            }
                            if (dot > 1)
                            {
                                break;
                            }
                            if (i == option.Length - 1 && float.Parse(option) <= limit)
                            {
                                return float.Parse(option);
                            }
                            continue;
                        }
                        break;
                    }
                }
                Console.WriteLine("Invalid input!");
            }
            return -1;
        }

        static char ValidChar(char one, char two, string message)
        {
            string option = "";
            bool found = false;
            while (!found)
            {
                Console.Write(message);
                option = Console.ReadLine();
                if (option.Length ==1)
                {
                    
                    if (char.Parse(option.ToLower()) == one || char.Parse(option.ToLower()) == two)
                    {
                        return char.Parse(option);
                    }
                    break;
                    
                }
                Console.WriteLine("Invalid input!");
            }
            return 'n';
        }
    }
}
