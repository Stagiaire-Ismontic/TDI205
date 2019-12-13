using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_methode
{
    class Program
    {
        static void Main(string[] args)
        {
      
            var g = new VariableCaptureGame();

            int Input = 5;
            g.Run(Input);

            int Try = 10;
            bool result = g.Variable(Try);
            Console.WriteLine($" {Try}: {result}");

            int J = 3;
            g.updateVariable(J);

            bool equal = g.Variable(J);
            Console.WriteLine($" {equal}");
            Console.ReadLine();
        }
    }
}
