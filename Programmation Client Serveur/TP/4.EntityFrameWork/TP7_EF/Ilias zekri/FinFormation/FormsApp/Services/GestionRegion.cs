using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsApp.Classes;

namespace FormsApp.Services
{
    public class GestionRegion
    {
        public Region Find(int id)
        {
            return Program.Context.ListRegion.SingleOrDefault(s => s.Id == id);
        }

        public void Add(Region R)
        {

            Program.Context.ListRegion.Add(R);
            Program.Context.SaveChanges();
        }

        public bool Update(Region R)
        {
            Region Rg = Find(R.Id);
            if (Rg != null)
            {
                Rg.NomRegion = R.NomRegion;
                Rg.Population = R.Population;
                Rg.TotalRegion = R.TotalRegion;
                Program.Context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Region R = Find(id);
            if (R != null)
            {
                Program.Context.ListRegion.Remove(R);
                Program.Context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Region> GetList()
        {
            return Program.Context.ListRegion.ToList();
        }
    }
}
