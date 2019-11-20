using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionTaches.GestionProjets
{
    public class GestionnaireProjets
    {
        public static List<Projets> liste_projets = new List<Projets>();
        private static int nombreprojets;
        
        public int Ajouter(Projets P)
        {
            if(P.Id != 0)
            {
                throw new Exception("Impossible d'ajouter une projets existe deja");
            }
            else
            {
                P.Id = ++GestionnaireProjets.nombreprojets;
                P.DateCreation1 = DateTime.Now;
                liste_projets.Add(P);
            }
            return P.Id;
        } 

        public Projets RechercheById(int id)
        {
            foreach (var i in liste_projets)
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
            Projets p = this.RechercheById(id);
            liste_projets.Remove(p);
        }

        public void Modifier (Projets P)
        {
            if (P.Id == 0)
            {
                Projets pm = this.RechercheById(P.Id);
                P.DateModification1 = DateTime.Now;
                liste_projets.Insert(liste_projets.IndexOf(pm), P);
            }
        }

        public List<Projets> GetProjets() 
        {
            return liste_projets;
        }

        public Projets Debut() 
        {
            if (liste_projets.Count > 0) return liste_projets[0];
            else return null;
        }

        public Projets Suivant(int Id)
        {
            Projets P = this.RechercheById(Id);
            int index = liste_projets.IndexOf(P);
            if ((liste_projets.Count - 1 )>= (index + 1))
            {
                return liste_projets[index + 1];
            }
            else
            {
                return null;
            }
        }

        public Projets Precedent(int Id)
        {
            Projets P = this.RechercheById(Id);
            int index = liste_projets.IndexOf(P);
            if ((liste_projets.Count - 1) >= (index - 1)&&(index>0)) 
            {
                return liste_projets[index - 1]; 
            }
            else 
            { 
                return null; 
            }
        }

        public Projets Fin()
        {
            if (liste_projets.Count > 0) return liste_projets[liste_projets.Count-1];
            else return null;
        }

    
    }
}
