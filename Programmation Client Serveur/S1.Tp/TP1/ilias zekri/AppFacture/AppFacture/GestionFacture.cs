using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacture
{
    public  class GestionFacture
    {
        public static List<Facture> List_Facture = new List<Facture>();


        public static int Indice;

        public void Ajouter(Facture f)
        {
            f.Id = ++Indice;
            f.Date = DateTime.Now;
            List_Facture.Add(f);
        }

        public Facture Recherche(int Id)
        {
            foreach(var Fac in List_Facture)
            {
                if (Fac.Id == Id)
                {
                    return Fac;
                }
            }
            return null;
        }

        public void Supprimer(Facture f)
        {
            Facture fc = this.Recherche(f.Id);
            List_Facture.Remove(fc);
    
            
        }

        public void Modifier(Facture f)
        {
            Facture fc = this.Recherche(f.Id);
            fc.Titre = f.Titre;
            fc.Somme = f.Somme;

        }

        public List<Facture> Donne()
        {
            return List_Facture;
        }
    }
}
