using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3
{
  public  class Gestion_Editeurs
    {
      
        public List<Editeur> listEditeur { get; set; }
        public Gestion_Editeurs()
        {
            listEditeur= new List<Editeur>();
        }
        public int recherche(int id_Edit)
        {
            int trouve = 0;
            using (Gestion_EditeursEntities2 bib = new Gestion_EditeursEntities2())
            {

                List<Editeur> list_lv = bib.Editeurs.ToList();

                foreach (var item in list_lv)
                {
                    if (item.id == id_Edit)
                    {
                        trouve = 1;
                    }
                }
            }

            return trouve;

        }
        public void Ajouter(Editeur edt)
        {
            using (var context = new Gestion_EditeursEntities2())
            {
                context.Editeurs.Add(edt);
                context.SaveChanges();
            }
        }

        public void supprimer(int id)
        {

            using (Gestion_EditeursEntities2 bib = new Gestion_EditeursEntities2())
            {
                List<Editeur> list_edt = bib.Editeurs.ToList();
                int trouve = 0;
                foreach (var edt in list_edt)
                {
                    if (edt.id == id)
                    {
                        trouve = 1;
                        bib.Editeurs.Remove(edt);
                        bib.SaveChanges();

                    }
                }


                if (trouve != 0)
                {

                    Console.WriteLine("l'editeur a supprimer avec succes !!!!!!");
                }
                else
                {
                    Console.WriteLine("l'editeur supprimer deja !!!!!!", "erreur!!!!!");
                }

            }
        }
        public void modifier(Editeur ed)
        {

            using (Gestion_EditeursEntities2 bib = new Gestion_EditeursEntities2())
            {
                List<Editeur> list_edt = bib.Editeurs.ToList();

                foreach (var edt_modif in list_edt)
                {
                    if (edt_modif.id == ed.id)
                    {
                        edt_modif.Nom = ed.Nom;
                        edt_modif.categorie = ed.categorie;
                        edt_modif.id_livre= ed.id_livre;

                    }

                }
            }

        }
        public List<Editeur> Afficher()
        {
            List<Editeur> list_Editeur = new List<Editeur>();

            using (Gestion_EditeursEntities2 bib = new Gestion_EditeursEntities2())
            {
                List<Editeur> list_edt = bib.Editeurs.ToList();
                foreach (var item in list_edt)
                {
                        list_Editeur.Add(item);
                   
                }
            }
                return list_Editeur;
        }
    }
}
