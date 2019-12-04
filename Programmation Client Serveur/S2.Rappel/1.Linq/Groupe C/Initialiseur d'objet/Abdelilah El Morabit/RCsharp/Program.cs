using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCsharp
{
    class Program
    {
        public class obj
        {
            int age;
            string name;

            public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }
            public obj() { }
            public obj(string name) { Name = name; }
            public obj(int age,string name)
            {
                Age = age;
                Name = name;
            }

        }
        static void Main(string[] args)
        {
            //initialiseur d'obj
            obj o = new obj("kk"){  Age= 1 };

            //interface de type var
            var nm = "lol";
            Console.WriteLine(nm);

            //type anonymes
            var etu = new { id=1,name="lb" };
            Console.WriteLine($"id={etu.id}--{etu.name}");


        }
    }
}
