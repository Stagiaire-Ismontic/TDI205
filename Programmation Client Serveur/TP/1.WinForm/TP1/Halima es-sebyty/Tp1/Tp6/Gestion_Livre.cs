using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6
{
  public  class Gestion_Livre
    {
        private static List<Livre> listLivre = new List<Livre> ();

        public  List<Livre> ListLivre
        {
            get
            {
                return listLivre;
            }

            set
            {
                listLivre = value;
            }
        }

        public Gestion_Livre()
        {
    
        }
        public Livre Rechercher(Livre E)
        {
            return (from item in listLivre
                    where item.Id == E.Id
                    select item).FirstOrDefault();
        }
        public void Ajouter(Livre livre)
        {
            //  System.Windows.Forms.MessageBox.Show("Test");
            listLivre.Add( new Livre { Id= livre.Id,  Titre= livre.Titre,Categorie= livre.Categorie} );
            System.Windows.Forms.MessageBox.Show(listLivre[0].Id.ToString());
        }
        public void Supprimer(Livre livre)
        {
            listLivre = listLivre.Distinct().Where(X => X.Id != livre.Id).ToList();
        }
        public void Modifier(Livre livre)
        {
            listLivre.Where(c => c.Id == livre.Id).Select(c => { c.Titre= livre.Titre; c.Categorie = livre.Categorie; return c; }).ToList();
        }
        public List<Livre> Afficher()
        {
          
            List<Livre> mylinq =new List<Livre> ( from E in listLivre select E); 
            return mylinq;
        }
 
    }
}
