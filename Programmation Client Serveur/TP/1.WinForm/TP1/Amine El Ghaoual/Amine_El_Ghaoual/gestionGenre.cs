using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amine_El_Ghaoual
{
    public class gestionGenre
    {
        public static List<Genre> lstgenre = new List<Genre>();

        public static int countId;

        public void Ajouter(Genre g)
        {
            g.id = ++countId;
            lstgenre.Add(g)
;
        }

        public bool Suprimer(int id)
        {
            Genre P = Recherche(id);
            if (P != null)
            {
                lstgenre.Remove(P);
                return true;
            }
            return false;

        }

        public bool Modifier(Genre p)
        {

            Genre g = Recherche(p.id);
            if (g != null)
            {
                g.type = p.type;
                return true;
            }
            return false;

        }

        public Genre Recherche(int id)
        {
            Genre P = lstgenre.SingleOrDefault(s => s.id == id);
            return P;
        }

        public List<Genre> afficher()
        {
            return lstgenre;
        }
    }
}
