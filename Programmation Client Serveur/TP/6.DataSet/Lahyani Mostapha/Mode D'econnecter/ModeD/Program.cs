using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ModeD
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnexString;
            ConnexString = "Data Source=.;Initial Catalog=Client;Integrated Security=True";
            SqlConnection Connex = new SqlConnection(ConnexString);
            SqlCommand CommanSelect = Connex.CreateCommand();
            CommanSelect.CommandText = "Select * from [dbo].[tblClient]";

            SqlDataAdapter sqlDadapter = new SqlDataAdapter();
            sqlDadapter.SelectCommand = CommanSelect;
            DataSet Datseet = new DataSet();
            sqlDadapter.Fill(Datseet);
            SqlCommandBuilder ccmdb = new SqlCommandBuilder(sqlDadapter);

            ////Ajouter un Client
            //DataRow Dr1 = Datseet.Tables[0].NewRow();
            //Dr1["Cin"] = "kb12333";
            //Dr1["Id"] = 3;
            //Dr1["Fname"] = "JOhn";
            //Dr1["Lname"] = "wick";
            //Dr1["Nb_Phone"] = 500;
            //Dr1["Email"] = "jjjj@john";
            //Datseet.Tables[0].Rows.Add(Dr1);
            //sqlDadapter.Update(Datseet);




            //////Modifier un Client
            //DataRow Client4 = Datseet.Tables[0].Rows[0];
            //Client4["Fname"] = "WICKK";
            //sqlDadapter.Update(Datseet);


            //////Supprimer premier Client
            DataRow Pro = Datseet.Tables[0].Rows[0];
            Pro.Delete();
            sqlDadapter.Update(Datseet);


            ////Afficher Client
            //foreach (DataRow ligne in Datseet.Tables[0].Rows)
            //{
            //    Console.WriteLine("Cin = {0} | Id = {1} | Fname = {2} | Lname = {3} | Nb_Phone = {4} | Email = {5}", ligne[0],ligne[1],ligne[2], ligne[3], ligne[4], ligne[5]);
            //    Console.WriteLine("\n");
            //}

            Console.ReadLine();
        }
    }
}
