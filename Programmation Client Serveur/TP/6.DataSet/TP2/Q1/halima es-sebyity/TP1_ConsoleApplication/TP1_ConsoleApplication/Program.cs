using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TP1_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string Maconnexion = @"Data Source=.;Initial Catalog=Biblio_des_Livre;Integrated Security=True";

            SqlConnection conn = new SqlConnection(Maconnexion);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Livre";

            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = cmd;
            DataSet DS = new DataSet();
            DA.Fill(DS);

            SqlCommandBuilder SCB = new SqlCommandBuilder(DA);

            // ajouter un livre dans la bibliotheque

            DataRow livre1 = DS.Tables[0].NewRow();
            livre1["id"] = 1;
            livre1["titre"] = "La dernier Jour";
            livre1["categorie"] = "Roman";
            livre1["nom_auteur"] = "ana";
            DS.Tables[0].Rows.Add(livre1);
            DA.Update(DS);

            DataRow livre2 = DS.Tables[0].NewRow();
            livre2["id"] = 2;
            livre2["titre"] = "Zigola";
            livre2["categorie"] = "Roman";
            livre2["nom_auteur"] = "ana";
            DS.Tables[0].Rows.Add(livre2);
            DA.Update(DS);

            //Modifier 

            DataRow lv = DS.Tables[0].Rows[1];
            lv["titre"] = "maxi ana";
            DA.Update(DS);

            //supprimer un livre


            DataRow lv_del = DS.Tables[0].Rows[0];
            lv_del.Delete();
            DA.Update(DS);


            //Afficher tous les livres

            foreach (DataRow ligne in DS.Tables[0].Rows)
            {
                Console.WriteLine("ID : {0} \n Titre : {1} \n Categorie : {2} \n Nom auteur : {3}",ligne[0], ligne[1], ligne[2], ligne[3]);
                Console.WriteLine("\n-------------------------\n");
            }

            Console.ReadKey();


        }
    }
}
