using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1.BL
{
    internal class Student
    {
        public string name;
        public int rollNo;
        public float cgpa;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public string homeTown;
        public bool isHostelite;
        public bool isTakingScholarship;

        // default constructors
        public Student()
        {
            this.name = null;
            this.rollNo = 0;
            this.cgpa = 0;
            this.matricMarks = 0;
            this.fscMarks = 0;
            this.ecatMarks = 0;
            this.homeTown = null;
            this.isTakingScholarship = false;
            this.isHostelite = false;
        }

        // parameterized contstructor
        public Student(string name, int rollNo, int cgpa, int matricMarks, int fscMarks, int ecatMarks, string homeTown, bool isHostelite, bool isTakingScholarship)
        {
            this.name = name;
            this.rollNo = rollNo;
            this.cgpa = cgpa;
            this.matricMarks = matricMarks;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.homeTown = homeTown;
            this.isHostelite = isHostelite;
            this.isTakingScholarship = isTakingScholarship;
        }

        // calculate merit
        public float merit()
        {
            return (0.6F * this.fscMarks) + (0.4F * this.ecatMarks);
        }

        // checking eligiblility for scholarship
        public bool isElegibleForScholarship(float meritPercentage)
        {
            if (this.isHostelite && meritPercentage > 80)
            {
                return true;
            }
            return false;
        }
    }
}
