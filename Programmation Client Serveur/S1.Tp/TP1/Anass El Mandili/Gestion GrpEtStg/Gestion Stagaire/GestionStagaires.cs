using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_GrpEtStg
{
    public class GestionStagaires
    {
        public List<Stagiaire> lststag = new List<Stagiaire>();

        public void ajouter(int id, string nom, string prenom)
        {
            if (recherche(id) == null)
                lststag.Add(new Stagiaire(id, nom, prenom));
            else
                throw new Exception("id existe deja");
        }
        public void suprimer(int id)
        {
            Stagiaire s = recherche(id);
            if (s != null)
                lststag.Remove(s);
            else
                throw new Exception("il n'existe pas");

        }

        public void modifier(int id, string nom, string prenom)
        {
            Stagiaire s = recherche(id);
            if (s == null)
                throw new Exception("n'existe pas");
            else
            {
                s.Nom = nom;
                s.Prenom = prenom;
            }
                
        }

        public Stagiaire recherche(int id)
        {
            foreach (Stagiaire s in lststag)
            {
                if (s.Id == id)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
