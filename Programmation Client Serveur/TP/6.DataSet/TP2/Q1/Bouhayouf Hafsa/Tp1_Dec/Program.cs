using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Tp1_Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            String connexionString;
            connexionString = @"Data Source=.;Initial Catalog=GestionPharmacie;Integrated Security=True";
            SqlConnection con = new SqlConnection(connexionString);
            SqlCommand cmdSelect = con.CreateCommand();
            cmdSelect.CommandText = "Select * from stagiaires";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmdSelect;
            DataSet ds = new DataSet();
            da.Fill(ds);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            // Ajouter un Medicament
            DataRow dr1 = ds.Tables[0].NewRow();
            dr1["id"] = 3;
            dr1["nom"] = "jk1";
            ds.Tables[0].Rows.Add(dr1);
            da.Update(ds);
            DataRow dr2 = ds.Tables[0].NewRow();
            dr2["id"] = 4;
            dr2["nom"] = "jk2";
            ds.Tables[0].Rows.Add(dr2);
            da.Update(ds);

            // Update 
            DataRow drJk2 = ds.Tables[0].Rows[0];
            drJk2["nom"] = "jk3";
            da.Update(ds);

            // Supprimer le premier Medicament
            DataRow drMedicament = ds.Tables[0].Rows[0];
            drMedicament.Delete();
            da.Update(ds);

            // Afficher tous les Medicaments
            foreach (DataRow ligne in ds.Tables[0].Rows)
            {
                Console.WriteLine("ID : {0} | Nom : {1} | Prix : {2}", ligne[0], ligne[1], ligne["Prix"]);
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}

        