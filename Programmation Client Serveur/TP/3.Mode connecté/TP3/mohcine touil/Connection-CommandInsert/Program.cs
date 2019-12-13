using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CommandInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           String Connectionstring = @"Datasource=PC-MOHCINE;Exercice1;Integrated security=true";
           SqlConnection conn = new SqlConnection(Connectionstring);
           */
            SqlConnection connection = new SqlConnection("Server=PC-MOHCINE;Database=Exercice1;Integrated security=true");
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Musiciens(Num_mus,Nom_mus,Num_Rep) Values (4,'Fofo',02)", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
