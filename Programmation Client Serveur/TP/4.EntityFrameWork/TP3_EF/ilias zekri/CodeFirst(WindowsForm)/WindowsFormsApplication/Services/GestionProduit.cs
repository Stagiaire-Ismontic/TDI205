using System;
using WindowsFormsApplication.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Services
{
    public class GestionProduit
    {
       
        public Produit FindById(int Id)
        {
            Classes.Produit p = GestionCommande.context.ListeProduit.SingleOrDefault(s => s.ProduitId == Id);
            return p;
        }

        public void Insert(Produit P)
        {

            GestionCommande.context.ListeProduit.Add(P);
            GestionCommande.context.SaveChanges();
            
        }

        public bool Delete(int Id)
        {
           
                Produit P = GestionCommande.context.ListeProduit.SingleOrDefault(s => s.ProduitId == Id);
                if (P != null)
                {
                GestionCommande.context.ListeProduit.Remove(P);
                GestionCommande.context.SaveChanges();
                    return true;
                }
                return false;
            
        }

        public bool Update(Produit P)
        {
           
                Produit Pr = GestionCommande.context.ListeProduit.SingleOrDefault(s => s.ProduitId == P.ProduitId);
                if (Pr != null)
                {
                    Pr.Nom = P.Nom;
                    Pr.Prix = P.Prix;
                GestionCommande.context.SaveChanges();
                    return true;
                }
                return false;
            
        }

        public List<Produit> Select()
        {
            return GestionCommande.context.ListeProduit.ToList();
                
        }
    }
}
