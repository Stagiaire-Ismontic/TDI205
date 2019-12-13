using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassConx
{
    public class GestionnaireStagiaires
    {
        Connexion Connn = new Connexion();

        public Stagiaire Recherche(int id)
        {
            string   requete = "Select * from Stagiaire s where s.Id=" + id;
            SqlDataReader dr = Connn.ExecuteSelect(requete);
            dr.Read();
            Stagiaire s = new Stagiaire(dr.GetInt32(0), dr.GetString(1), dr.GetString(2),dr.GetString(3));
            Connn.Close();
            return s;
        }

        public void Ajouter(Stagiaire s)
        {

            Stagiaire St = new Stagiaire();
            St = this.Recherche(s.Id);
            if (St != null)
            {
                string Req = "insert into Stagiaires (Id,Cin,Nom,Groupe) Values(" + s.Id + ",'" + s.Cin + "','" + s.Nom + "','" + s.Groupe + "')";
                Connn.ExecuteSQL(Req);
            }
        }

        public void Supprimer(Stagiaire Sat)
        {

            Stagiaire St = new Stagiaire();
            St = this.Recherche(Sat.Id);
            if (St != null)
            {
                string Req = "Delete from Stagiaire where Id=" + Sat.Id;
                Connn.ExecuteSQL(Req);
            }
            
        }

        public void Modifier(Stagiaire s)
        {

            Stagiaire St = new Stagiaire();
            St = this.Recherche(s.Id);
            if (St != null)
            {
                string Req = "Update Stagiaire set Cin = '" + s.Cin + "',Nom='" + s.Nom + "',Groupe='" + s.Groupe + "' where Id=" + s.Id;
                Connn.ExecuteSQL(Req);
            }
            
        }

        public List<Stagiaire> Afficher()
        {
            List<Stagiaire> listesStagiaires = new List<Stagiaire>();
            string Req = "Select * from Stagiaires";
            SqlDataReader Dr = Connn.ExecuteSelect(Req);
            while (Dr.Read())
            {
                listesStagiaires.Add(new Stagiaire(Dr.GetInt32(0), Dr.GetString(1), Dr.GetString(2),Dr.GetString(3)));
            }
            Connn.Close();
            return listesStagiaires;
        }

       


    }
}
