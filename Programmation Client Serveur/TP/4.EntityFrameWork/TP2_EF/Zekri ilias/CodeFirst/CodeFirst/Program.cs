using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c=new ModelGestion())
            {
                ////Ajouter
                //Produit P = new Produit(1, "Kawkw", 10);
                //c.ListeProduit.Add(P);
                //Commande Cm = new Commande(1, "Free", 20, P);
                //c.ListeCommande.Add(Cm);
                //c.SaveChanges();

                ////Modifier
                //Produit P= c.ListeProduit.SingleOrDefault(s=>s.ProduitId==1);
                //P.Prix = 50;
                //Commande Cm = c.ListeCommande.SingleOrDefault(s=>s.CommandeId==1);
                //Cm.Prix = 100;
                //c.SaveChanges();

                ////Supprimer
                //Produit P = c.ListeProduit.SingleOrDefault(s => s.ProduitId == 1);
                //c.ListeProduit.Remove(P);
                //Commande Cm = c.ListeCommande.SingleOrDefault(s => s.CommandeId == 1);
                //c.ListeCommande.Remove(Cm);
                //c.SaveChanges();

                ////Afficher
                //foreach (var item in c.ListeProduit)
                //{
                //    Console.WriteLine(item.ProduitId+"  "+item.Nom+"  "+item.Prix);
                //}
                //foreach (var item in c.ListeCommande)
                //{
                //    Console.WriteLine(item.CommandeId + "  " + item.Descriptions + "  " + item.Prix+"  "+item.Produit);
                //}
            }
            Console.ReadKey();
        }
    }
}
