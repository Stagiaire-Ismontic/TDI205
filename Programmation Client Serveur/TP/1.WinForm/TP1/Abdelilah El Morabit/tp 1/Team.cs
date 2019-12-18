using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_1
{
    public class Team
    {
        string name;
        List<Player> listP;
        int id;
        public Team(int id,string name)
        {
            Name = name;
            Id = id;
            ListP = new List<Player>();
        }

        public string Name { get => name; set => name = value; }
        public List<Player> ListP { get => listP; set => listP = value; }
        public int Id { get => id; set => id = value; }
    }
}
