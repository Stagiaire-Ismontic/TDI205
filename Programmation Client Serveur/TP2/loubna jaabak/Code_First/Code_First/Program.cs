using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ajouter
            using (var db = new Gestion_Editeur())
            {
                Console.WriteLine("Entrer ID");
                var id = Console.ReadLine();
                Console.WriteLine("Entrer Nom");
                var name = Console.ReadLine();
                Console.WriteLine("Entrer Categorie");

                var categorie = Console.ReadLine();
                Console.WriteLine("Entrer ID_livre");

                var idedit = Console.ReadLine();
                var edit = new Editeur { id = int.Parse(id), categorie = categorie, nom = name, id_livre = int.Parse(idedit) };
                db.Editeurs.Add(edit);
                db.SaveChanges();
             
            }

            //Afficher
            using (var db=new Gestion_Editeur())
            {

                //display all editeurs from the database
                var query = from b in db.Editeurs orderby b.id select b;
                Console.WriteLine("All Editors in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            //Modifier
            using (var db = new Gestion_Editeur())
            {

                Console.WriteLine("Entrer ID");
                var id = Console.ReadLine();
                var query =  from b in db.Editeurs select b;

                foreach (var ed in query)
                {

                    if (ed.id==int.Parse(id))
                    {
                        Console.WriteLine("Entrer Nom");
                        var name = Console.ReadLine();
                        Console.WriteLine("Entrer Categorie");

                        var categorie = Console.ReadLine();
                        Console.WriteLine("Entrer ID_livre");

                        var idedit = Console.ReadLine();
                        Console.WriteLine(ed.ToString());
                    }
                }

            }


            //Supprimer
            using (var db = new Gestion_Editeur())
            {

                Console.WriteLine("Entrer ID");
                var id = Console.ReadLine();
                var query = from b in db.Editeurs select b;

                foreach (var ed in query)
                {

                    if (ed.id == int.Parse(id))
                    {
                        Console.WriteLine("Entrer Nom");
                        var name = Console.ReadLine();
                        Console.WriteLine("Entrer Categorie");

                        var categorie = Console.ReadLine();
                        Console.WriteLine("Entrer ID_livre");

                        var idedit = Console.ReadLine();
                        db.Editeurs.Remove(ed);
                        Console.WriteLine(ed.ToString());
                    }
                }

            }



            Console.ReadLine();
            
        }
    }
}
