using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //-1
            stagiaire s = new stagiaire() { Nome="hmed" };
            Console.WriteLine(s);

            //-2
            var a = "ASAP";
            Console.WriteLine(a.GetType().Name);

            //-3
            var b = new { nome = "si hmed", prenom = "alami" };
            Console.WriteLine(b.nome+" "+b.prenom);


            Console.ReadLine();

        }
    }

    public class stagiaire{
        int id;
        string nome;

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }

        public stagiaire()
        {
            Id = 5;
        }
        public stagiaire(int id)
        {
            this.Id = id;
        }

        public override string ToString()
        {
            return "ID :" + this.Id + " nome:" + this.Nome;
        }

    }
}
