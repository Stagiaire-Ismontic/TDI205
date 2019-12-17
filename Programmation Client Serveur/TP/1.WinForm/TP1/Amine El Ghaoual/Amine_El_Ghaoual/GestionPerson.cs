using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amine_El_Ghaoual
{
    public class GestionPerson
    {
        public static List<Personne> lstperson = new List<Personne>();

        public static int countId;

        public void Ajouter(Personne p)
        {
            p.id = ++countId;
            lstperson.Add(p)
;
        }

        public bool Suprimer(int id)
        {
            Personne P = Recherche(id);
            if (P != null)
            {
                lstperson.Remove(P);
                return true;
            }
            return false;

        }

        public bool Modifier(Personne p)
        {

            Personne Pr = Recherche(p.id);
            if (Pr != null)
            {
                Pr.Nom = p.nom;
                Pr.Prenom = p.prenom;
                Pr.Age = p.age;
                return true;
            }
            return false;
   
        }

        public Personne Recherche(int id)
        {
            Personne P= lstperson.SingleOrDefault(s => s.id == id);
            return P;
        }

        public List<Personne> afficher()
        {
            return lstperson;
        }
    }
}
