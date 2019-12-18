using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_1
{
    public class GestiontPlayer
    {
        List<Player> lstp;

        public List<Player> Lstp
        {
            get
            {
                return lstp;
            }
        }

        public GestiontPlayer()
        {
            lstp = new List<Player>();
        }

      
        public bool find_in(int id)
        {
            foreach(Player p in Lstp)
            {
                if (p.Id == id) return true;
            }
            return false;
        }
        public Player find_p(int id)
        {
            foreach (Player p in Lstp)
            {
                if (p.Id == id) return p;
            }
            return null;
        }
        public bool ajouter(Player p)
        {
            if (!find_in(p.Id))
            {
                Lstp.Add(p);
                return true;
            }
            return false;
        }
        public void update(Player p)
        {
          Player  p1 = find_p(p.Id);
            p1.Name = p.Name;
            p1.Number = p.Number;
            p.Salaier = p.Salaier;
            

        }
        public bool delete(Player p)
        {
            if (find_in(p.Id))
            {
                Lstp.Remove(p);
                return true;
            }
            return false;
        }
        
    }
}
