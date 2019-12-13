using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_methode
{
 public   class VariableCaptureGame
    {
        internal Action<int> updateVariable;
        internal Func<int, bool> Variable;

        public void Run(int input)
        {
            int j = 0;

            updateVariable = x =>
            {
                j = x;
                bool result = j > input;
                Console.WriteLine($"{j} is greater than {input}: {result}");
            };

             Variable = x => x == j;

            Console.WriteLine($" {j}");
            updateVariable(10);
            Console.WriteLine($" {j}");
        }
    }
}
