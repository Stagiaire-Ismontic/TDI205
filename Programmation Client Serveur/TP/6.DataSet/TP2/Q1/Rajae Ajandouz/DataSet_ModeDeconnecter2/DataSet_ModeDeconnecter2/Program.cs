using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataSet_ModeDeconnecter2
{
    class Program
    {
        static void Main(string[] args)
        {

            string connexionString;
            connexionString = @"Data Source=.;Initial Catalog=Employe;Integrated Security=True";
            SqlConnection connexion = new SqlConnection(connexionString);
            SqlCommand cmdSelect = connexion.CreateCommand();
            cmdSelect.CommandText = "Select * from Employe";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmdSelect;
            DataSet ds = new DataSet();
            da.Fill(ds);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            // Ajouter un stagiaire
            DataRow dr1 = ds.Tables[0].NewRow();
            dr1["id"] = 1;
            dr1["Nom"] = "ajandouz";
            dr1["salaire"] = 100;
            ds.Tables[0].Rows.Add(dr1);
            da.Update(ds);

            DataRow dr2 = ds.Tables[0].NewRow();
            dr2["id"] = 2;
            dr2["Nom"] = "rajae";
            dr2["salaire"] = 100;
            ds.Tables[0].Rows.Add(dr2);
            da.Update(ds);
            // Update
            var drr = ds.Tables[0].Rows[1];
            drr["Nom"] = "Madani";
            drr["salaire"] = "4556";
            da.Update(ds);
            //Update
            DataRow drr2 = ds.Tables[0].Rows[1];
            drr2["Nom"] = "rajae";
            da.Update(ds);
            // Supprimer le premièr stagiaire
            DataRow drStagiaire = ds.Tables[0].Rows[1];
            drStagiaire.Delete();
            da.Update(ds);

            // Afficher tous les stagiaires
            foreach (DataRow ligne in ds.Tables[0].Rows)
            {
                Console.WriteLine("iD : {0} | Nom : {1} | salaire : {2} ", ligne[0], ligne["Nom"], ligne["salaire"]);
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
