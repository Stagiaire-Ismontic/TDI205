using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many
{
    public class livraison
    {
        int idL;
        DateTime dateL;


        public int IdL
        {
            get
            {
                return idL;
            }

            set
            {
                idL = value;
            }
        }

        public DateTime DateL
        {
            get
            {
                return dateL;
            }

            set
            {
                dateL = value;
            }
        }
        public livraison() { }
        public livraison(int idliv, DateTime date)
        {
            IdL = idliv;
            DateL = date;
        }
    }
}
