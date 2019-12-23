using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassClient
{
    public class GestionCommande
    {
        public static List<Commande> lst_Cmd = new List<Commande>();

        public void AjouterCMD(Commande cmd)
        {
            lst_Cmd.Add(cmd);
        }

        public Commande RechercheByIdCMD(int idcmd)
        {
            foreach (var Cmd in lst_Cmd)
            {
                if (Cmd.idCmd == idcmd)
                {
                    return Cmd;
                }
            }
            return null;
        }

        public void DeleteCMD(Commande cmd)
        {
            Commande cs = this.RechercheByIdCMD(cmd.idCmd);
            lst_Cmd.Remove(cs);

        }

        public void ModifierCMD(Commande C)
        {
            Commande cmdd = this.RechercheByIdCMD(C.idCmd);
            cmdd.idCmd = C.idCmd;
            cmdd.idClient = C.idClient;
            cmdd.CmdName = C.CmdName;
        }

        public List<Commande> Getcmd()
        {
            ///kat eti liste kamla
            return lst_Cmd;
        }
    }
}
