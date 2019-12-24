using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tp_deco
{
    class Program
    {
        static void Main(string[] args)
        {
            string CnxChaine = @"Data Source=DESKTOP-CT98AF6\SQLEXPRESS;Initial Catalog=DataAdapterExemple;Integrated Security=True";
            SqlConnection Cnx = new SqlConnection(CnxChaine);
            SqlCommand cmd = Cnx.CreateCommand();
            cmd.CommandText = "Select * from Personne";

            SqlDataAdapter dtap = new SqlDataAdapter();
            dtap.SelectCommand = cmd;
            DataSet Dat = new DataSet();
            dtap.Fill(Dat);
            SqlCommandBuilder cb = new SqlCommandBuilder(dtap);

            //Ajouter Un Personne
            /* DataRow dr1 = Dat.Tables[0].NewRow();
             dr1["Id_Persone"] = 3;
             dr1["Name"] = "Ali";
             dr1["Age"] = 22;
             Dat.Tables[0].Rows.Add(dr1);
             dtap.Update(Dat);*/

            DataRow dr1 = Dat.Tables[0].Rows[0];
            dr1["Name"] = "Ikram";

            //Afficher Un Personne
            foreach (DataRow ligne in Dat.Tables[0].Rows)
            {
                Console.WriteLine("ID= {0} | Name = {1} | Age = {2}", ligne[0], ligne[1], ligne[2]);
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
