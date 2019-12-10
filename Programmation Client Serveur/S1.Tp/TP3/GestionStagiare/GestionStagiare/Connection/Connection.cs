using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStagiare.Connection
{
    class Connection
    {
        public SqlConnection cn;
        public Connection()
        {
            cn = new SqlConnection(@"server=DESKTOP-CT98AF6\SQLEXPRESS;database=GestionStagiare; Integrated Security = true;");
        }
        public void Open()
        {
            if(cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }
        }
        public void Close()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }
        public int execute(string Cmd_txt)
        {
            SqlCommand cmd = new SqlCommand(Cmd_txt, cn);
            cn.Open();
           int cmp= cmd.ExecuteNonQuery();
            cn.Close();
            return cmp;
        }
        public List<Stagiare> GetData(string Cmd_txt)
        {
            SqlDataReader reader;
            List<Stagiare> lst = new List<Stagiare>();
            SqlCommand cmd = new SqlCommand(Cmd_txt);
            cn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lst.Add(new Stagiare((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3]));
            }
            cn.Close();
            return lst;
        }
    }
}
