using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpClient
{
    public class Commande
    {
        public Client Clientt { get; set; }
        public int IdCommande { get; set; }
        public Nullable<int> ClientId { get; set; }

        public virtual Client Client { get; set; }
    }
}
