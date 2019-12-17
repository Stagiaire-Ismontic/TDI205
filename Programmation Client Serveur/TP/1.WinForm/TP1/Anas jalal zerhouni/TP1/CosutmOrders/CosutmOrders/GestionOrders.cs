using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosutmOrders
{
    public class GestionOrders
    {
        List<Orders> lstO = new List<Orders>();

        public List<Orders> LstO
        {
            get
            {
                return LstO1;
            }

            set
            {
                LstO1 = value;
            }
        }

        public List<Orders> LstO1
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

        public bool ajouter(Orders o) {
            if (recherche(o.NumOrder) == null)
            {
                this.LstO.Add(o);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Modifier(Orders oo) {
            Orders o = this.recherche(oo.NumOrder);
            if (o != null) { o = oo; return true; }
            else return false;
        }
        public bool Supprimer(int Num) {
            Orders o = recherche(Num);
            if (recherche(Num) != null) {
                this.LstO.Remove(o);
                return true;
            }
            return false;

        }
        public Orders recherche(int id) {
            return this.LstO.Find(o => o.NumOrder==id);
        }

    }
}
