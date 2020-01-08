using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsApp.Classes;

namespace FormsApp.Services
{
   public class GestionVille
    {
        GestionRegion Region = new GestionRegion();

        public Ville Find(int id)
        {
            return Program.Context.ListVille.SingleOrDefault(s => s.Id == id);
        }

        public void Add(Ville V)
        {
           
                Program.Context.ListVille.Add(V);
                Program.Context.SaveChanges();
          
        }

        public bool Update(Ville V)
        {
            Ville Vs = Find(V.Id);
            if (Vs != null)
            {
                Vs.NomVille = V.NomVille ;
                Vs.Region = V.Region;
                Vs.TotalVille = V.TotalVille;
                Program.Context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Ville V = Find(id);
            if (V != null)
            {
                Program.Context.ListVille.Remove(V);
                Program.Context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Ville> GetList()
        {
            return Program.Context.ListVille.ToList();
        }
    }
}
