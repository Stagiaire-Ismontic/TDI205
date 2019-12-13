using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    class GestionStagiaire
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-PIUCF0K\SQLEXPRESS;Initial Catalog=test1;Integrated Security=True");

        SqlCommand cmd;
        public bool ajouter(stagiaire s)
        {
            cn.Open();
            if (rechercher(s.Id) == -1)
            {
                cmd = new SqlCommand($"insert into stg values({s.Id},'{s.Nom}','{s.Prenom}')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            cn.Close();
            return false;
        }
        public bool supprimer(int id)
        {
            cn.Open();
            if (rechercher(id) != -1)
            {
                cmd = new SqlCommand("delete stg where Id=" + id, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            cn.Close();
            return false;

        }
        public bool modifier(stagiaire s)
        {
            cn.Open();
            if (rechercher(s.Id) != -1)
            {
                cmd = new SqlCommand($"update stg set nom='{s.Nom}',prenom='{s.Prenom}' where id={s.Id}", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            cn.Close();
            return false;
        }
        public List<stagiaire> affiche()
        {
            List<stagiaire> lst = new List<stagiaire>();
            cn.Open();
            cmd = new SqlCommand("select * from stg", cn);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                stagiaire s = new stagiaire();
                s.Id = (int)r[0];
                s.Nom = (string)r[1];
                s.Prenom = (string)r[2];
                lst.Add(s);
            }
            r.Close();
            cn.Close();
            return lst;
        }

        public int rechercher(int id)
        {

            cmd = new SqlCommand("select * from stg s  where s.Id=" + id, cn);

            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                r.Close(); return 1;
            }
            r.Close();
            return -1;

        }

    }
}


