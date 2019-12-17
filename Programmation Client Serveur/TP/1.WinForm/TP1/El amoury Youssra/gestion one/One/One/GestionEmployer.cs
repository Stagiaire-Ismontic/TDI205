using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One
{
   public  class GestionEmployer
    {
        private List<Employer> list;

        public List<Employer> List
        {
            get
            {
                return list;
            }

            set
            {
                list = value;
            }
        }
        public GestionEmployer()
        {
            List = new List<Employer>();
        }

        public void Ajouter(Employer e)
        {
            List.Add(e);
        }

        public Employer Chercher(int id)
        {
            foreach (Employer e in List)
            {
                if(e.Id==id)
                {
                    return e;
                }
               
            }
            return null;
        }
        public void Supprimer(int id)
        {
            Employer a = Chercher(id);
            list.Remove(a);

        }
        public void Modifier( Employer e)
        {
            Employer a = Chercher(e.Id);
            if(a!=null)
            {
                e = a;
            }

        }


        
    }
}
