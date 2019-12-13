using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacture
{
    public  class GestionFacture
    {
        private static List<Facture> List_Facture = new List<Facture>();


        public static int Indice;

        public bool Ajouter(Facture f)
        {
            Facture fc = this.Recherche(f.Id);
            if (fc == null)
            {
                f.Id = ++Indice;
                List_Facture.Add(f);
                return true;
            }
            return false;      
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

        public bool Supprimer(Facture f)
        {
       
            Facture fc = this.Recherche(f.Id);
            if (fc != null)
            {
                List_Facture.Remove(fc);
                return true;
            }
            return false;

        }

        public bool Modifier(Facture f)
        {

            Facture fc = this.Recherche(f.Id);
            if (fc != null)
            {
                fc.Titre = f.Titre;
                fc.Somme = f.Somme;
                fc.Date = f.Date;
                return true;
            }
            return false;
            

        }

        public List<Facture> Donne()
        {
            return List_Facture;
        }
    }
}
