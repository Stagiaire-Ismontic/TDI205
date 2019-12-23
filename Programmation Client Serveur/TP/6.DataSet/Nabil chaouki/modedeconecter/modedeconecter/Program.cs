using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace modedeconecter
{
    class Program
    {
        static void Main(string[] args)
        {
            string connexionString;
            connexionString = @"Data Source=LAPTOP-T74VUB02\MSSQLSERVE;Initial Catalog=budget;Integrated Security=true";
            SqlConnection connexion = new SqlConnection(connexionString);
            SqlCommand cmdSelect = connexion.CreateCommand();
            cmdSelect.CommandText = "Select * from Userr";


            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmdSelect;
            DataSet ds = new DataSet();
            da.Fill(ds);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            //Add

            //DataRow dr1 = ds.Tables[0].NewRow();
            //dr1["ID"] = 1;
            //dr1["LastName"] = "vladimir";
            //dr1["FirstName"] = "chfchniko";

            //dr1["CIN"] = "CGHT443r45";

            //ds.Tables[0].Rows.Add(dr1);
            //da.Update(ds);

            //DataRow dr2 = ds.Tables[0].NewRow();
            //dr2["ID"] = 2;
            //dr2["LastName"] = "zgarowfski";
            //dr2["FirstName"] = "khabib";

            //dr2["CIN"] = "GH67yfet";
            //ds.Tables[0].Rows.Add(dr2);

            //da.Update(ds);

            // updtade

            DataRow drvladimir = ds.Tables[0].Rows[0];
            drvladimir["LastName"] = "Putin";
            drvladimir["CIN"] = "moscowhkgb";
            da.Update(ds);
            //delete

            //DataRow drUser = ds.Tables[0].Rows[0];
            //drUser.Delete();
            //da.Update(ds);

            // Afficher tous les stagiaires
            foreach (DataRow ligne in ds.Tables[0].Rows)
            {
                Console.WriteLine("ID : {0} | Lastname : {1} | FirstName  : {2}", ligne[0], ligne[1], ligne["CIN"]);
                Console.WriteLine("\n");
            }

            Console.ReadLine();

        }
    }
}
