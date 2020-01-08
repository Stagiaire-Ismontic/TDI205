using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syndic.MesClasses;

namespace Syndic.Service
{
    class SyndicServices : IService<MesClasses.Syndic>
    {
        AppContext context = new AppContext();
        public MesClasses.Syndic Added(MesClasses.Syndic entity)
        {
            var S = context.Syndic.Add(entity);
            context.SaveChanges();
            return S;
        }

        public MesClasses.Syndic Delete(int id)
        {
            var synd= context.Syndic.Remove(Find(id));
            context.SaveChanges();
            return synd;
        }

        public MesClasses.Syndic Find(int id)
        {
            return context.Syndic.FirstOrDefault(s => s.id == id);
        }

        public IList<MesClasses.Syndic> Show()
        {
            return context.Syndic.ToList();
        }
        /// <summary>
        /// return a new value of syndic
        /// </summary>
        /// <param name="entity">new syndic</param>
        /// <returns></returns>

        public MesClasses.Syndic Update(MesClasses.Syndic entity)
        {
            var synd = Find(entity.id);
            synd.Nom_syndic = entity.Nom_syndic;
            synd.Prenom_syndic = entity.Prenom_syndic;
            synd.Telephone = entity.Telephone;
            synd.Mot_de_passe = entity.Mot_de_passe;
            context.SaveChanges();
            return synd;
        }
    }
}
