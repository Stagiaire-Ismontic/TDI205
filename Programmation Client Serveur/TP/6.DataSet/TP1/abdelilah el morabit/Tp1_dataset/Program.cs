using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp1_dataset.DataSet1TableAdapters;
namespace Tp1_dataset
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayersTableAdapter pta = new PlayersTableAdapter();
            TeamTableAdapter tta = new TeamTableAdapter();
            ////ajouter team
            //tta.Insert(12, "speder wad zem");

            ////ajouter player
 //           pta.Insert(1,"toto",10,10000,12);

            //update team
            DataSet1.TeamDataTable dstta = new DataSet1.TeamDataTable();
            tta.Fill(dstta);
            DataSet1.TeamRow t = dstta.FindById(12);
            t.name = "red bull wad zem";
            tta.Update(t);

            //update player
            DataSet1.PlayersDataTable sdataTable = new DataSet1.PlayersDataTable();
            pta.Fill(sdataTable);
            DataSet1.PlayersRow P = sdataTable.FindById(1);
            P.name = "Justin";
            P.salaier = 12000;
            pta.Update(P);
        }
    }
}
