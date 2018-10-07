using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Stu.Student;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string  Age;
            int word;
            Console.WriteLine("Hello Student");
            Student Stu1 = new Student("Safina Yousaf", "2016-CE-60", "1231231231238", "reading, napping", "2000/12/20");
            Stu1.PrintInfo();
            Stu1.GetGender();
            Age = Stu1.GetAge();
            Console.WriteLine(Age);
            word = Stu1.NumberOfWordsInName();
            Console.WriteLine(word);


        }

    }
}
