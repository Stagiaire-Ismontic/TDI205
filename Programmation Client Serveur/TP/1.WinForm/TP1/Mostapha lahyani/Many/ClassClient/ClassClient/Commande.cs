using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassClient
{
    public class Commande
    {
        public int idCmd { get; set; }
        public int idClient { get; set; }
        public String CmdName { get; set; }

        public Commande()
        {

        }

        public Commande(int idCmd, int idClient, String CmdName)
        {
            this.idCmd = idCmd;
            this.idClient = idClient;
            this.CmdName = CmdName;
        }
    }
}
