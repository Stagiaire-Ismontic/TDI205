using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Controle
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public double Note { get; set; }

        public Controle()
        {

        }

        public Controle(int Id, string Nom, double Note)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Note = Note;
        }


    }
}
