using Challenge1.BL;
using System;
using System.Collections.Generic;
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
    }
}
