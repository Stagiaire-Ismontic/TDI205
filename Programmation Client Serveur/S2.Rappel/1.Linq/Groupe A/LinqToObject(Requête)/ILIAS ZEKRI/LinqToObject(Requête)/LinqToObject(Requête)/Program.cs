using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject_Requête_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> lst = new List<Student>
            {
                new Student() {id=1,nom="ilias",age=23 },
                new Student() {id=2,nom="omar",age=21 },
                new Student() {id=3,nom="mohamed",age=19 }
            };
            var x = from s in lst where s.age > 20 && s.age < 25 select new { nom = s.nom };
            x.ToList().ForEach(s => Console.WriteLine("nom : " + s.nom));
            Console.ReadKey();
        }
    }
}
