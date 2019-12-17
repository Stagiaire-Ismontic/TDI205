using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amine_El_Ghaoual
{
    public class Personne
    {
        public int id;
        public string nom;
        public string prenom;
        public int age;
        private Genre genre;


        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }
        public Genre Genre { get => genre; set => genre = value; }

        public Personne()
        {

        }
        public Personne( string nom,string prenom,int age,Genre genre)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.genre = genre;
        }

    }
}
