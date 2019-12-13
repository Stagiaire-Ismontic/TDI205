using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidKaliniEF.Entity
{
    class GestionEtablissment
    {
        EtablissementEntities EContext = new EtablissementEntities();
        public bool Ajouter(Formateur formateur)
        {
            if (formateur != null) { EContext.Formateur.Add(formateur); EContext.SaveChanges(); return true; }
            return false;
        }
        public bool Modifier(Formateur Newformateur, int id)
        {
            if (Newformateur != null && id!=0) {
                var fr = EContext.Formateur.SingleOrDefault(form => form.IdFormateur == id);
                fr = Newformateur;
                EContext.SaveChanges();
                return true;

            }
            return false;
        }
        public bool Suprimer(int id)
        {
            var formateur = EContext.Formateur.SingleOrDefault(f => f.IdFormateur == id);
            if (formateur != null) { EContext.Formateur.Remove(formateur); EContext.SaveChanges(); return true; }
            return false;
        }
        public List<Formateur> Afficher()
        {
            return EContext.Formateur.ToList();
        }

    }
}
