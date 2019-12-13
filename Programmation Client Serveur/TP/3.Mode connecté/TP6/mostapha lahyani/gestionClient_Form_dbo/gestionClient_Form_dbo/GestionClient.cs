using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionClient_Form_dbo
{
    public class GestionClient
    {
        public static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Client;Integrated Security=True");
        SqlCommand cmdd;
        Client cl;
        public static List<Client> lstClientt = new List<Client>();
        public static void OPEN()
        {
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            conn.Open();
        }
        public static void CLOSE()
        {
            conn.Close();

        }

        public List<Client> Recherche(int id)
        {
            cmdd = new SqlCommand($"SELECT * FROM [dbo].[tblClient] where id={id}", conn);
            
            using (SqlDataReader READ = cmdd.ExecuteReader())
            {
                if (READ.HasRows)
                {
                    List<Client> lst = new List<Client>();
                    while (READ.Read())
                    {
                        lst.Add(new Client(READ[0].ToString(), int.Parse(READ[1].ToString()), READ[2].ToString(), READ[3].ToString(),int.Parse(READ[4].ToString()), READ[5].ToString()));
                    }
                    return lst;
                }
                return null;
            }
        }

        public void affiche2(int id)
        {
                cmdd = new SqlCommand($"select * from [dbo].[tblClient] where id={id}", conn);
                using (SqlDataReader dr = cmdd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3] + "\t" + dr[4] + "\t" + dr[5]);

                    }
                }
        }

        public bool Delete(int id)
        {
            if (Recherche(id) != null)
            {
                    cmdd = new SqlCommand($"delete from [dbo].[tblClient] where id={id}", conn);
                    cmdd.ExecuteNonQuery();
                    return true;
            }
            return false;
        }

        public bool Ajouter(Client S)
        {
                if (Recherche(S.Id) != null)
                {
                    throw new Exception("Existe deja");
                }
                cmdd = new SqlCommand($"insert into [dbo].[tblClient] values('{S.Cin }',{S.Id},'{ S.Fname }','{ S.Lname}',{S.Nb_Phone},'{S.Email}')", conn);
                cmdd.ExecuteNonQuery();
                return true;
        }


        public bool Modifie(Client c)
        {

            if (Recherche(c.Id) != null)
            {
                cmdd = new SqlCommand($"Update [dbo].[tblClient] set Cin='{c.Cin}',Fname='{c.Fname}',Lname='{c.Lname}',Nb_Phone={c.Nb_Phone},Email='{c.Email}' where Id ={c.Id}", conn);
                cmdd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        public List<Client> afficher()
        {
            

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
                return lstClientt;
            
           
        }
        //public List<Client> Get()
        //{
        //    ///kat eti liste kamla
        //    conn.Open();
        //    cmdd = new SqlCommand("SELECT * FROM [dbo].[tblClient]", conn);
        //    List<Client> lst = new List<Client>();
        //    using (SqlDataReader dr = cmdd.ExecuteReader())
        //    {
        //        while (dr.Read())
        //        {
        //            lst.Add(new Client { Cin = dr[0].ToString(), Id = dr.GetInt32(1), Fname = dr[2].ToString(), Lname = dr[3].ToString(), Nb_Phone = dr.GetInt32(4), Email = dr[5].ToString() });
        //        }
        //    }
        //    return lstClientt;
        //}
    }
}
