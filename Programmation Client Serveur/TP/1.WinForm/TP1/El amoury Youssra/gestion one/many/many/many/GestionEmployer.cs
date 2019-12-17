using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace many
{
  public   class GestionEmployer
    {
        public static List<Employer> List=new List<Employer>();

        public bool Ajouter(Employer e)
        {
            Employer p = Chercher(e.Id);
            if (p == null)
            {
                List.Add(e);
                return true;
            }
            return false;
        }

        public Employer Chercher(int id)
        {
            Employer p= List.SingleOrDefault(s=>s.Id==id);
            return p;
        }

        public bool Supprimer(int id)
        {
            Employer a = Chercher(id);
            if (a != null)
            {
                List.Remove(a);
                return true;
            }
            return false;

        }

        public bool Modifier(Employer e)
        {
            Employer a = Chercher(e.Id);
            if (a != null)
            {
                a.Nom = e.Nom;
                a.Prenom = e.Prenom;
                a.Entreprise = e.Entreprise;
                return true;
            }
            return false;
        }

        public List<Employer> Afficher()
        {
            return List;
        }



    }

}

