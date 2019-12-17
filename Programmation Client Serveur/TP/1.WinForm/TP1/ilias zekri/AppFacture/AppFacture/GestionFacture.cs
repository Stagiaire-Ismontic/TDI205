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
                List_Facture.Add(f);     
        }

        public Facture Recherche(int Id)
        {
            Facture F=List_Facture.SingleOrDefault(s=>s.Id==Id);
            return F;
        }

        public bool Supprimer(int Id)
        {
       
            Facture fc = Recherche(Id);
            if (fc != null)
            {
                List_Facture.Remove(fc);
                return true;
            }
            return false;

        }

        public bool Modifier(Facture f)
        {

            Facture fc = Recherche(f.Id);
            if (fc != null)
            {
                fc.Titre = f.Titre;
                fc.Somme = f.Somme;
                fc.Date = f.Date;
                fc.Client = f.Client;
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
