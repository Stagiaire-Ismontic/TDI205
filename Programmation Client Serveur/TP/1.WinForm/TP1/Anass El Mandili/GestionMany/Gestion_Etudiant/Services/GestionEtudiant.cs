using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Etudiant
{
    public class GestionEtudiant
    {
        public List<Etudiant> lststag = new List<Etudiant>();

        public void ajouter(int id, string nom, string prenom)
        {
            if (recherche(id) == null)
                lststag.Add(new Etudiant(id, nom, prenom));
            else
                throw new Exception("id existe deja");
        }
        public void suprimer(int id)
        {
            Etudiant E = recherche(id);
            if (E != null)
                lststag.Remove(E);
            else
                throw new Exception("il n'existe pas");

        }

        public void modifier(int id, string nom, string TEL)
        {
            Etudiant E = recherche(id);
            if (E == null)
                throw new Exception("n'existe pas");
            else
            {
                E.Etud_Name1 = nom;
                E.Etud_Tel1 = TEL;
            }
                
        }

        public Etudiant recherche(int id)
        {
            foreach (Etudiant s in lststag)
            {
                if (s.Etud_Id1 == id)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
