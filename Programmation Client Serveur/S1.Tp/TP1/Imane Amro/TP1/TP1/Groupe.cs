using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Groupe

    {
        string NomG;

        public string NomG1
        {
            get
            {
                return NomG;
            }

            set
            {
                NomG = value;
            }
        }
        List<stagiare> ls = new List<stagiare>();
        public stagiare Rechercher(int id)
        {
            foreach (var Stag in ls)
            {
                if (Stag.Id == id)
                    return Stag;

            }
            return null;
        }
        public void ajouter(stagiare a)
        {
            ls.Add(a);
        }
        public void Supprimer(int id)
        {
            stagiare stg = this.Rechercher(id);
            ls.Remove(stg);


        }
        public void modifier(stagiare stg)
        {
            if (stg.Id == 0)

                throw new Exception("fait attention de livre n'existe pas !!");

            stagiare S = this.Rechercher(stg.Id);
            //methode 111
            S.Nom = stg.Nom;
            S.Prenom = stg.Prenom;

        }
    }
}

