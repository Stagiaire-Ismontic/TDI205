using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Tp1.AccessLayer;

namespace Tp1.BL
{
    class AjouterParRequête
    {
        AccessData data = new AccessData();
        SqlCommand cmd;
        public AjouterParRequête()
        {

        }
       public AjouterParRequête(Stagiare s)
        {
            cmd = new SqlCommand("Insert into stg_tb values(" + s.NumStagiare + ",'" + s.Nom + "','" + s.Prenom + "'," + s.Age + ",'"+s.sexe+"','"+s.situation+"')", data.cn);
            data.OpenConnection();
            cmd.ExecuteNonQuery();
            data.CloseConnection();
        }
    }
}
