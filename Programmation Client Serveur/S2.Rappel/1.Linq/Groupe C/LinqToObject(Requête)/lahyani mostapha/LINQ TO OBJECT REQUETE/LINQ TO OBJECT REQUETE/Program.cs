using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_TO_OBJECT_REQUETE
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student collection
            List<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "Selvia", Age = 23, StandardID = 1 } ,
                new Student() { StudentID = 2, StudentName = "Aamirah",  Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Imad",  Age = 21, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Unknown" , Age = 20, StandardID = 2 } ,
                new Student() { StudentID = 5, StudentName = "Jack" , Age = 21 }
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
