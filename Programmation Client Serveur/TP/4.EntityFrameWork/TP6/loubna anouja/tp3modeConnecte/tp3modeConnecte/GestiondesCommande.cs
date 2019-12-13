using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3modeConnecte
{
    public class GestiondesCommande
    {
        string requete;
        public GestiondesCommande() { }
        public void Ajouter(commande c)
        {
            requete = "insert into commande  (Id,Code,Nom)Values(" + c.Id + ",'" + c.Code + "','" + c.Nom +"')";
            MyConnexion.ExecuteSQL(requete);
        }
        public void Supprimer(int id)
        {
            requete = "Delete from commande  where id=" + id + "";
            MyConnexion.ExecuteSQL(requete);
        }
        public void Modifier(commande s)
        {
            requete = "Update commande  set Code = '" + s.Code + "',Nom='" + s.Nom + "";
            MyConnexion.ExecuteSQL(requete);
        }
        public List<commande> Afficher()
        {
            List<commande> listesCommandes = new List<commande>();
            requete = "Select * from commande";
            SqlDataReader dr = MyConnexion.ExecuteSelect(requete);
            while (dr.Read())
            {
                commande g = new commande(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString());
                listesCommandes.Add(g);
            }
            MyConnexion.Close();
            return listesCommandes;
        }
    }
}
