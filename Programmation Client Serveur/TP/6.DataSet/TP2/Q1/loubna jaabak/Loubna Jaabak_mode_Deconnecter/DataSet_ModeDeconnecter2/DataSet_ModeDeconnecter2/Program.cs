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
            connexionString = @"Data Source=.;Initial Catalog=EditeurS;Integrated Security=True";
            SqlConnection connexion = new SqlConnection(connexionString);
            SqlCommand cmdSelect = connexion.CreateCommand();
            cmdSelect.CommandText = "Select * from Editeur";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmdSelect;
            DataSet ds = new DataSet();
            da.Fill(ds);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            // Ajouter un stagiaire

            //DataRow dr1 = ds.Tables[0].NewRow();
            //dr1["id"] = 3;
            //dr1["Nom"] = "Madani";
            //dr1["Prenom"] = "mohamed";
            //ds.Tables[0].Rows.Add(dr1);
            //da.Update(ds);

            //DataRow dr2 = ds.Tables[0].NewRow();
            //dr2["id"] = 4;
            //dr2["Nom"] = "Madani";
            //dr2["Prenom"] = "Jamal";
            //ds.Tables[0].Rows.Add(dr2);
            //da.Update(ds);

            // Update

            DataRow drr = ds.Tables[0].Rows[1];
            drr["Nom"] = "Madani";
            drr["Prenom"] = "Salim";
            da.Update(ds);

            //Update
            //DataRow drr2 = ds.Tables[0].Rows[1];
            //drr2["Nom"] = "Salim";
            //da.Update(ds);


            // Supprimer le premièr stagiaire

            //DataRow drStagiaire = ds.Tables[0].Rows[4];
            //drStagiaire.Delete();
            //da.Update(ds);
            // Afficher tous les stagiaires
            foreach (DataRow ligne in ds.Tables[0].Rows)
            {
                Console.WriteLine("id : {0} | Nom : {1} | Prenom : {2} ", ligne[0], ligne["Nom"], ligne["Prenom"]);
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
