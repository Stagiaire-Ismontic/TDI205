using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace many
{
  public   class GestionEntreprise
    {
        public static List<Entreprise> List = new List<Entreprise>();

        public void Ajouter(Entreprise e)
        {

            List.Add(e);

        }

        public List<Entreprise> Afficher()
        {
            return List;
        }

    }
}
