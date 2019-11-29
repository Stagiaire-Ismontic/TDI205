using System;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion__Stagiaire
{
    class Gestion_Stagiaire
    {
        public int Rechercher(int ID)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=gestion_stagiaire;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand($"select *from Stagiaire where id={ID}",con);
            SqlDataReader sq = cmd.ExecuteReader();
            if (sq.HasRows)
            {
                con.Close();
                return 1;
            }
            return -1;
        }
        public bool Add(Stagiaire S)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=gestion_stagiaire;Integrated Security=True");
            con.Open();

            if (S.Id>0)
            {
             SqlCommand cmd = new SqlCommand($"insert into Stagiaire values({S.Id},'{S.Nom}','{S.Prenom}',{S.Note},'{S.Id_group}','{S.Ville}')",con);
             cmd.ExecuteNonQuery();
                return true;
            }
            con.Close();
            return false;
        }
        public void Afficher()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=gestion_stagiaire;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select id,nom,prenom,note,id_group,ville from Stagiaire", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
             reader.GetInt32(1);
             reader.GetString(2);
             reader.GetString(3);
             reader.GetInt32(4);
             reader.GetString(5);
             reader.GetString(6); 
            }
            con.Close();
        }
        public bool Modifier(Stagiaire S)
        {
          
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=gestion_stagiaire;Integrated Security=True");
               con.Open();
                if (Rechercher(S.Id) != -1)
                {
               SqlCommand cmd = new SqlCommand($"update Stagiaire set nom='{ S.Nom}',prenom='{S.Prenom}',note={S.Note},id_group='{S.Id_group}',ville='{S.Ville}' where id={S.Id}",con);
                cmd.ExecuteNonQuery();
                return true;
                }
                con.Close();
                return false;
        }
        public bool Delete(int ID)
        {
            if (Rechercher(ID) != -1)
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=gestion_stagiaire;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand($"delete from Stagiaire where id = {ID}", con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            return false;
        }
    }
}
