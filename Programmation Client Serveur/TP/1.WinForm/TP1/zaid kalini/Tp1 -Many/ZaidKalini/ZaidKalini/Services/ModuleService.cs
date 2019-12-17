using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaidKalini.BusnissLayer;

namespace ZaidKalini.Services
{
    class ModuleService : repotory<Modules>
    {
        List<Modules> LesModules = new List<Modules>();
        public Modules Added(Modules E)
        {
            LesModules.Add(E);
            return E;
        }

        public Modules Delete(int id)
        {
            LesModules.Remove(Find(id));
            return Find(id);
        }

        public Modules Find(int id)
        {
            return LesModules.FirstOrDefault(m => m.id == id);

        }

        public IList<Modules> Show()
        {
            return LesModules;
        }

        public Modules Update(Modules E)
        {
            var m = Find(E.id);
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
