using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop-6214421017-w03
{
    class Student
    {
        private string sid;
        private string firstname;
        private string lastname;
        public Student() { }
        public Student(string s)
        {
            this.sid = s;
        }

        public Student(string s, string f, string l)
        {
            this.sid = s;
            this.firstname = f;
            this.lastname = l;
        }
        public void setSid(string s)
        {
            this.sid = s;
        }
        public string getSid()
        {
            return this.sid;
        }
        public void setFirstname(string f)
        {
            this.firstname = f;
        }
        public string getsetFirstname()
        {
            return this.firstname;
        }
        public void setLastname(string l)
        {
            this.lastname = l;
        }
        public string getLastname()
        {
            return this.lastname;
        }
        public override string ToString()
        {
            return "SID : " + this.getSid() + " Name : "
               + this.getsetFirstname() + "" + this.getLastname();
        }
    }
}