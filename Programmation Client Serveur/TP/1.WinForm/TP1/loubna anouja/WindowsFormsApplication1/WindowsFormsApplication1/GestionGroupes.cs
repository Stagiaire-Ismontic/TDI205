using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class GestionGroupes
    {
        public List<groupe> liste { get; set; }
        public GestionGroupes()
        {
            liste = new List<groupe>();
         //   liste.Add(new groupe(1,"test"));
        }
        public groupe rechercher(groupe g)
        {
            return (from item in liste where item.Id == g.Id select item).FirstOrDefault();
        }
        public void ajouter (groupe g)
        {
            liste.Add( new groupe { Id = g.Id, Nom = g.Nom });

        }
        public void supprimer(groupe g)
        {
            liste = liste.Distinct().Where(x => x.Id != g.Id).ToList();
        }
        public void modifier(groupe g)
        {
            liste.Where(c => c.Id == g.Id).Select(c =>
            {
                c.Nom = g.Nom;
                return c;
            }).ToList();
        }
    }
}
