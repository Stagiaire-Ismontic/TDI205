using Syndic.MesClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syndic.Service
{
    class QuartierService : IService<Quartier>
    {
        AppContext context = new AppContext();
        public Quartier Added(Quartier entity)
        {
            var Q = context.Quartier.Add(entity);
            context.SaveChanges();
            return Q;
        }

        public Quartier Delete(int id)
        {
            var Q = context.Quartier.Remove(Find(id));
            context.SaveChanges();
            return Q;
        }

        public Quartier Find(int id)
        {
            return context.Quartier.FirstOrDefault(Q => Q.id == id);
        }

        public IList<Quartier> Show()
        {
            return context.Quartier.ToList();
        }

        public Quartier Update(Quartier entity)
        {
            var Q = Find(entity.id);
            Q.Nom_quartier = entity.Nom_quartier;
            Q.Population_quartier = entity.Population_quartier;
            Q.Total_quartier = entity.Total_quartier;
            Q.ville = entity.ville;
            context.SaveChanges();
            return Q;
        }
    }
}
