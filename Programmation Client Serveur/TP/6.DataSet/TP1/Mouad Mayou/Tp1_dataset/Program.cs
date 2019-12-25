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
            stockTableAdapter sta = new stockTableAdapter();
            produitTableAdapter pta = new produitTableAdapter();
            

            //ajouter stock
            sta.Insert(15,"this is my  stock");

            //ajouter prodect
            pta.Insert(1, "produt dyali", 50, 15);

            //update stock
            DataSet1.stockDataTable dstta = new DataSet1.stockDataTable();
            sta.Fill(dstta);
            DataSet1.stockRow t = dstta.FindById(15);
            t.discription = "it was my  stock";
            sta.Update(t);

            //update prodect
            DataSet1.produitDataTable sdataTable = new DataSet1.produitDataTable();
            pta.Fill(sdataTable);
            DataSet1.produitRow P = sdataTable.FindById(1);
            P.name = " produit";
            P.price = 30;
            pta.Update(P);
        }
    }
}
