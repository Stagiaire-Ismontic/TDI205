using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ajouter un Stagaire dans la base de donneee GestionStagaire
            //using (var context = new GestionStagaireEntities())
            //{
            //    var std = new  Stagaire()
            //    {
            //        id = 6,
            //        nom = "Gogo",
            //        cin= "S098761"
            //    };
            //    context.Stagaire.Add(std);
            //    context.SaveChanges();
            //}

            //Modifier Premiere Stagaire dans la base de donnee
            //using (var context = new GestionStagaireEntities())
            //{
            //    var std = context.Stagaire.First<Stagaire>();
            //    std.nom = "Sousou";
            //    context.SaveChanges();
            //}

            //Supprimer Premiere Stagaire dans la base de donnee
            //using (var context = new GestionStagaireEntities())
            //{
            //    var std = context.Stagaire.First<Stagaire>();
            //    context.Stagaire.Remove(std);
            //    context.SaveChanges();
            //}

            //Afficher Table Stagaire
            using (GestionStagaireEntities db = new GestionStagaireEntities())
            {
                var liststagaire = db.Stagaire.ToList();
                foreach (var item in liststagaire)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }

        }
    }
}
