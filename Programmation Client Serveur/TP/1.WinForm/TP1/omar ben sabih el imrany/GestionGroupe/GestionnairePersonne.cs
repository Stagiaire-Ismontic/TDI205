using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGroupe
{
    class GestionnairePersonne
    {
        public static List<Personne> Lstprs = new List<Personne>();
        public void Ajouter(Personne p)
        {
            Lstprs.Add(p);
        }
        public Personne Rechercher(int id)
        {
            foreach (var i in Lstprs)
            {
                if (i.Id == id)
                {
                    return i;
                }
            }
            return null;
        }

        public void Supprimer(int id)
        {
            Personne p = this.Rechercher(id);
            Lstprs.Remove(p);
        }

        public void Modifier(Personne p)
        {
            Personne ps = this.Rechercher(p.Id);
            ps.Age = p.Age;
            ps.Nom = p.Nom;
        }

        public List<Personne> GetProjet()
        {
            return Lstprs;
        }
    }
}
