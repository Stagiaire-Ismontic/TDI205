using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosutmOrders
{
    public class Costumer
    {
        int id;
        string nomEtPrenom;
        List<Orders> lstOrders = new List<Orders>();

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string NomEtPrenom
        {
            get
            {
                return nomEtPrenom;
            }

            set
            {
                nomEtPrenom = value;
            }
        }

        public List<Orders> LstOrders
        {
            get
            {
                return lstOrders;
            }

            set
            {
                lstOrders = value;
            }
        }

        public Costumer(int id,string nom)
        {
            this.ID = id;
            this.nomEtPrenom=nom;

        }
        public Costumer()
        {

        }
    }
}
