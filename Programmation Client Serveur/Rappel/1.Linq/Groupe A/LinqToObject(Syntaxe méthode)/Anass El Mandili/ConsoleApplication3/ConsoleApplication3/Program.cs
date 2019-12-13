using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> LS = new List<Student>()
            {
                new Student() { Id=1,Name="Joshua",Age=20},
                new Student() { Id=2,Name="Kris",Age=15},
                new Student() { Id=3,Name="Sara",Age=18},
                new Student() { Id=4,Name="Dora",Age=17},
            };
            var Teens = LS.Where(S => S.Age > 12 && S.Age < 20);
            foreach (Student Std in Teens)
            {
                Console.WriteLine("Student :" + Std.Id + " " + Std.Name + " " + Std.Age);
            }
            Console.ReadLine();
        }
    }
}
