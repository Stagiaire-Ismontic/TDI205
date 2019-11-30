
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    public class GestionEmployer
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-T03IVK2\SQLEXPRESS;Initial Catalog=GestionEmployer;Integrated Security=True");
        SqlCommand cmd;
        public bool ajouter(Employer a)
        {
            cnx.Open();
            if (recherche(a.Id) == -1)
            {
                cmd = new SqlCommand($"insert into stagiaire values({a.Id},'{a.Nom}','{a.Prenom}')", cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();
                return true;
            }
            cnx.Close();
            return false;
        }
        public bool suprimer(int id)
        {
            cnx.Open();
            if (recherche(id) != -1)
            {
                cmd = new SqlCommand("delete Employer where Id=" + id, cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();
                return true;
            }
            cnx.Close();
            return false;

        }

        public bool modifier(Employer a)
        {
            cnx.Open();
            if (recherche(a.Id) != -1)
            {
                cmd = new SqlCommand($"update Employer set nom='{a.Nom}',prenom='{a.Prenom}' where id={a.Id}", cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();
                return true;
            }
            cnx.Close();
            return false;
        }

        public List<Employer> affiche()
        {
            List<Employer> lst = new List<Employer>();
            cnx.Open();
            cmd = new SqlCommand("select * from Employer", cnx);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Employer a = new Employer();
                a.Id = (int)dr[0];
                a.Nom = (string)dr[1];
               a.Prenom = (string)dr[2];
                lst.Add(a);
            }
            dr.Close();
            cnx.Close();
            return lst;
        }

        public int recherche(int id)
        {

            cmd = new SqlCommand("select * from Employer a  where s.Id=" + id, cnx);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Close(); return 1;
            }
            dr.Close();
            return -1;

        }
    }
}