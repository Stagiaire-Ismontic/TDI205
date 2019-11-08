using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppGestionStagiaires.PackageGroupe
{
    public class GestionGroupes
    {
        private static List<Groupe> ListeGroupe = new List<Groupe>();

        static GestionGroupes() {
            ListeGroupe.Add(new Groupe(1, "Madani"));
            ListeGroupe.Add(new Groupe(2,"Chami"));
        
        }

        /// <summary>
        /// Ajouter un groupe 
        /// </summary>
        /// <param name="g"> le Groupe à ajouter</param>
        public static void Ajouter(Groupe g) {
            ListeGroupe.Add(g);
        }

        /// <summary>
        /// Supprimer un groupe par Id
        /// </summary>
        /// <param name="id"> Id de groupe à supprimer</param>
        public static void Supprimer(int id) {

            Groupe g = null;
            foreach (var item in ListeGroupe)
            {
                if (item.Id == id) {
                    // Exception : on ne peut pas supprimer un objet de la List en utilisant la boucle foreach
                    g = item;
                }
            }
            ListeGroupe.Remove(g);
        }

        /// <summary>
        /// Mise à jour un objet Groupe
        /// </summary>
        /// <param name="g">un objet de type groupe contenant les information à mettre à jour</param>
        public static void MiseAJour(Groupe g) {
            foreach (var item in ListeGroupe)
            {
                if (item.Id == g.Id)
                {
                    item.Nom = g.Nom;
                }
            }
        }
        /// <summary>
        /// Retourne la liste des groupes à afficher
        /// </summary>
        /// <returns></returns>
        public static List<Groupe> Afficher() {
            return ListeGroupe;
        }
    }
}
