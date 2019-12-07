using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    class GestionEtudiant
    {
        private  List<Etudiant> ls = new List<Etudiant>();

        public  List<Etudiant> Ls { get => ls; set => ls = value; }

        public Etudiant Rechercher(int id)
        {
            foreach (var Stag in Ls)
            {
                if (Stag.Id == id)
                    return Stag;

            }
            return null;
        }
        public void ajouter(Etudiant a)
        { 
            Ls.Add(a);
        }
       public void Supprimer(int id)
       {
          Etudiant stg = this.Rechercher(id);
         Ls.Remove(stg);


       }

        public void modifier(Etudiant stg)
        {
            if (stg.Id <= 0)
                throw new Exception("fait attention Etudiant n'existe pas !!");

            Etudiant S = this.Rechercher(stg.Id);
            if (S != null)
            {
                S = stg;
            } else throw new Exception("fait attention Etudiant n'existe pas !!");
            //methode 111

        }

}
}
