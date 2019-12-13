using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c=new GestionComEntities())
            {
                ////Ajouter
                //Produit p = new Produit() { IdProduit = 1, Nom = "Kawkaw", Prix = 50 };
                //c.Produits.Add(p);
                //Commande Cm = new Commande() {IdCommande=1,Descriptions="Commandes",Prix=4000,Produit=p,ProduitId=p.IdProduit };
                //c.Commandes.Add(Cm);
                //c.SaveChanges();

                ////Modifier
                //Produit P= c.Produits.SingleOrDefault(s => s.IdProduit == 1);
                //P.Nom = "K";
                //P.Prix = 6;
                //Commande Cm = c.Commandes.SingleOrDefault(s => s.IdCommande == 1);
                //Cm.Descriptions = "Free";
                //Cm.Prix = 1200;
                //c.SaveChanges();

                ////Supprimer
                //Produit P = c.Produits.SingleOrDefault(s => s.IdProduit == 1);
                //c.Produits.Remove(P);
                //Commande Cm = c.Commandes.SingleOrDefault(s => s.IdCommande == 1);
                //c.Commandes.Remove(Cm);
                //c.SaveChanges();

                ////Afficher
                //foreach (var item in c.Produits.ToList())
                //{
                //    Console.WriteLine(item.IdProduit+"  "+item.Nom);
                //}
                //foreach (var item in c.Commandes.ToList())
                //{
                //    Console.WriteLine(item.IdCommande + "  " + item.Descriptions);
                //}

            }
            Console.ReadKey();
        }
    }
}
