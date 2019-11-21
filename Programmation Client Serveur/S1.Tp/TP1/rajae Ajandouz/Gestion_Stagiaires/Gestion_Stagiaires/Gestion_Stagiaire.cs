using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stagiaires
{
    class Gestion_Stagiaire
    {
        private static int nbStag;
        public static List<Stagaire> list_Stagiaire = new List<Stagaire>();

        public List<Stagaire> List_Stagiaire
        {
            get
            {
                return list_Stagiaire;
            }

            set
            {
                list_Stagiaire = value;
            }
        }

        public int Ajouter( Stagaire Sg)
        {
            if (Sg.Id !=0)
            {

                throw new Exception("Fait attention le Stagaire est existe deja !!!!");
            }
            else
            {
                Sg.Id = ++Gestion_Stagiaire.nbStag;
                List_Stagiaire.Add(Sg);

            }
            return Sg.Id;
        }

        // cette methode permetent de return la liste de touts les livres
        public List<Stagaire> GetStagiaire()
        {
            return List_Stagiaire;
        }


        public Stagaire Rechercher(int id)
        {
            foreach (var item in List_Stagiaire)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }


        public void Supprimer(int id)
        {
            Stagaire lv = this.Rechercher(id);
            List_Stagiaire.Remove(lv);


        }


        public void modifier(Stagaire Sg)
        {
            if (Sg.Id == 0)

                throw new Exception("fait attention de livre n'existe pas !!");

            Stagaire S= this.Rechercher(Sg.Id);
            
            S.nom = Sg.nom;
            S.nom = Sg.prenom;
            S.prenom = Sg.Tel;
            S.Email = Sg.Email;
            S.Datenais = Sg.Datenais;
           

        

        }
        //// les methode suivant precedant debute fin

        public Stagaire Precedant(int id)
        {
            Stagaire sg = this.Rechercher(id);
            int index = list_Stagiaire.IndexOf(sg);
            if ((list_Stagiaire.Count - 1) >= (index - 1))
            {
                return list_Stagiaire[index - 1];

            }
            else
            {
                return null;
            }
        }

        public Stagaire Suivant(int id)
        {
             Stagaire Sg = this.Rechercher(id);
            int index = list_Stagiaire.IndexOf(Sg);
            if ((list_Stagiaire.Count - 1) >= (index + 1))
            {
                return list_Stagiaire[index + 1];

            }
            else
            {
                return null;
            }
        }

        public Stagaire Debut()
        {
            if (list_Stagiaire.Count > 0)
            {
                return list_Stagiaire[0];

            }
            else
            {
                return null;
            }

        }

        public Stagaire Fin()
        {

            if (list_Stagiaire.Count > 0)
            {
                return list_Stagiaire[list_Stagiaire.Count - 1];

            }
            else
            {
                return null;
            }

        }


    }
}
