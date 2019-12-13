using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberthree
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<stagiaire> lst = new List<stagiaire>() {
                new stagiaire(0,"brahim"),
                new stagiaire(1,"abdo"),
                new stagiaire(2,"lwalid"),
                new stagiaire(3,"mohamed"),
                new stagiaire(4,"ahmed"),
                new stagiaire(5,"Lamz"),
                new stagiaire(6,"jack"),
                new stagiaire(8,"spotLite"),
                new stagiaire(9,"karmos"),
                new stagiaire(10,"Hamid"),
                new stagiaire(11,"chto")
            };
            var query = from st in lst where st.Nome == "Hamid" select st;
            foreach(var a in query)
            Console.WriteLine(a.Id+" "+a.Nome);
            

            Console.ReadLine();
        }
    }
    public class stagiaire
    {
        int id;
        string nome;

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }

        public stagiaire()
        {
        }
        public stagiaire(int id,string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public override string ToString()
        {
            return "ID :" + this.Id + " nome:" + this.Nome;
        }

    }
}
