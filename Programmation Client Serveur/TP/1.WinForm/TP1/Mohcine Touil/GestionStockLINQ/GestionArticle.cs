using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStockLINQ
{
    class GestionArticle
    {
        static List<Article> liste = new List<Article>();
        
        public Article Rechercher(Article a)
        {
            return (from i in liste where i.Code_article == a.Code_article select i).FirstOrDefault();
        }

        public List<Article> RechercherParObjet(Article a)
        {
            List<Article> lst = new List<Article>();
            Article A = Rechercher(a);
            if(A!=null)
            {
                lst.Add(A);
                return lst;
            }
            return null;
        }
        public bool Ajouter(Article a)
        {
            if (Rechercher(a) != null)
                return false;
            liste.Add(new Article { Code_article = a.Code_article, Designation = a.Designation, Prix_U = a.Prix_U, Quantite = a.Quantite });
            return true;
        }

        public bool Supprimer(Article a)
        {
            liste = liste.Distinct().Where(i => i.Code_article != a.Code_article).ToList();
            return true;
        }

        public bool Modifier(Article a)
        {
            liste.Where(i => i.Code_article == a.Code_article).Select(i => { i.Designation = a.Designation; i.Prix_U = a.Prix_U; i.Quantite = a.Quantite;return i; }).ToList();
            return true;
        }

        public List<Article> Afficher()
        {
            List<Article> lst = new List<Article>(from i in liste select i);
            return lst;
        }
    }
}
