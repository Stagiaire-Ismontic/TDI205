using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock
{
    class GestionArticle
    {
        static List<Article> liste = new List<Article>();

        public int Rechrcher(int id)
        {
            foreach(var item in liste)
            {
                if (item.Code_article == id)
                    return 1;
            }
            return 0;
        }

        public List<Article> RechrcherParObjet(Article a)
        {
            foreach (var item in liste)
            {
                if (item.Code_article == a.Code_article)
                {
                    List<Article> lst = new List<Article>();
                    lst.Add(item);
                    System.Windows.Forms.MessageBox.Show("Article a disponible");
                    return lst;
                }
            }
            System.Windows.Forms.MessageBox.Show("Article nexiste pas");
            return liste;
        }

        public bool Ajouter(Article a)
        {
            if (Rechrcher(a.Code_article) == 0)
            {
                liste.Add(a);
                System.Windows.Forms.MessageBox.Show("Article a Ajouter");
                return true;
            }
            return false;
        }

        public List<Article> Afficher()
        {
            return liste;
        }

        public bool Modifier(Article a)
        {
            foreach(var item in liste)
            {
                if (item.Code_article == a.Code_article)
                {
                    item.Designation = a.Designation;
                    item.Prix_U = a.Prix_U;
                    item.Quantite = a.Quantite;
                    System.Windows.Forms.MessageBox.Show("Article a Modifier");
                    return true;
                }
            }
            return false;
        }

        public bool Supprimer(Article a)
        {
            foreach(var item in liste)
            {
                if(item.Code_article==a.Code_article)
                {
                    liste.Remove(item);
                    System.Windows.Forms.MessageBox.Show("Article a Supprimer");
                    return true;
                }
            }
            return false;
        }


    }
}
