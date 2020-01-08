using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syndic.MesClasses;

namespace Syndic.Service
{
    class RegionService : IService<MesClasses.Region>
    {
        AppContext context = Program.context;
        public RegionService()
        {
            
        }
        
        public Region Added(Region entity)
        {
            var R = context.Region.Add(entity);
            context.SaveChanges();
            return R;
        }

        public Region Delete(int id)
        {
            var R = Find(id);
            context.Region.Remove(R);
            context.SaveChanges();
            return R;
        }

        public Region Find(int id)
        {
            return context.Region.SingleOrDefault(r => r.id == id);
        }

        public IList<Region> Show()
        {
            return context.Region.ToList();
        }

        public Region Update(Region entity)
        {
            var R = Find(entity.id);
            R.Nom_region = entity.Nom_region;
            R.Total_Region = entity.Total_Region;
            R.Population_total = entity.Population_total;

            context.SaveChanges();
            return R;
        }
    }
}
