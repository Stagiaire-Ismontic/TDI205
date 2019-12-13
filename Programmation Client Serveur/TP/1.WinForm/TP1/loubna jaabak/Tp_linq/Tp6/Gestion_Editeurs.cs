using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6
{
  public  class Gestion_Editeurs
    {
        private static List<Editeur> listEdit = new List<Editeur> ();


        public static List<Editeur> ListEdit { get => listEdit; set => listEdit = value; }

        public Gestion_Editeurs()
        {
    
        }
        public Editeur Rechercher(Editeur E)
        {
            return (from item in ListEdit
                    where item.Id == E.Id
                    select item).FirstOrDefault();
        }
        public void Ajouter(Editeur E)
        {
          //  System.Windows.Forms.MessageBox.Show("Test");
            ListEdit.Add( new Editeur{Id=E.Id,  Nom=E.Nom,Categorie= E.Categorie} );
            System.Windows.Forms.MessageBox.Show(ListEdit[0].Id.ToString());
        }
        public void Supprimer(Editeur E)
        {
            ListEdit = ListEdit.Distinct().Where(X => X.Id != E.Id).ToList();
        }
        public void Modifier(Editeur E)
        {
            ListEdit.Where(c => c.Id == E.Id).Select(c => { c.Nom = E.Nom; c.Categorie = E.Categorie; return c; }).ToList();
        }
        public List<Editeur> Afficher()
        {
          
            List<Editeur> mylinq =new List<Editeur> ( from E in ListEdit  select E); 
            return mylinq;
        }
 
    }
}
