using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stagiaires
{
   public class Stagaire
    {
        private int id;
        private string Nom;
        private string Prenom;
        private string tel;
        private DateTime datenais;
        private string email;

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

        public string nom
        {
            get
            {
                return Nom;
            }

            set
            {
                Nom = value;
            }
        }

        public string prenom
        {
            get
            {
                return Prenom;
            }

            set
            {
                Prenom= value;
            }
        }

        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime Datenais
        {
            get
            {
                return datenais;
            }

            set
            {
                datenais = value;
            }
        }
        public Stagaire()
        { }

        public Stagaire(int id, string Nom, string Prenom, string tel, DateTime datenais, string email)
        {
            this.id = id;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.tel = tel;
            this.datenais = datenais;
            this.email = email;
        }
    }
}

    

