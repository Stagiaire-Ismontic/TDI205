using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_TO_OBJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> StudentList = new List<Student>()
            {
                new Student() { StudentID=1,StudentName="Loubna",Age=20,StandarID=1 },
                new Student() { StudentID=2,StudentName="hahah",Age=40,StandarID=2 },
                new Student() { StudentID=3,StudentName="jfb",Age=8,StandarID=1 }
            };
            var teenstudentName = from s in StudentList
                                  where s.Age > 12 && s.Age < 25
                                  select new { StudentName = s.StudentName };
            teenstudentName.ToList().ForEach(s => Console.WriteLine(s.StudentName));

            Console.ReadKey();
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName{ get; set; }
        public int Age { get; set; }
        public int StandarID { get; set; }

    }
}
