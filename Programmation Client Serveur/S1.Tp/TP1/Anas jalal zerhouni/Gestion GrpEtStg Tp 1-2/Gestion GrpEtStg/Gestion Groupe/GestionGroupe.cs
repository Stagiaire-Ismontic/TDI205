using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_GrpEtStg
{
    public class GestionGroupe
    {
        public List<Groupe> lstGrp = new List<Groupe>();
        public void ajouter(int id, string nom)
        {
            if (recherche(id) == null)
                lstGrp.Add(new Groupe(id, nom));
            else
                throw new Exception("id existe deja");
        }
        public void suprimer(int id)
        {
            Groupe g = recherche(id);
            if (g != null)
                lstGrp.Remove(g);
            else
                throw new Exception("il n'existe pas");
        }
        public void modifier(int id, string nom)
        {
            Groupe g = recherche(id);
            if (g == null)
                throw new Exception("n'existe pas");
            else
                g.Nom = nom;
            
        }

        public Groupe recherche(int id)
        {
            foreach (Groupe g in lstGrp)
            {
                if (g.Id == id)
                {
                    return g;
                }
            }
            return null;
        }


    }
}
