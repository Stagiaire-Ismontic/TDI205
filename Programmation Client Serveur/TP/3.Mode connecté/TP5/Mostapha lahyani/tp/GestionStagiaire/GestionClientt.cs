using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace GestionStagiaire
{
    public class GestionClientt
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Client;Integrated Security=True");
        SqlCommand cmdd;
        Client cl;
       static List<Client> lstClientt = new List<Client>();

        public SqlDataReader Recherche(int id)
        {
            conn.Open();
            cmdd = new SqlCommand($"SELECT * FROM [dbo].[tblClient] where id={id}", conn);
            SqlDataReader READ = cmdd.ExecuteReader();
            if (READ.HasRows)
            {
                conn.Close();
                return READ;
            }
            conn.Close();
            return null;  
        }

        public void affiche2(int id)
        {
            using (conn)
            {
                conn.Open();
                cmdd=new SqlCommand($"select * from [dbo].[tblClient] where id={id}", conn);
                using (SqlDataReader dr = cmdd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3] + "\t" + dr[4] + "\t" + dr[5]);

                    }
                }
            }
        }

        public bool Delete(int id)
        {
            if (Recherche(id) != null)
            {
                using (conn)
                {
                    conn.Open();
                    cmdd = new SqlCommand($"delete from [dbo].[tblClient] where id={id}", conn);
                    cmdd.ExecuteNonQuery();
                    return true;
                }
            }
            return false;
        }

        public bool Ajouter(Client S)
        {
            using (conn)
            {
                if (Recherche(S.Id) != null)
                {
                    return false;
                }
                conn.Open();
                cmdd = new SqlCommand($"insert into [dbo].[tblClient] values('{S.Cin }',{S.Id},'{ S.Fname }','{ S.Lname}',{S.Nb_Phone},'{S.Email}')", conn);
                cmdd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
        }


        public bool Modifie(Client c)
        {

            if (Recherche(c.Id) != null)
            {
                conn.Open();
                cmdd = new SqlCommand($"Update [dbo].[tblClient] set Cin='{c.Cin}',Fname='{c.Fname}',Lname='{c.Lname}',Nb_Phone={c.Nb_Phone},Email='{c.Email}' where Id ={c.Id}",conn);
                cmdd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public List<Client> afficher()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Client;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[tblClient]", conn);
                using (SqlDataReader Reader = cmd.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        cl = new Client();
                        cl.Cin = (string)Reader[0];
                        cl.Id = (int)Reader[1];
                        cl.Fname = (string)Reader[2];
                        cl.Lname = (string)Reader[3];
                        cl.Nb_Phone = (int)Reader[4];
                        cl.Email = (string)Reader[5];
                        lstClientt.Add(cl);
                    }
                }
            }
            return lstClientt ;
        }
    }
}
