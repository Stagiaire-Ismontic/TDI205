using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class GestionAdmins
    {
        List<Admins> lstAdmins = new List<Admins>();
        public bool ajouter(Admins a) {
            if (recherche(a.Id) == null)
            {
                lstAdmins.Add(a);
                return true;
            }
            return false;
        }
        public bool supprimer(int id) {
            if (recherche(id) != null)
            {
                lstAdmins.Remove(recherche(id));
                return true;
            }
            return false;
        }
        public bool modifier(Admins a) {
            if (recherche(a.Id) != null)
            {
                Admins adm = recherche(a.Id);  
                adm=a;
                return true;
            }
            return false;
        }
        public Admins recherche(int id) {
            return lstAdmins.Find(a => a.Id==id);
        }
        public List<Admins> getAdmins() {
            return lstAdmins;
        }
    }
}
