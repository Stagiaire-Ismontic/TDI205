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
            costumersTableAdapter cta = new costumersTableAdapter();
            //afficher
            cta.Insert(568,"madani");

            //update
            DataSet1.costumersDataTable sdataTable = new DataSet1.costumersDataTable();
            cta.Fill(sdataTable);
            DataSet1.costumersRow r = sdataTable.FindById(1);
            r.NomEtPrenom = "Justin";
            cta.Update(r);
        }
    }
}
