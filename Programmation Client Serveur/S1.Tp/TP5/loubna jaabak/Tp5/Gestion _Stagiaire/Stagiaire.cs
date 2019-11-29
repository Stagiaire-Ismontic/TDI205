using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion__Stagiaire
{
  public  class Stagiaire
    {

        private int id;
 

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

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public int Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        public string Id_group
        {
            get
            {
                return id_group;
            }

            set
            {
                id_group = value;
            }
        }

        public string Ville
        {
            get
            {
                return ville;
            }

            set
            {
                ville = value;
            }
        }

        private string nom;
        private string prenom;
        private int note;
        private string id_group;
        private string ville;










        public Stagiaire() { }
        public Stagiaire(int iD, string nom, string prenom, int note, int id_group, string ville)
        {
            this.id = iD;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Note = note;
            this.Id_group = Id_group;
            this.Ville = ville;
        }
        public override string ToString()
        {
            return this.id + "/" + this.Nom + "/" + this.Prenom + "/" + this.Id_group + "/" + this.Ville;
        }
    }
}
