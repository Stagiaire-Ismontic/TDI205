using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqtoProject
{
    class Program
    {
       public static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>() {
                new Student() { Id = 1,Nom = "JK", Age = 13} ,
                new Student() { Id= 2, Nom = "V",  Age = 21 } ,
                new Student() {  Id= 3, Nom = "JM",  Age = 18 } ,
                new Student() {  Id= 4, Nom = "SG" , Age = 20} ,
               
            };

            var teenageStudents=studentList.Where(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine("Teen age students:");
               foreach (Student std in teenageStudents)
            {
                Console.WriteLine(std.Nom);

            }
            }


        }
    }
}
