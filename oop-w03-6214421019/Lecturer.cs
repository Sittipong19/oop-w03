using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421017-w03
{
    class Lecturer
    {
        private string lecturerFirstname;
        private string lecturerLastname;
        private string lecturerPosition;
        public Lecturer(string f, string l, string p)
        {
            this.lecturerFirstname = f;
            this.lecturerLastname = l;
            this.lecturerPosition = p;
        }
        public override string ToString()
        {
            return "lecturer Firstname: " + this.lecturerFirstname + "\t lecturer Lastname: " + this.lecturerLastname + "\t lecturerPosition: " + this.lecturerPosition;
        }
    }
}
