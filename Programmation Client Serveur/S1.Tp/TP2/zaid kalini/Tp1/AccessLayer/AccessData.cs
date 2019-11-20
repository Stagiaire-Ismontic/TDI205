using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tp1.AccessLayer
{
    class AccessData
    {
        public SqlConnection cn;
        SqlCommand cmd;
        public AccessData()
        {
            cn = new SqlConnection("Server =" + Properties.Resources.Server + ";Database=" + Properties.Resources.DataBase + ";Integrated security =true");
        }
        public void executeCommand(SqlParameter[] param, string stored_procedure)
        {
            cmd = new SqlCommand();
            cmd.CommandText = stored_procedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(param);
            cmd.Connection = cn;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            
        }

        public DataTable getData(SqlParameter[] param, string stored_procedure)
        {
            SqlDataAdapter adapter=new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd = new SqlCommand();
            cmd.CommandText = stored_procedure;
            cmd.CommandType = CommandType.StoredProcedure;
            if(param != null)
            cmd.Parameters.AddRange(param);
            adapter.Fill(dt);
            return dt;


        }
        public void OpenConnection()
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
        }

        public void CloseConnection()
        {
            if (cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }
    }
}
