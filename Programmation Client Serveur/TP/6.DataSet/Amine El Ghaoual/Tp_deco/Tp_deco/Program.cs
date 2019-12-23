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
            string conx;
            conx = @"Data Source=DESKTOP-CE825FO;Initial Catalog=dbsimple;Integrated Security=True";
            SqlConnection Connex = new SqlConnection(conx);
            SqlCommand cmd = Connex.CreateCommand();
            cmd.CommandText = "Select * from Persone";

            SqlDataAdapter dtap = new SqlDataAdapter();
            dtap.SelectCommand = cmd;
            DataSet Dat = new DataSet();
            dtap.Fill(Dat);
            SqlCommandBuilder cb = new SqlCommandBuilder(dtap);
            //Afficher Produit
            foreach (DataRow ligne in Dat.Tables[0].Rows)
            {
                Console.WriteLine("ID= {0} | Name = {1} | Passw = {2}", ligne[0], ligne[1], ligne[2]);
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
