using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleSimple
{
    class Program
    {
        static void Main(string[] args)
        {
                // Student collection
                List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "imane", Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 2, StudentName = "walid",  Age = 21, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "loubna",  Age = 18, StandardID = 2 } ,
             
        };

                var teenStudentsName = from s in studentList
                                       where s.Age > 12 && s.Age < 20
                                       select new { StudentName = s.StudentName };

                teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));
            Console.ReadKey();
            }
      }

        public class Student
        {

            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
            public int StandardID { get; set; }
        }


}
