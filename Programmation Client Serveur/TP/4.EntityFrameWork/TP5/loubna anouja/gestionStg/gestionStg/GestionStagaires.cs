using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace gestionStg
{
    class GestionStagaires
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-T03IVK2\SQLEXPRESS;Initial Catalog=stgrs;Integrated Security=True");
        SqlCommand cmd;
        public bool ajouter(Stagiaire s)
        {
            cnx.Open();
            if (rechercher(s.Id) == -1)
            {
                cmd = new SqlCommand($"insert into stg values({s.Id},'{s.Nom}','{s.Prenom}')", cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();
                return true;
            }
            cnx.Close();
            return false;
        }
        public bool supprimer(int id)
        {
            cnx.Open();
            if (rechercher(id) != -1)
            {
                cmd = new SqlCommand("delete stg where Id=" + id, cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();
                return true;
            }
            cnx.Close();
            return false;

        }

        public bool modifier(Stagiaire s)
        {
            cnx.Open();
            if (rechercher(s.Id) != -1)
            {
                cmd = new SqlCommand($"update stg set nom='{s.Nom}',prenom='{s.Prenom}' where id={s.Id}", cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();
                return true;
            }
            cnx.Close();
            return false;
        }

        public List<Stagiaire> affiche()
        {
            List<Stagiaire> lst = new List<Stagiaire>();
            cnx.Open();
            cmd = new SqlCommand("select * from stg", cnx);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                Stagiaire s = new Stagiaire();
                s.Id = (int)r[0];
                s.Nom = (string)r[1];
                s.Prenom = (string)r[2];
                lst.Add(s);
            }
            r.Close();
            cnx.Close();
            return lst;
        }

        public int rechercher(int id)
        {

            cmd = new SqlCommand("select * from stg s  where s.Id=" + id, cnx);

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
