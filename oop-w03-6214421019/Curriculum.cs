using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421017-w03
{
    class Curriculum
    {
        private string curriculumName;
        private string curriculumDegree;
        public Curriculum(string n, string d)
        {
            this.curriculumName = n;
            this.curriculumDegree = d;
        }
        public override string ToString()
        {
            return "curriculum Name: " + this.curriculumName + "\t curriculum Degree: " + this.curriculumDegree;
        }
    }
}