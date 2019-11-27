using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TP05
{
    class GestionStagaire
    {
        string cs = "Server=PC-MOHCINE;Database=GestionStagaire;Integrated security=true";
        SqlCommand cmd = new SqlCommand();

        public bool Ajouter(Stagaire NewStagaire)
        {

            using (SqlConnection con = new SqlConnection(cs))
            {
                if (NewStagaire.Id == 0)
                    return false;
                cmd.CommandText = "insert into Stagaire values(" + NewStagaire.Id + ",'" + NewStagaire.Nom + "','" + NewStagaire.Cin + "')";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public int Rechercher(int id)
        {
            SqlConnection con = new SqlConnection(cs);
            cmd.CommandText = "select *from Stagaire where id=" + id + "";
            cmd.Connection = con;
            con.Open();      
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
                return 1;
            return -1;
        }

        public bool Supprimer(int id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                if (Rechercher(id) != -1)
                {
                    cmd.CommandText = "delete from Stagaire where id=" + id + "";
                    con.Open();
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
        }

        public bool Modifier(Stagaire stagaire)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                if (Rechercher(stagaire.Id) != -1)
                {
                    cmd.CommandText = "update Stagaire set nom='"+stagaire.Nom+"',cin='"+stagaire.Cin+ "' where id=" + stagaire.Id + "";
                    con.Open();
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
        }

        public void Afficher()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                cmd.CommandText = "select *from Stagaire";
                cmd.Connection = con;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    Console.WriteLine(sdr[0]+" "+sdr[1]+" "+sdr[2]);
                }
            }
        }

    }
}
