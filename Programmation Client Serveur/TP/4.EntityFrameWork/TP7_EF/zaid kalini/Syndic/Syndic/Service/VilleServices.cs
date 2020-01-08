using Syndic.MesClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syndic.Service
{
    class VilleServices : IService<Ville>
    {
        AppContext context = Program.context;

        public Ville Added(Ville entity)
        {
          var V=  context.Ville.Add(entity);
            context.SaveChanges();
            return V;
        }

        public Ville Delete(int id)
        {
            var V= context.Ville.Remove(Find(id));
            context.SaveChanges();
            return V;
        }

        public Ville Find(int id)
        {
            return context.Ville.FirstOrDefault(v => v.id == id);
           
        }

        public IList<Ville> Show()
        {
            return context.Ville.ToList();
        }

        public Ville Update(Ville entity)
        {
            var V = Find(entity.id);
            V.Nom_ville = entity.Nom_ville;
            V.region = entity.region;
            V.Total_ville = entity.Total_ville;
            context.SaveChanges();
            return V;
        }
        public List<Region> LesRegion()
        {
            return context.Region.ToList();
        }
    }
}
