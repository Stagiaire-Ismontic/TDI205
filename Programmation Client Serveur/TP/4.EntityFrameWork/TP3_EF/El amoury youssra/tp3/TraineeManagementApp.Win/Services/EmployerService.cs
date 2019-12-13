using CrudWin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudWin.Services
{
    public class EmployerService
    {
        private static List<Employer> Data_Employer = new List<Employer>();

        static EmployerService() {
            Data_Employer.Add(new Employer(1, "Madani","hhhh"));
            Data_Employer.Add(new Employer(2,"Chami","hhhhhk"));
        }

        /// <summary>
        /// Add new Group
        /// </summary>
        /// <param name="g"> le Groupe à ajouter</param>
        public void Add(Employer g) {
            Data_Employer.Add(g);
        }

        /// <summary>
        /// Supprimer un groupe par Id
        /// </summary>
        /// <param name="id"> Id de groupe à supprimer</param>
        public void Delete(int id) {

            Employer g = null;
            foreach (var item in Data_Employer)
            {
                if (item.Id == id) {
                    // Exception : on ne peut pas supprimer un objet de la List en utilisant la boucle foreach
                    g = item;
                }
            }
            Data_Employer.Remove(g);
        }

        /// <summary>
        /// Mise à jour un objet Groupe
        /// </summary>
        /// <param name="g">un objet de type groupe contenant les information à mettre à jour</param>
        public void Update(Employer g) {
            foreach (var item in Data_Employer)
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
        public List<Employer> FindAll() {
            return Data_Employer;
        }
    }
}
