using System;
using FormsApp.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp.Services
{
    public class GestionQuartier
    {

       GestionVille ville = new GestionVille();

       public Quartier Find(int id)
        {
            return Program.Context.ListQuartier.SingleOrDefault(s => s.Id == id);
        }

        public void Add(Quartier Q)
        {
            
                Program.Context.ListQuartier.Add(Q);
                Program.Context.SaveChanges();
    
        }

        public bool Update(Quartier Q)
        {
            Quartier QS = Find(Q.Id);
            if (QS != null)
            {
                QS.NomQuartier = Q.NomQuartier;
                QS.Population = Q.Population;
                QS.TotalQuartier = Q.TotalQuartier;
                QS.Ville = Q.Ville;
                Program.Context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Quartier QS = Find(id);
            if (QS != null)
            {
                Program.Context.ListQuartier.Remove(QS);
                Program.Context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Quartier> GetList()
        {
            return Program.Context.ListQuartier.ToList();
        }

        public Quartier Debut()
        {
            if (GetList().Count> 0) return GetList()[0];
            else return null;
        }

        public Quartier Suivant(int Id)
        {
            Quartier P = Find(Id);
            int index = GetList().IndexOf(P);
            if ((GetList().Count - 1) >= (index + 1))
            {
                return GetList()[index + 1];
            }
            else
            {
                return null;
            }
        }

        public Quartier Precedent(int Id)
        {
            Quartier P = Find(Id);
            int index = GetList().IndexOf(P);
            if ((GetList().Count - 1) >= (index - 1) && (index > 0))
            {
                return GetList()[index - 1];
            }
            else
            {
                return null;
            }
        }

        public Quartier Fin()
        {
            if (GetList().Count > 0) return GetList()[GetList().Count - 1];
            else return null;
        }
    }
}
