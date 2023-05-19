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
                    StudentsCrud.AddNewStudent(StudentUI.takeStudentInput());
                }
                else if (option == "2")
                {
                    DegreeProgramCrud.AddNewDegree(DegreeUI.takeDegreeProgramInput());
                }
                else if (option == "3")
                {
                    StudentUI.GenerateMerit();
                }
                else if (option == "4")
                {
                    StudentUI.viewRegisteredStudents();
                }
                else if (option == "5")
                {
                    StudentUI.specificProgram();
                }
                else if (option == "6")
                {
                    SubjectUI.registerSubjects();
                }
                else if (option == "7")
                {
                    StudentUI.generateFeeChallan();
                }
                MainMenu.transition();
            }
        }
    }
}
