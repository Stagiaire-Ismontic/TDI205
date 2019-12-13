using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace tp3form
{
   public class connection
    {
        public static SqlConnection conn = null;
        public void Connectionsql()
        {
            conn = new SqlConnection(@"data source=LAPTOP-T74VUB02\MSSQLSERVE;Initial catalog=test; integrated security=true");
            conn.Open();

        }
    }
}
