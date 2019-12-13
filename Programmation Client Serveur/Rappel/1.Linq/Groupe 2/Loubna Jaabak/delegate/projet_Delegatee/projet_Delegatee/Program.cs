using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate int NumberChanger(int n);
namespace projet_Delegatee
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(MaClasse.AddNum);
            NumberChanger nc2 = new NumberChanger(MaClasse.MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", MaClasse.getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", MaClasse.getNum());
            Console.ReadKey();
        
    }

    }
}
