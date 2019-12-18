using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class GestionSalle
    {
        //CRUD + form
        List<Salle> lsts;
        public GestionSalle()
        {
            lsts = new List<Salle>();
        }
        public List<Salle> Lsts { get { return lsts; } }
        public Salle find_salle(int id)
        {
            foreach(Salle s in Lsts)
            {
                if (s.Id == id) return s;
            }
            return null;
        }
        public bool add(Salle s)
        {
            if (find_salle(s.Id) == null)
            {
                Lsts.Add(s);
                return true;
            }
            return false;
        }
        public void update(Salle s)
        {
                Salle Ss = find_salle(s.Id);
                Ss.Description = s.Description;
        }
        public bool delete(Salle s)
        {
            if (find_salle(s.Id) != null)
            {
                Lsts.Remove(s);
                return true;
            }
            return false;
        }
    }
}
