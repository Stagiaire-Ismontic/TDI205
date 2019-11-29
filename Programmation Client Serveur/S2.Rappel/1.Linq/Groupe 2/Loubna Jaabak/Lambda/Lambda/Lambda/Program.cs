using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));
            // Output:
            // 4 9 16 25


// Une expression lambda comportant une expression à droite de l’opérateur => est appelée expression lambda.
// Les expressions lambda sont utilisées en grand nombre dans la construction d’arborescences d’expressions.
// Une expression lambda retourne le résultat de l'expression et prend la forme de base suivante :

//(input - parameters) => expression




            //Exemple :expression
            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            Console.WriteLine(e);



            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
            greet("World");
            // Output:
            // Hello World!


            Console.ReadLine();



        }
    }
}
