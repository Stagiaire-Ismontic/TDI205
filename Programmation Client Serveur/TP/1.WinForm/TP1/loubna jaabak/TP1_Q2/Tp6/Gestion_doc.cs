using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6
{
  public  class Gestion_doc
    {
        private static List<document> listb_doc = new List<document> ();

        internal  List<document> Listdoc { get => listb_doc; set => listb_doc = value; }

        public Gestion_doc()
        {
    
        }
        public document Rechercher(document doc)
        {
            return (from item in Listdoc
                    where item.id == doc.id
                    select item).FirstOrDefault();
        }
        public void Ajouter(document doc)
        {
            //  System.Windows.Forms.MessageBox.Show("Test");
            Listdoc.Add( new document { id= doc.id,  nom= doc.nom, type= doc.type } );
            System.Windows.Forms.MessageBox.Show(Listdoc[0].id.ToString());
        }
        public void Supprimer(document doc)
        {
            Listdoc = Listdoc.Distinct().Where(X => X.id != doc.id).ToList();
        }
        public void Modifier(document doc)
        {
            Listdoc.Where(c => c.id == doc.id).Select(c => { c.nom= doc.nom; c.nom = doc.nom; return c; }).ToList();
        }
        public List<document> Afficher()
        {
            List<document> mylinq =new List<document> ( from E in Listdoc  select E); 
            return mylinq;
        }
    }
}
