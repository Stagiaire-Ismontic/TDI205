using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace select_and_where
{
    class Program
    {
        static void Main(string[] args)
        {
            List<student> l = new List<student>();
            {
                new student() { Id = 1, Nom = "imane", Age = 20 };
                new student() { Id = 2, Nom = "walid", Age = 27 };
                new student() { Id = 3, Nom = "loubna", Age = 19 };
            }
            var t = from s in l where s.Age >=18 && s.Age < 26 select new { nom = s.Nom };
            t.ToList().ForEach(s => Console.WriteLine(s.nom));
            Console.ReadKey();




        }
        public class student
        {
            int id;
            string nom;
            int age;

            public int Id
            {
                get
                {
                    return id;
                }

                set
                {
                    id = value;
                }
            }

            public string Nom
            {
                get
                {
                    return nom;
                }

                set
                {
                    nom = value;
                }
            }

            public int Age
            {
                get
                {
                    return age;
                }

                set
                {
                    age = value;
                }
            }

        }
    }
}
