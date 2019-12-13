using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializationSample
{
    class InitializationSample
    {

        public class Cat
        {
            // Auto-implemented properties.
            public int Age { get; set; }
            public string Name { get; set; }

            public Cat() { }

            public Cat(string name)
            {
                Name = name;
            }
        }

        public static void Main()
        {
            Cat cat = new Cat { Age = 10, Name = "Fluffy" };
            Cat sameCat = new Cat("Fluffy") { Age = 10 };

            List<Cat> cats = new List<Cat>
        {
            new Cat { Name = "Sylvester", Age = 8 },
            new Cat { Name = "Whiskers", Age = 2 },
            new Cat { Name = "Sasha", Age = 14 }
        };

            List<Cat> moreCats = new List<Cat>
        {
            new Cat { Name = "Furrytail", Age = 5 },
            new Cat { Name = "Peaches", Age = 4 },
            null
        };

            // Display results.
            System.Console.WriteLine(cat.Name);

            foreach (Cat c in cats)
                System.Console.WriteLine(c.Name);

            foreach (Cat c in moreCats)
                if (c != null)
                    System.Console.WriteLine(c.Name);
                else
                    System.Console.WriteLine("List element has null value.");
        }
    }
}