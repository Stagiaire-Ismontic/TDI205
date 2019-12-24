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
            string Cx;
            Cx = @" Data Source = DESKTOP-NENV9L2; Initial Catalog = GestionBanque; Integrated Security = True";
            SqlConnection C = new SqlConnection(Cx);
            SqlCommand select = C.CreateCommand();
           select.CommandText = "Select * from Client";

            SqlDataAdapter sqladpt = new SqlDataAdapter();
            sqladpt.SelectCommand = select;
            DataSet Ds = new DataSet();
            sqladpt.Fill(Ds);
            SqlCommandBuilder build = new SqlCommandBuilder(sqladpt);

            DataRow dr1 = Ds.Tables[0].NewRow();
            dr1["id"] = 1;
            dr1["nom"] = "omar";
            Ds.Tables[0].Rows.Add(dr1);
            sqladpt.Update(Ds);

            DataRow dr2 = Ds.Tables[0].NewRow();
            dr2["id"] = 2;
            dr2["nom"] = "zekri";
            Ds.Tables[0].Rows.Add(dr2);
            sqladpt.Update(Ds);


            DataRow Dromar = Ds.Tables[0].Rows[0];
            Dromar["nom"] = "mohcine";
            sqladpt.Update(Ds);


            DataRow drdelete = Ds.Tables[0].Rows[0];
            drdelete.Delete();
            sqladpt.Update(Ds);


            foreach (DataRow line in Ds.Tables[0].Rows)
            {
                Console.WriteLine("Id = {0} | Nom = {1}", line[0], line[1]);
            }

            Console.ReadLine();





        }
    }
}
