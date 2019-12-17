using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaidKalini.BusnissLayer;

namespace ZaidKalini.Services
{
    class FormateurService : repotory<Formateur>
    {
        List<Formateur> LesFormateurs = new List<Formateur>();
        public Formateur Added(Formateur E)
        {
            LesFormateurs.Add(E);
            return E;
        }

        public Formateur Delete(int id)
        {
            var f = Find(id);
            if (f != null)
                LesFormateurs.Remove(f);
            return f;

        }

        public Formateur Find(int id)
        {
            return LesFormateurs.SingleOrDefault(f => f.id == id);
        }

        public IList<Formateur> Show()
        {
            return LesFormateurs;
        }

        public Formateur Update(Formateur E)
        {
            var f = Find(E.id);
            if (f != null)
            {
                f.FullName = E.FullName;
                f.Age = E.Age;
            }
            return f;
            
            
        }
        /// <summary>
        /// id for New Element
        /// </summary>
        public int GetId()
        {
            return LesFormateurs.Count + 1;
        }
    }
}
