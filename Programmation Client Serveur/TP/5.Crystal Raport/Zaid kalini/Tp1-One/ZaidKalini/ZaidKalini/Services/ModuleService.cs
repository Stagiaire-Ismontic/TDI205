using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaidKalini.BusnissLayer;

namespace ZaidKalini.Services
{
    class ModuleService : IReposotory<Modules>
    {
        List<Modules> LesModules = new List<Modules>();
        public Modules Added(Modules E)
        {
            LesModules.Add(E);
            return E;
        }

        public Modules Delete(int id)
        {
            var m = Find(id);
            if(m!=null)
            LesModules.Remove(m);
            return m;
        }

        public Modules Find(int id)
        {
            return LesModules.FirstOrDefault(m => m.Id == id);

        }

        public List<Modules> Show()
        {
            return LesModules;
        }

        public Modules Update(Modules E)
        {
            var m = Find(E.Id);
            if (m == null)
                return null;
            m.Nom_module = E.Nom_module;
            return m;
        }
        /// <summary>
        /// id for New Element
        /// </summary>
        public int GetId()
        {
            return LesModules.Count + 1;
        }
    }
}
