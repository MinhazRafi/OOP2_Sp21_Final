using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Student("1939", "Rafi", 3.56F);
            var v2 = new Student("1949", "Minhaz", 3.81F);
            var v3 = new Student("1969", "Adib", 4.00F);




            var v4 = new Course("2131", "Software");
            var v5 = new Course("2132", "OOP-2");
            var v6 = new Course("2133", "OOP 1");




            v4.AddStudent(v1,v2, v3);

            v4.PrintStudent();

            v4.RemoveStudent(v3);
            Console.WriteLine("");

            Console.WriteLine("**After removed the student**");
            Console.WriteLine("");

            v1.PrintCourse();
            v4.PrintStudent();

            Console.WriteLine();

            v3.AddCourse(v4, v5, v6);
            v3.PrintCourse();

            v3.RemoveCourse(v5);
            Console.WriteLine("");
            Console.WriteLine("**After remove the course**");
            Console.WriteLine("");
            v3.PrintCourse();
            v5.PrintStudent();
        }
    }
}

