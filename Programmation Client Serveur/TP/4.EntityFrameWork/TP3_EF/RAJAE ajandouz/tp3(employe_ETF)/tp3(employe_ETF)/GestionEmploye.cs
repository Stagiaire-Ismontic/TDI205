using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3_employe_ETF_
{
    class GestionEmploye
    {
        public void Ajouter(Employe Em)
        {
            using (var context = new EmployeEntities())
            {
                context.Employes.Add(new Employe() { id = Em.id, Nom = Em.Nom, Prenom = Em.Prenom, Adress = Em.Adress });
                context.SaveChanges();
            }
        }
        public void supprimer(int id)
        {

            using (EmployeEntities EM = new EmployeEntities())
            {
                List<Employe> listEplm = EM.Employes.ToList();
                int trouve = 0;
                foreach (var em in listEplm)
                {
                    if (em.id == id)
                    {
                        trouve = 1;
                        EM.Employes.Remove(em);
                        EM.SaveChanges();
                        

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
        public void modifier(Employe E)
        {

            using (EmployeEntities bib = new EmployeEntities())
            {
                List<Employe> istEplm = bib.Employes.ToList();

                foreach (var em_mod in istEplm)
                {
                    if (em_mod.id == E.id)
                    {
                        em_mod.Nom = E.Prenom;
                        em_mod.Prenom = E.Prenom;
                        em_mod.Adress = E.Adress;


                    }

                }
            }

        }
        public List<Employe> Afficher()
        {
            List<Employe> listEplm = new List<Employe>();

            using (EmployeEntities bib = new EmployeEntities())
            {
                List<Employe> list_edt = bib.Employes.ToList();
                foreach (var item in list_edt)
                {
                    listEplm.Add(item);

                }
            }
            return listEplm;
        }
        public int recherche(int idE)
        {
            int trouve = 0;
            using (EmployeEntities ME = new EmployeEntities())
            {
                List<Employe> listEmp = ME.Employes.ToList();

                foreach (var item in listEmp)
                {
                    if (item.id == idE)
                    {
                        trouve = 1;
                    }
                }
            }

            return trouve;

        }
    }
}
