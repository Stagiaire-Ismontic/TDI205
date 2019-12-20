using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    public class Connexion
    { 

        SqlConnection Cnx = new SqlConnection(@"data source=(localdb)\MSSQLLocalDB;initial catalog=GestionFacture;integrated security=True");

        SqlCommand Cmd;
        
        public int ExecuteR(string R)
        {
            Cmd = new SqlCommand(R,Cnx);
            Open();
            int value = Cmd.ExecuteNonQuery();
            Close();
            return value;
        } 

        public SqlDataReader ExecuteS(string R)
        {
            Cmd = new SqlCommand(R, Cnx);
            Open();
            return Cmd.ExecuteReader();
        }

        public void Close()
        {
            Cnx.Close();
        }

        public void Open()
        {
            if (Cnx.State == System.Data.ConnectionState.Open)
            {
                Cnx.Close();
            }
            Cnx.Open();
        }
    }
}
