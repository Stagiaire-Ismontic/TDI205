using System;
using WindowsFormsApplication.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Services
{
    public class GestionCommande
    {
        GestionProduit GP = new GestionProduit();

        public static ModelTp context = new ModelTp();

        public Commande FindById(int Id)
        {
               Commande Cm = context.ListeCommande.SingleOrDefault(s => s.CommandeId == Id);
                return Cm;
        }

        public void Insert(Commande Cm)
        {
            
                context.ListeCommande.Add(Cm);
                context.SaveChanges();
            
        }

        public bool Delete(int Id)
        {
            
                Commande Cm =FindById(Id);
            if (Cm != null)
                {
                    context.ListeCommande.Remove(Cm);
                    context.SaveChanges();
                    return true;
                }
                return false;
            
        }

        public bool Update(Commande Cm)
        {

            Commande Cmr = FindById(Cm.CommandeId);
                if (Cmr != null)
                {
                    Cmr.Descriptions = Cm.Descriptions;
                    Cmr.Prix = Cm.Prix;
                    Cmr.Produit = Cm.Produit;
                    context.SaveChanges();
                    return true;
                }
                return false;
            
        }

        public List<Commande> Select()
        {

            return GestionCommande.context.ListeCommande.ToList();
            
        }
    }
}
