using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Editeur
{
    class Program
    {
        static void Main(string[] args)
        {
            //ajouter editeur
            //using (var context = new Gestion_EditeursEntities())
            //{
            //    var item = new Editeur
            //    {
            //        id = 9,
            //        nom = "ddddddd",
            //        categorie = "Roman"
            //    };
            //    context.Editeurs.Add(item);

            //   // context.SaveChanges();
            //}
            ////ajouter livre
            //using (var context = new Gestion_EditeursEntities())
            //{
            //    var item = new Livre
            //    {
            //        id =2 ,
            //        Titre = "boite a merveille",
            //        Categorie = "Roman",
            //        idEdit=2
            //    };
            //    context.Livres.Add(item);

            //    context.SaveChanges();

            //}
            //Modifier Editeur
            using (var context = new Gestion_EditeursEntities())
            {
                var std = context.Editeurs.SingleOrDefault(JJ=>JJ.id==6);
                std.nom = "khaled";
                context.SaveChanges();
            }
            //Modifier Livre
            using (var context = new Gestion_EditeursEntities())
            {
                var std = context.Livres.SingleOrDefault(kk=>kk.id==1);
                std.Titre = "Antigone";
                //std.Titre = "Le monde du bout du monde ";
                context.SaveChanges();
            }
            ////supprimer editeur
            using (var context = new Gestion_EditeursEntities())
            {
                var Edit = context.Editeurs.SingleOrDefault(EE => EE.id == 2);
                context.Editeurs.Remove(Edit);
                Console.WriteLine($"vous avez suprimer avec succes l'editeur : {Edit.id} {Edit.nom} {Edit.categorie}");
                context.SaveChanges();
            }
            ////supprimer Livres

            //using (var context = new Gestion_EditeursEntities())
            //{
            //    var livre = context.Livres.SingleOrDefault(ll => ll.id == 2);
            //    context.Livres.Remove(livre);
            //    Console.WriteLine($"vous avez suprimer avec succes le livre : {livre.id} {livre.Titre} {livre.Categorie} {livre.idEdit}");
            //    context.SaveChanges();
            //}
            using (Gestion_EditeursEntities ee = new Gestion_EditeursEntities())
            {
                List<Editeur> listEditeur = ee.Editeurs.ToList();
                foreach (var item in listEditeur)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("**************************");
                List<Livre> listLivre = ee.Livres.ToList();
                foreach (var item in listLivre)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.ReadLine();
            }
        }
    }
}
