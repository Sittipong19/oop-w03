using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421019-w03
{
    class Subject
    {
        private string subjectCode;
        private string subjectName;
        private int subjectUnit;
        private int subjectLecture;
        private int subjectLab;
        public Subject(string c, string n, int u, int le, int la)
        {
            this.subjectCode = c;
            this.subjectName = n;
            this.subjectUnit = u;
            this.subjectLecture = le;
            this.subjectLab = la;
        }
        public override string ToString()
        {
            return "Subject Code: " + this.subjectCode + "\t Subject Name: " + this.subjectName + "\t Subject Unit: " + this.subjectUnit + "\nSubject Lecture Time: " + this.subjectLecture + " hour\tSubject Lab Time: " + this.subjectLab + " hour.";
        }
    }
}
