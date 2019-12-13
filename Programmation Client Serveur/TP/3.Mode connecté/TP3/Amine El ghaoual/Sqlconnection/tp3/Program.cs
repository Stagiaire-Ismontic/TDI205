using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace tp3
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conx = new SqlConnection(@"Data Source=DESKTOP-T03IVK2\SQLEXPRESS;Initial Catalog=GestionProjets;Integrated Security=True");
            conx.Open();
            SqlCommand cmd = new SqlCommand("insert into projets(id,titre,nombre_jours_realisation) values(1,'titre1'-++,3)", conx);
            cmd.ExecuteNonQuery();
            conx.Close();
        }
    }
}
