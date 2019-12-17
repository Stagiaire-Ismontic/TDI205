using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosutmOrders
{
    public class GestionCostumers
    {
        List<Costumer> lstO = new List<Costumer>();

        public List<Costumer> LstO
        {
            get
            {
                return lstO;
            }

            set
            {
                lstO = value;
            }
        }

        public bool ajouter(Costumer o)
        {
            if (recherche(o.ID) == null)
            {
                this.LstO.Add(o);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Modifier(Costumer oo)
        {
            Costumer o = this.recherche(oo.ID);
            if (o != null) { o.NomEtPrenom = oo.NomEtPrenom; return true; }
            else return false;
        }
        public bool Supprimer(int Num)
        {
            Costumer o = recherche(Num);
            if (recherche(Num) != null)
            {
                this.LstO.Remove(o);
                return true;
            }
            return false;

        }
        public Costumer recherche(int id)
        {
            return this.LstO.Find(o => o.ID == id);
        }

    }
}
