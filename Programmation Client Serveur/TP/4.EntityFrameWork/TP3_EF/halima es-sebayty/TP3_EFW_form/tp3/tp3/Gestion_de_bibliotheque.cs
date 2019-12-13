using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3
{
    class Gestion_de_bibliotheque
    {


        public void Ajouter(editeur edt)
        {
            using (var context = new biblio_Entity_frameWorkEntities())
            {
                context.editeurs.Add(edt);
                context.SaveChanges();
            }
 
        }


        public int recherche(int id_livre)
        {
                int trouve = 0;
                using (biblio_Entity_frameWorkEntities bib = new biblio_Entity_frameWorkEntities())
                {

                    List<Livre> list_lv = bib.Livres.ToList();

                    foreach (var item in list_lv)
                    {
                        if (item.id == id_livre)
                        {
                            trouve = 1;
                        }
                    }
                }

            return trouve;

        }

        
        public List<Livre> Afficher(int id)
        {
            
            List<Livre> list_livre = new List<Livre>();

                using (biblio_Entity_frameWorkEntities bib = new biblio_Entity_frameWorkEntities())
                {

                    List<Livre> list_lv = bib.Livres.ToList();

                    foreach (var item in list_lv)
                    {
                        if (item.id == id)
                        {
                            list_livre.Add(item);
                        }
                    }
                }
            return list_livre;
        }


        public void supprimer(int id)
        {

            using (biblio_Entity_frameWorkEntities bib = new biblio_Entity_frameWorkEntities())
            {
                List<editeur> list_edt = bib.editeurs.ToList();
                int trouve = 0;
                foreach (var edt in list_edt)
                {
                    if (edt.id == id)
                    {
                        trouve = 1;
                        bib.editeurs.Remove(edt);
                        bib.SaveChanges();

                    }


                }


                if (trouve != 0)
                {

                    MessageBox.Show("l'editeur a supprimer avec succes !!!!!!");
                }
                else
                {
                    MessageBox.Show("l'editeur supprimer deja !!!!!!", "erreur!!!!!");
                }
                
            }

        }


        public void modifier(int id,int Id_LV)
        {

                using (biblio_Entity_frameWorkEntities bib = new biblio_Entity_frameWorkEntities())
                {
                    List<editeur> list_edt = bib.editeurs.ToList();

                    foreach (var edt_modif in list_edt)
                    {
                        if (edt_modif.id == id)
                        {
                            edt_modif.id_livre =Id_LV;

                        }

                    }
                }

        }


    }
}
