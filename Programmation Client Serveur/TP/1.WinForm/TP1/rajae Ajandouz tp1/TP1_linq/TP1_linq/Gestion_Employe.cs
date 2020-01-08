using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_linq
{
    class Gestion_Employe
    {
        private static List<Employe> listEmploye = new List<Employe>();


        public static List<Employe> ListEdit { get => listEmploye; set => listEmploye = value; }

        public Gestion_Employe()
        {

        }
        public Employe Rechercher(Employe E)
        {
            return (from item in ListEdit
                    where item.Id == E.Id
                    select item).FirstOrDefault();
        }
        public void Ajouter(Employe E)
        {
            //  System.Windows.Forms.MessageBox.Show("Test");
            ListEdit.Add(new Employe { Id = E.Id, Nom = E.Nom, Prenom = E.Prenom, Adress= E.Adress });
            System.Windows.Forms.MessageBox.Show(ListEdit[0].Id.ToString());
        }
        public void Supprimer(Employe E)
        {
            ListEdit = ListEdit.Distinct().Where(X => X.Id != E.Id).ToList();
        }
        public void Modifier(Employe E)
        {
            ListEdit.Where(c => c.Id == E.Id).Select(c => { c.Nom = E.Nom; c.Prenom= E.Prenom; c.Adress = E.Adress; return c; }).ToList();
        }
        public List<Employe> Afficher()
        {

            List<Employe> mylinq = new List<Employe>(from E in listEmploye select E);
            return mylinq;
        }

    }
}
