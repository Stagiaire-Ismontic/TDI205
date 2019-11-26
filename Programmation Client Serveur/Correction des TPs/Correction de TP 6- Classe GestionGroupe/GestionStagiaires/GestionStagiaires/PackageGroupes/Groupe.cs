using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionStagiaires.PackageGroupes
{
    public class Groupe
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public Groupe(int id,string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }

        public Groupe()
        {

        }

        public override string ToString()
        {
            return this.Nom;
        }
    }
}
