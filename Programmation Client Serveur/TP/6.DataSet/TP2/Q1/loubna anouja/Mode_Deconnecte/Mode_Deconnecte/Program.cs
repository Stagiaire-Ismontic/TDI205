using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mode_Deconnecte
{
    class Program
    {
        static void Main(string[] args)
        {
            string connexionstring;
            connexionstring = @"Data Source=.\SQLEXPRESS;initial catalog=loubna ;integrated security=true";
            SqlConnection connexion = new SqlConnection(connexionstring);
            SqlCommand cmdselect = connexion.CreateCommand();
            cmdselect.CommandText = "select * from commande";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmdselect;
            DataSet ds = new DataSet();
            da.Fill(ds);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            //ajouter commande
            //DataRow dr1 = ds.Tables[0].NewRow();
            //dr1["Id"] = 1;
            //dr1["Code"] = "excelo";
            //dr1["Nom"] = "oreo";
            //ds.Tables[0].Rows.Add(dr1);
            //da.Update(ds);
            DataRow dr2 = ds.Tables[0].NewRow();
            dr2["Id"] = 1;
            dr2["Code"] = "bimo";
            dr2["Nom"] = "tonik";
            ds.Tables[0].Rows.Add(dr2);
            da.Update(ds);
            //update
            DataRow drOne = ds.Tables[0].Rows[0];
            drOne["Code"] = "biggy";
            da.Update(ds);
            //supprimer la premiere commande
            DataRow drOn = ds.Tables[0].Rows[0];
            drOn.Delete();
            da.Update(ds);
            //afficher tous les commandes 
            foreach(DataRow ligne in ds.Tables[0].Rows)
            {
                Console.WriteLine("Id :{0} | Code :{1} | Nom :{2}", ligne[0], ligne[1], ligne[2]);
            }
            Console.ReadLine();
        }
    }
}
