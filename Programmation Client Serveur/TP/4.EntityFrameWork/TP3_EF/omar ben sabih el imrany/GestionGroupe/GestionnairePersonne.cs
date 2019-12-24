using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GestionGroupe
{
    class GestionnairePersonne
    {

        public static List<Personne> Lstprs = new List<Personne>();
        public void Ajouter(Personne p)
        {
            using (var db = new AppContext())
            {
                Lstprs.Add(p);
                db.SaveChanges();
            }
        }
        


    public void Supprimer(int id)
    {
            using (var db = new AppContext())
            {
                Personne p = db.lst_personne.SingleOrDefault(s=>s.Id==id);
                Lstprs.Remove(p);
                db.SaveChanges();
            }
         
    }

    public void Modifier(Personne p)
    {
            using (var db = new AppContext())
            {
                Personne ps = db.lst_personne.SingleOrDefault(s=>s.Id==p.Id);
                ps.Age = p.Age;
                ps.Nom = p.Nom;
                db.SaveChanges();
            }
    }

    public List<Personne> GetProjet()
    {
        return Lstprs;
    }
    }
}
