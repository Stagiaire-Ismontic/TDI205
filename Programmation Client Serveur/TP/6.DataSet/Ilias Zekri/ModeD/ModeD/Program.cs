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
            ConnexString = @" Data Source = DESKTOP-NENV9L2; Initial Catalog = Gestionnaire; Integrated Security = True";
            SqlConnection Connex = new SqlConnection(ConnexString);
            SqlCommand CommanSelect = Connex.CreateCommand();
            CommanSelect.CommandText = "Select * from Produit";

            SqlDataAdapter Asdapt = new SqlDataAdapter();
            Asdapt.SelectCommand = CommanSelect;
            DataSet Dat = new DataSet();
            Asdapt.Fill(Dat);
            SqlCommandBuilder cb = new SqlCommandBuilder(Asdapt);

            ////Ajouter un Produit
            //DataRow dr1 = Dat.Tables[0].NewRow();
            //dr1["ProduitId"] = 4;
            //dr1["Nom"] = "Produit 4";
            //dr1["Prix"] = 500;
            //Dat.Tables[0].Rows.Add(dr1);
            //Asdapt.Update(Dat);

            //DataRow dr2 = Dat.Tables[0].NewRow();
            //dr2["ProduitId"] = 5;
            //dr2["Nom"] = "Produit 5";
            //dr2["Prix"] = 500;
            //Dat.Tables[0].Rows.Add(dr2);
            //Asdapt.Update(Dat);


            ////Modifier un Produit
            //DataRow DrProduit4 = Dat.Tables[0].Rows[0];
            //DrProduit4["Nom"] = "Produit";
            //Asdapt.Update(Dat);


            ////Supprimer premier Produit
            //DataRow Pro = Dat.Tables[0].Rows[0];
            //Pro.Delete();
            //Asdapt.Update(Dat);


            //Afficher Produit
            foreach  (DataRow ligne in Dat.Tables[0].Rows)
            {
                Console.WriteLine("Id = {0} | Nom = {1} | Prix = {2}",ligne[0],ligne[1],ligne[2]);
                Console.WriteLine("\n");
            }

            Console.ReadLine();





        }
    }
}
