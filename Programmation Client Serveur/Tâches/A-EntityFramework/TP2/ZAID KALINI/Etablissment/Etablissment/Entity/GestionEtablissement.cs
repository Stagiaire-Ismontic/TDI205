using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etablissment.Entity
{
    class GestionEtablissement
    {
        AppContext EContext = new AppContext();
        public bool Ajouter(Formateur formateur)
        {
            if (formateur != null) { EContext.Formateur.Add(formateur); EContext.SaveChanges(); return true; }
            return false;
        }
        public bool Modifier(Formateur Newformateur, int id)
        {
            if (Newformateur != null && id != 0)
            {
                var fr = EContext.Formateur.SingleOrDefault(form => form.Id == id);
                fr = Newformateur;
                EContext.SaveChanges();
                return true;

            }
            return false;
        }
        public bool Suprimer(int id)
        {
            var formateur = EContext.Formateur.SingleOrDefault(f => f.Id == id);
            if (formateur != null) { EContext.Formateur.Remove(formateur); EContext.SaveChanges(); return true; }
            return false;
        }
        public List<Formateur> Afficher()
        {
            return EContext.Formateur.ToList();
        }

    }
}

