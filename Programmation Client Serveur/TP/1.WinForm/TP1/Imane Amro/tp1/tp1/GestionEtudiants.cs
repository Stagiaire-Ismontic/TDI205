using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class GestionEtudiants
    {
        List<etudiant> etd;

        public List<etudiant> Etd { get => etd; set => etd = value; }
        public GestionEtudiants()
        {
            etd = new List<etudiant>();
        }
        public void ajouter(etudiant c)
        {
            etd.Add(c);
        }
        public etudiant rechercher(int d)
        {
            for (int i = 0; i < etd.Count; i++)
            {
                if (etd[i].Id == d)
                    return etd[i];

            }
            return null;
        }
        public void modifier(etudiant c)
        {
            etudiant s = rechercher(c.Id);
            if (s != null)
                s = c;
        }
        public void delete(int id)
        {
            etudiant c = rechercher(id);
            etd.Remove(c);
        }
    }
}