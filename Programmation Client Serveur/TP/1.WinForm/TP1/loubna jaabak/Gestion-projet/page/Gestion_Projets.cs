using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page
{
 public   class Gestion_Projets
    {
        static List<Projet> et = new List<Projet>();

        private static int numero_Editeur;

        public  List<Projet> Et
        {
            get
            {
                return et;
            }

            set
            {
                et = value;
            }
        }

        public int Ajouter(Projet p)
        {
            if (p.ID1 == 0)
            {
                throw new Exception("Impossible d'ajouter un editeur deja exist ");
            }
            else
            {
                p.ID1 = ++Gestion_Projets.numero_Editeur;
               p.DateCreation1 = DateTime.Now;
                Et.Add(p);
            }
            return p.ID1;
        }
        public Projet rechercher(int x)
        {
            foreach (var i in Et)
            {
                if (i.ID1 == x)
                    return i;    
            }
            return null;
        }
        public  List<Projet>liste ()
            {
            return Et;
            
            }
        public void Supprimer(int id)
        {
            Projet t = this.rechercher(id);
            Et.Remove(t);
        }
        public void Modifier(Projet pp)
        {
            if (pp.ID1 == 0)
                throw new Exception("vous essayez de modifier!!");
            Projet tt = this.rechercher(pp.ID1);
            /*
             * //methode:1
            e.ID1 = editeur.ID1;
            e.NOM1 = editeur.NOM1;
            e.PRENOM1 = editeur.PRENOM1;*/
            /*methode :2
             */
            pp.DateModification1 = DateTime.Now;
            Et.Insert(Et.IndexOf(tt), pp);
         }
        public List<Projet> getProjet()
        {
            return Et;
        }
        public Projet debut()
        {
            if (Et.Count > 0)
            {
                return Et[0];
            }
            return null;
        }
        public Projet suivant(int id)
        {
            Projet pt = this.rechercher(id);
            int index = Et.IndexOf(pt);
            if ((Et.Count - 1) >= (index + 1))
                return Et[index + 1];
            else
            return null;
        }
        public Projet precedent(int id)
        {
            Projet t = this.rechercher(id);
            int index = Et.IndexOf(t);
            if ((Et.Count - 1) >= (index - 1)&& ( index>0))
                return Et[index - 1];
            else
            return null;
        }
        public Projet fin()
        {
            
            if (Et.Count > 0)
                return Et[Et.Count-1];
            else
            return null;
        }
    }
}
