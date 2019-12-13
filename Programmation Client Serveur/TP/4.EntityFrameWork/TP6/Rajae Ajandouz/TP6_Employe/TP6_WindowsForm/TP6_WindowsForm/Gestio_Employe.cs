using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_WindowsForm
{
    class Gestion_Employe
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Employe;Integrated Security=True");
        SqlCommand cmd;
        //methode de connection
        public int Execute_SQL(string requete)
        {
            cmd = new SqlCommand(requete, conn);

            conn.Open();

           int value= cmd.ExecuteNonQuery();

            conn.Close();
            return value;
           

        }

        public  SqlDataReader Execute_Select(string requete)
        {
            cmd = new SqlCommand(requete, conn);
            conn.Open();
            return cmd.ExecuteReader();

        }

        public  void SQL_Close()
        {
            conn.Close();
        }




        string Requete;
//methode d'ajouter
        public void Ajouter(Employe E)
        {
            Requete = $"insert into Employe values({E.id},'{E.nom}','{E.prenom}','{E.adress}')";
            Execute_SQL(Requete);

        }
//methode supprimer
        public void Supprimer(int id)
        {
            Requete = $"Delete from Employe where id={id}";
            Execute_SQL(Requete);
        }
//methode modifier

        public void Modifier(Employe E)
        {
            Requete = $"Update Employe set Nom='{E.nom}',Prenom='{E.prenom}',adress='{E.adress}' where id={E.id}";
            Execute_SQL(Requete);
        }
   
//methode Affichier

        public List<Employe> Affichier()
        {
            List<Employe> list_Empl = new List<Employe>();
            Requete = "select * from Employe";
            SqlDataReader rd = Execute_Select(Requete);
            while(rd.Read())
            {
                list_Empl.Add(new Employe(rd.GetInt32(0),rd.GetString(1), rd.GetString(2), rd.GetString(3)));
            }

            SQL_Close();

            return list_Empl;
        }

        //methode de recherche
        public int Recherche(int id)
        {
            Requete = $"select * from  Employe where id={id}";

            SqlDataReader rd = Execute_Select(Requete);
            while(rd.HasRows)
            {
                return 1;
            }
            SQL_Close();
            return -1;
        }




    }
}
