using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace tp_2_frame
{
    public partial class Client
    {
        public int id { get; set; }
        public string nom { get; set; }
        public virtual List<Compte> lst_compte { get; set; }
    }
}
