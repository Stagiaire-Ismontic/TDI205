using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsF.Classes;

namespace WindowsF.Services
{
    public class GestionFac
    {
        Connexion C = new Connexion();

        GestionCli cc = new GestionCli();

        public Facture Recherche(int id)
        {
            string S = "Select * from Facture s where s.IdFacture=" + id;
            SqlDataReader Rd = C.ExecuteS(S);
            Facture F = new Facture();
            if (Rd.HasRows)
            {
                while (Rd.Read())
                {
                   F = new Facture(Rd.GetInt32(0), Rd.GetString(1), double.Parse(Rd.GetDecimal(2).ToString()),cc.RechercheId(Rd.GetInt32(3)));
                }
                return F;
            }
            return null;
        }

        public void Ajouter(Facture St)
        {
            Client c = cc.RechercheNom(St.Client.Nom);
            string S = "Insert into Facture values('" + St.Titre + "'," + St.Somme + "," + c.Id + ")";
            C.ExecuteR(S);
        }

        public bool Supprimer(Facture St)
        {
            Facture F = new Facture();
            F = Recherche(St.Id);
            if (F != null)
            {
                string S = "Delete from Facture where IdFacture=" + St.Id;
                C.ExecuteR(S);
                return true;
            }
            return false;
        }

        public bool Modifier(Facture St)
        {
            Facture F = new Facture();
            F = Recherche(St.Id);
            if (F != null)
            {
                Client c = cc.RechercheNom(St.Client.Nom);
                string S = "Update Facture set Titre= '" + St.Titre + "',Somme=" + St.Somme + ",ClientId=" + c.Id + " where IdFacture=" + St.Id;
                C.ExecuteR(S);
                return true;
            }
            return false;
        }

        public List<Facture> Afficher()
        {
            List<Facture> listFacture = new List<Facture>();
            string S = "Select * from Facture";
            SqlDataReader Rd = C.ExecuteS(S);
            while (Rd.Read())
            {
                listFacture.Add(new Facture(Rd.GetInt32(0), Rd.GetString(1), double.Parse(Rd.GetDecimal(2).ToString()), cc.RechercheId(Rd.GetInt32(3))));
            }
            C.Close();
            return listFacture;
        }


    }
}

