using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Scores = new List<int>() { 97, 92, 81, 60 };

           
            var queryHighScores =
                from score in Scores
                where score > 80
                select score;

            
            foreach (int i in queryHighScores)
            {
                Console.Write(i +Environment.NewLine);
            }
        }
    }
}
