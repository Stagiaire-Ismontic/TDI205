using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bib=new biblio_Entity())
            {
              ////Ajouiter un nouveau editeur

                Console.WriteLine("Entez l'id d'editeur ");
                var id = Console.ReadLine();
                Console.WriteLine("Entez le nom d'editeur ");
                var name = Console.ReadLine();
                Console.WriteLine("Entez le prenom d'editeur ");
                var last_name = Console.ReadLine();
                Console.WriteLine("Entez le numero d'inscription d'editeur ");
                var nb_inscp = Console.ReadLine();
                Console.WriteLine("Entez l'id  de livre ");
                var id_lv = Console.ReadLine();

                var edit = new editeur { id=int.Parse(id),nom=name,prenom=last_name,numero_inscription=int.Parse(nb_inscp),id_livre=int.Parse(id_lv)};

                bib.editeurs.Add(edit);
                bib.SaveChanges();

     
            }


            using (var bib = new biblio_Entity())
            {

                ////Afficher l'editeur

                var query = from edt in bib.editeurs orderby edt.nom select edt;

                Console.WriteLine("les editeur de Data Base ");

                foreach (var item in query)
                {
                    Console.WriteLine(item.ToString());

                }

            }


            using (var bib = new biblio_Entity())
            {

                //// Modifier d'editeur
                Console.WriteLine("Entez l'id d'editeur ");
                var id = Console.ReadLine();

                var query = from edt in bib.editeurs  select edt;

                foreach (var edt in query)
                {
                    if(edt.id==int.Parse(id))
                    {

                        Console.WriteLine("Entez le nom d'editeur ");
                        edt.nom = Console.ReadLine();
                        Console.WriteLine("Entez le prenom d'editeur ");
                        edt.prenom = Console.ReadLine();

                        Console.WriteLine(edt.ToString());
                    }

                }

            }

            using (var bib = new biblio_Entity())
            {

                //// supprimer d'editeur
                Console.WriteLine("Entez l'id d'editeur ");
                var id = Console.ReadLine();

                var query = from edt in bib.editeurs select edt;

                foreach (var edt in query)
                {
                    if (edt.id == int.Parse(id))
                    {

                        bib.editeurs.Remove(edt);
                    }

                }

            }



            using (var bib = new biblio_Entity())
            {

                ////Afficher l'editeur

                var query = from edt in bib.editeurs orderby edt.nom select edt;

                Console.WriteLine("les editeur de Data Base ");

                foreach (var item in query)
                {
                    Console.WriteLine(item.ToString());

                }

            }


            Console.ReadKey();
        }
    }
}
