using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ZaidKalini.ModeDeconnecter
{
    class ModuleService
    {
        
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        SqlConnection cn;
        SqlCommandBuilder builder;
        
        /// <summary>
        /// pour Remplire datatbale 
        /// </summary>
        void fillData()
        {
            adapter = new SqlDataAdapter("select * from Module", cn);
            dt.Rows.Clear();
            adapter.Fill(dt);
        }
        public ModuleService()
        {
            cn = new SqlConnection(@"Data Source=\\.\pipe\MSSQL$SQLEXPRESS\sql\query;Initial Catalog=Etablissment;Integrated Security=True");
            fillData();
        }
        public int Ajouter(BusnissLayer.Modules module)
        {
            var dr = dt.NewRow();
            dr[0] = module.Id;
            dr[1] = module.Nom_module;
            dt.Rows.Add(dr);
            builder = new SqlCommandBuilder(adapter);
            var i= adapter.Update(dt);
            dt.Rows.Clear();
            fillData();
            return i;
        }
        public int Modifier(BusnissLayer.Modules module)
        {            
            DataRow dr=(from DataRow d in dt.Rows where Convert.ToInt32(d[0]) == module.Id select d).First();
            if (dr == null)
                return -1;
            dr[1] = module.Nom_module;
            builder = new SqlCommandBuilder(adapter);
            
            var i = adapter.Update(dt);

            fillData();
            return 1;


        } 
        public int Delete(int id)
        {
            DataRow dr = (from DataRow d in dt.Rows where Convert.ToInt32(d[0]) == id select d).First();
            if (dr == null)
                return -1;
            dr.Delete();
            builder = new SqlCommandBuilder(adapter);
            var i = adapter.Update(dt);
            fillData();
            return 1;
        }
        /// <summary>
        ///pour ajouter id auto incrimenter
        /// </summary>
        /// <returns></returns>
        public int GetId()
        {
            return dt.Rows.Count+1;
        }
        public DataTable Show()
        {
            return dt;
        }
        public DataTable Show(string str)
        {
            string cmd = "select * from Module where Nom like '%" + str + "%'";
            adapter = new SqlDataAdapter(cmd, cn);
            dt.Rows.Clear();
            adapter.Fill(dt);
            return dt;
        }
    }
}
