using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop-6214421017-w03
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s01 = new Student("002");
            Student s02 = new Student("001", "Rungrat", "Sriwirun");
            s01.setFirstname("Anocha");
            s01.setLastname("Prungtaeng");
            Console.WriteLine(s01.ToString());
            Console.WriteLine(s02.ToString());
            Console.WriteLine((new Student("018", "Rene", "Smith")).ToString());

            room r433 = new room("433", "433", 8, 8, "Computer");
            Console.WriteLine(r433.ToString());
            Console.WriteLine("_____________________________________________________________");
             Building s05 = new Building("04", "Faculty of Computer Science and Information Technology", "13.7442", "100.4608");
            Console.WriteLine(s05.ToString());
            Console.WriteLine("_____________________________________________________________");
            Subject s06 = new Subject("9022081", "Web Programming", 3, 2, 2);
            Console.WriteLine(s06.ToString());
            Console.WriteLine("_____________________________________________________________");
            Lecturer s03 = new Lecturer("Nitat", "Ninchawee", "Master of Sience (Electronic Transactions)");
            Console.WriteLine(s03.ToString());
            Console.WriteLine("_____________________________________________________________");
            Curriculum s04 = new Curriculum("Information Technology", "Bachelor");
            Console.WriteLine(s04.ToString());
            Console.WriteLine("_____________________________________________________________");
        }
    }
}
