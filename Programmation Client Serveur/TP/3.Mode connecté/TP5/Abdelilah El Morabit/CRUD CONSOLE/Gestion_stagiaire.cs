using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD_CONSOLE
{
    class GestionStagaires
    {

            SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-T03IVK2\SQLEXPRESS;Initial Catalog=GestionStagiaireEtGroupe;Integrated Security=True");
            SqlCommand cmd;
            public bool ajouter(Stagiaire s)
            {
                cnx.Open();
                if (!recherche(s.Id))
                {
                    cmd = new SqlCommand($"insert into stagiaire values({s.Id},'{s.Nom}','{s.Prenom}')", cnx);
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
                if (recherche(id))
                {
                    cmd = new SqlCommand("delete stagiaire where Id=" + id, cnx);
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
                if (recherche(s.Id))
                {
                    cmd = new SqlCommand($"update stagiaire set nom='{s.Nom}',prenom='{s.Prenom}' where id={s.Id}", cnx);
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
                cmd = new SqlCommand("select * from stagiaire", cnx);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Stagiaire s = new Stagiaire();
                    s.Id = (int)dr[0];
                    s.Nom = (string)dr[1];
                    s.Prenom = (string)dr[2];
                    lst.Add(s);
                }
                dr.Close();
                cnx.Close();
                return lst;
            }

            public bool recherche(int id)
            {

                cmd = new SqlCommand("select * from stagiaire s  where s.Id=" + id, cnx);

                SqlDataReader dr = cmd.ExecuteReader();
                bool b=dr.HasRows; ;
                dr.Close();
            return b;
                

            }
        }
    
}
