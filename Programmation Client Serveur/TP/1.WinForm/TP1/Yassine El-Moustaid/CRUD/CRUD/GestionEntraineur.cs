using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class GestionEntraineur
    {
        // CRUD + FORM
        List<Entraineur> lste;

        public List<Entraineur> Lste { get { return lste; } }

        public GestionEntraineur()
        {
            lste = new List<Entraineur>();
        }
        
        public Entraineur find_entraineur(int id)
        {
            foreach (Entraineur e in Lste)
            {
                if (e.Id == id) return e;
            }
            return null;
        }
        public bool add(Entraineur e)
        {
            if (find_entraineur(e.Id)==null)
            {
                Lste.Add(e);
                return true;
            }
            return false;
        }
        public void update(Entraineur e)
        {
            Entraineur ee = find_entraineur(e.Id);
            ee.Nom = e.Nom;
            ee.Prenom = e.Prenom;
        }
        public bool delete(Entraineur e)
        {
            if(find_entraineur(e.Id)!=null)
            {
                Lste.Remove(e);
                return true;
            }
            return false;
        }
    }
}
