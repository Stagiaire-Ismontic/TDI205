using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD___Windows
{
    public class GestiondesCommande
    {
        List<commande> cmd;
        List<livraison> liv;

        public List<commande> Cmd
        {
            get
            {
                return cmd;
            }

            set
            {
                cmd = value;
            }
        }

        internal List<livraison> Liv
        {
            get
            {
                return liv;
            }

            set
            {
                liv = value;
            }
        }
        public GestiondesCommande()
        {
            cmd = new List<commande>();
            liv = new List<livraison>();
        }
        public void ajouter(commande c)
        {
            cmd.Add(c);
        }
        public commande rechercher(int d)
        {
            for (int i = 0; i < cmd.Count; i++)
            {
                if (cmd[i].Id== d)
                    return cmd[i];

            }
            return null;
        }
        public void modifier(commande c)
        {
            commande s = rechercher(c.Id);
            if (s != null)
                s = c;
        }
        public void delete(int id)
        {
            commande c = rechercher(id);
            Cmd.Remove(c);
        }
    }
}
