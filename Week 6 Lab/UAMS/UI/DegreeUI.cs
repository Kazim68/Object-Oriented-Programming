using Challenge1.BL;
using Challenge1.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.UI
{
    internal class DegreeUI
    {
        // adds a new degree program and returns it as an object
        public static DegreeProgram takeDegreeProgramInput()
        {
            string name = MainMenu.TakeInput("Degree Name");
            int duration = int.Parse(MainMenu.TakeInput("Degree Duration"));
            int seats = int.Parse(MainMenu.TakeInput("Seats for Degree"));

            DegreeProgram dP = new DegreeProgram(name, duration, seats);

            // subjects 
            int subjectCount = int.Parse(MainMenu.TakeInput("How many subjects to Enter"));
            for (int i = 0; i < subjectCount; i++)
            {
                dP.addSubject(SubjectUI.takeSubjectInput());
            }
            return dP;
        }

        // print all degrees
        public static void viewDegreePrograms()
        {
            foreach (DegreeProgram dP in DegreeProgramCrud.GetDegreePrograms())
            {
                Console.WriteLine(dP.name);
            }
        }
    }
}
