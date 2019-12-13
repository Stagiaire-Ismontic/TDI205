using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializationSample
{
    public class Objects
    {
        private int id;
        private string nom;
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

        public Objects() { id = 5;
        }

        public Objects(int id)
        {
            this.id = id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        { //initialize Object 
            Objects ob = new Objects() { Nom = "madani" };
            Console.WriteLine(ob.Nom);

            //inference de type-var
            var a = 15;
            Console.WriteLine(a.GetType());
            
            //type anoanymes
            var etudiant = new { id = 1, name = "ali" };
            Console.WriteLine(etudiant.id + etudiant.name);
        Console.ReadLine();
        }
    }
}
