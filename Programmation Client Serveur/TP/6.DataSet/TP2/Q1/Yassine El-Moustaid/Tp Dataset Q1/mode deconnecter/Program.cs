using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using mode_deconnecter.DataSet1TableAdapters;

namespace mode_deconnecter
{
    class Program
    {
        static void Main(string[] args)
        {
            EntraineurTableAdapter eta = new EntraineurTableAdapter();
            SalleTableAdapter sta = new SalleTableAdapter();
            sta.Insert(5, "Massage");

            //ajouter player
            eta.Insert(5,"Alal","abdo");

            //update team
            DataSet1.SalleDataTable dssta = new DataSet1.SalleDataTable();
            sta.Fill(dssta);
            DataSet1.SalleRow t = dssta.FindByid(5);
            t._description = "Yoga";
            sta.Update(t);

            //update player
            DataSet1.EntraineurDataTable dsedt = new DataSet1.EntraineurDataTable();
            eta.Fill(dsedt);
            DataSet1.EntraineurRow P = dsedt.FindByid(5);
            P.nom = "Si brahim";
            P.prenom = "aller";
            eta.Update(P);
        }
    }
}
