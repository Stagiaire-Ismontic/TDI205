using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ajouter un editeur 
                using (var context = new biblio_Entity_frameWorkEntities())
                {
                    var edit = new editeur
                    {
                        id = 8,
                        nom = "hh",
                        prenom = "hh",
                        numero_inscription = 1,
                        id_livre = 4

                    };
                    context.editeurs.Add(edit);
                    context.SaveChanges();
                }

            // ajouter un livre 
            using (var context = new biblio_Entity_frameWorkEntities())
                {
                    var livre = new Livre
                    {
                        id = 17,
                        titre = "l5",
                        categorie = "l5"


                    };
                    context.Livres.Add(livre);
                    context.SaveChanges();
                }




   //// methode de supprition ==>>> pour supprimer un editeur

            using (var context= new biblio_Entity_frameWorkEntities())
            {

                var Edit = context.editeurs.SingleOrDefault(EE=>EE.id==1);
                context.editeurs.Remove(Edit);
                Console.WriteLine($"\n\nla supprission termain avec succes");
                context.SaveChanges();
                
            }

  //// methode de supprition ==>>> pour supprimer un Livre

            using (var context = new biblio_Entity_frameWorkEntities())
            {

                var lv= context.Livres.SingleOrDefault(ll => ll.id == 6);
                context.Livres.Remove(lv);
                Console.WriteLine($"\n\nla supprission termain avec succes");
                context.SaveChanges();

            }

///methode de modification ===>modifier livre

            using (var context = new biblio_Entity_frameWorkEntities())
            {
                var lv = context.Livres.SingleOrDefault(ll => ll.id == 3); ;
                
                lv.id = 16;
                lv.titre = "l15";
                lv.categorie = "l15";

                context.SaveChanges();
            }


  ///methode de modification ===>modifier editeur

            using (var context = new biblio_Entity_frameWorkEntities())
            {
                var ed = context.editeurs.SingleOrDefault(ll => ll.id == 3); ;

                ed.id = 16;
                ed.nom = "hh";
                ed.prenom = "hh";
                ed.numero_inscription = 11;
                ed.id_livre = 14;

                context.SaveChanges();
            }



            //////methode a'afficher editeur

            Console.WriteLine("\t les informations d'editeur \n");

            using (biblio_Entity_frameWorkEntities bib = new biblio_Entity_frameWorkEntities())
            {

                List<editeur> list_edit = bib.editeurs.ToList();

                foreach (var item in list_edit)
                {

                    Console.WriteLine(item.ToString());
                }
            }


            //////methode a'afficher Livre

            Console.WriteLine("\n\t les informations de livre \n");

            using (biblio_Entity_frameWorkEntities bib = new biblio_Entity_frameWorkEntities())
            {

                List<Livre> list_livre = bib.Livres.ToList();

                foreach (var item in list_livre)
                {

                    Console.WriteLine(item.ToString());
                }
            }






            Console.ReadKey();



        }
    }
}
