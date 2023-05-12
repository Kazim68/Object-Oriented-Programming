using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;

namespace Challenge1.DL
{
    internal class StudentsCrud
    {
        static List<Student> students = new List<Student>();

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
    }
}
