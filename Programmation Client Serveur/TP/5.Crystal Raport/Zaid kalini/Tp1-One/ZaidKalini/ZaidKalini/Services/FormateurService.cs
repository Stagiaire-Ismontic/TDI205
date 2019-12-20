using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaidKalini.BusnissLayer;

namespace ZaidKalini.Services
{
    class FormateurService : IReposotory<Formateur>
    {
        Entities.AppContext context = new Entities.AppContext();
        public Formateur Added(Formateur E)
        {
            context.Formateurs.Add(E);
            context.SaveChanges();
            return E;
        }

        public Formateur Delete(int id)
        {
            var f = Find(id);
            if (f != null)
                context.Formateurs.Remove(f);
            context.SaveChanges();
            return f;

        }

        public Formateur Find(int id)
        {
            return context.Formateurs.SingleOrDefault(f => f.Id == id);
        }

        public List<Formateur> Show()
        {
            return context.Formateurs.ToList();
        }

        public Formateur Update(Formateur E)
        {
            var f = Find(E.Id);
            if (f != null)
            {
                f.FullName = E.FullName;
                f.Age = E.Age;
                context.SaveChanges();
            }
            return f;
            
            
        }
        /// <summary>
        /// id for New Element
        /// </summary>
        public int GetId()
        {
            return context.Formateurs.Count() + 1;
        }
    }
}
