using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudWin.Entities
{
    public class Employer
    {
        int id;
        string prenom;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom { get => prenom; set => prenom = value; }

        public Employer(int id, string nom,string prenom) {
            this.id = id;
            this.nom = nom;
            this.prenom =prenom;
        }

        public Employer()
        {
           
        }
    }
}
