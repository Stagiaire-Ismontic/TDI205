using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosutmOrders
{
    public class Orders
    {
        int numOrder;
        string NamOrder;
        Costumer c;

        public Costumer C
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }

        public string NamOrder1
        {
            get
            {
                return NamOrder;
            }

            set
            {
                NamOrder = value;
            }
        }

        public int NumOrder
        {
            get
            {
                return numOrder;
            }

            set
            {
                numOrder = value;
            }
        }

        public Orders()
        {
                
        }
        public Orders(int num, string nom,Costumer c)
        {
            this.numOrder = num;
            this.NamOrder = nom;
            this.c = c;
        }
    }
}
