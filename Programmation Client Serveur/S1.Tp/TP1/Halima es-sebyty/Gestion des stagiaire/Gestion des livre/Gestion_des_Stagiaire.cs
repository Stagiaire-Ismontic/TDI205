using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Gestion_des_livre
{
    class Gestion_des_Stagiaire
    {
        
       private static int nbStag;
        public static List<Stagiaire> list_stagiaire = new List<Stagiaire>();

        public  List<Stagiaire> List_stagiaire
        {
            get
            {
                return list_stagiaire;
            }

            set
            {
                list_stagiaire = value;
            }
        }

        public int Ajouter(Stagiaire stg)
        {
            if(stg.Id!=0)
            {

                throw new Exception("Fait attention le Stagiaire est existe deja !!!!");
            }
            else
            {
                stg.Id = ++ Gestion_des_Stagiaire.nbStag;
                list_stagiaire.Add(stg);

            }
            return stg.Id;
        }

// cette methode permetent de return la liste de touts les livres
        public List<Stagiaire> GetStagiaire()
        {
            return list_stagiaire;
        }


         public Stagiaire Rechercher(int id)
          {
             foreach(var Stag in list_stagiaire)
              {
                if (Stag.Id == id)
                    return Stag;

               }
            return null;
          }


          public void Supprimer(int id)
           {
              Stagiaire stg = this.Rechercher(id);
            list_stagiaire.Remove(stg);

            
             }

         
          public void modifier(Stagiaire stg)
          {
             if(stg.Id==0)
            
                throw new Exception("fait attention de livre n'existe pas !!");
            
            Stagiaire S = this.Rechercher(stg.Id);
            //methode 111
              S.Nom = stg.Nom;
              S.Prenom = stg.Prenom;
              S.Groupe = stg.Groupe;

            //methode 2222

           // List_livre.Insert(List_livre.IndexOf(l), lv);

           } 
    //// les methode suivant precedant debute fin

          public Stagiaire Precedant(int id)
          {
            Stagiaire stg = this.Rechercher(id);

            int index = list_stagiaire.IndexOf(stg);

            if ((list_stagiaire.Count - 1) >= (index - 1))
            {
                return list_stagiaire[index - 1];

            }
            else
            {
                return null;
            }
        }
    
        public Stagiaire Suivant(int id)
        {
            Stagiaire stg = this.Rechercher(id);
            int index = list_stagiaire.IndexOf(stg);
            if((list_stagiaire.Count-1)>=(index+1))
            {
                return list_stagiaire[index + 1];

            }
            else
            {
                return null;
            }
        }

        public Stagiaire Debut()
        {
            if (list_stagiaire.Count > 0)
            {
                return list_stagiaire[0];

            }
            else
            {
                return null;
            }

        }

        public Stagiaire Fin()
        {

            if (list_stagiaire.Count >0)
            {
                return list_stagiaire[list_stagiaire.Count -1];

            }
            else
            {
                return null;
            }
          
        }


    }
}
