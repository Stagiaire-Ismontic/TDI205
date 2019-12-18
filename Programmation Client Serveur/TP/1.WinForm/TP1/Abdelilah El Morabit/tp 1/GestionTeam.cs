using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_1
{
    public class GestionTeam
    {
        List<Team> lstTeams;
        public GestionTeam()
        {
            lstTeams = new List<Team>();
        }
        public List<Team> LstTeams { get => lstTeams;}

        
        public Team find_t(int id)
        {
            foreach (Team p in LstTeams)
            {
                if (p.Id == id) return p;
            }
            return null;
        }
        public bool find_by_name(string name)
        {
            foreach (Team p in LstTeams)
            {
                if (p.Name==name) return true;
            }
            return false;
        }
        public bool ajouter(Team p)
        {
            if (find_t(p.Id)==null)
            {
                LstTeams.Add(p);
                return true;
            }
            return false;
        }
        public bool update(Team p)
        {
            if(!find_by_name(p.Name)){ 
            Team p1 = find_t(p.Id);
            p1.Name = p.Name;
                return true;
            }
            return false;


        }
        public bool delete(Team p)
        {
            if (find_t(p.Id)!=null)
            {
                LstTeams.Remove(p);
                return true;
            }
            return false;
        }
    }
}
