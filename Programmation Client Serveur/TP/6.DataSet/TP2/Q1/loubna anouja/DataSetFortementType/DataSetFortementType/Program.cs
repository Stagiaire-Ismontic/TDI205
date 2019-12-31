using DataSetFortementType.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetFortementType
{
    class Program
    {
        static void Main(string[] args)
        {
            commandeTableAdapter cmd = new commandeTableAdapter();
            //ajouter une commande
            cmd.Insert("inconnu", "lava");
            //modifier une commande
            DataSet1.commandeDataTable cDataTable = new DataSet1.commandeDataTable();
            cmd.Fill(cDataTable);
            DataSet1.commandeRow c = cDataTable.FindById(1);
            c.Code = "hhh";
            cmd.Update(c);
        }
    }
}
