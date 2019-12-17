using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6
{
  public  class Gestion_Biblio
    {
        private static List<bibliotheque> listbib = new List<bibliotheque> ();

        public  List<bibliotheque> Listbib
        {
            get
            {
                return listbib;
            }

            set
            {
                listbib = value;
            }
        }

        public Gestion_Biblio()
        {
    
        }
        public bibliotheque Rechercher(bibliotheque bib)
        {
            return (from item in Listbib
                    where item.id == bib.id
                    select item).FirstOrDefault();
        }
        public void Ajouter(bibliotheque bib)
        {
            //  System.Windows.Forms.MessageBox.Show("Test");
            Listbib.Add( new bibliotheque { id= bib.id,  nom= bib.nom, id_livre= bib.id_livre } );
            System.Windows.Forms.MessageBox.Show(Listbib[0].id.ToString());
        }
        public void Supprimer(bibliotheque bib)
        {
            Listbib = Listbib.Distinct().Where(X => X.id != bib.id).ToList();
        }
        public void Modifier(bibliotheque bib)
        {
            Listbib.Where(c => c.id == bib.id).Select(c => { c.nom= bib.nom; c.id_livre = bib.id_livre; return c; }).ToList();
        }
        public List<bibliotheque> Afficher()
        {
          
            List<bibliotheque> mylinq =new List<bibliotheque> ( from E in Listbib select E); 
            return mylinq;
        }
 
    }
}
