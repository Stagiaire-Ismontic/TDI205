using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsF.Classes;

namespace WindowsF.Services
{
    public class GestionCli
    {
        Connexion C = new Connexion();

        public Client RechercheId(int id)
        {
            string S = "Select * from Client s where s.IdClient="+id;
            SqlDataReader Dr = C.ExecuteS(S);
            Client Cr = new Client();
            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Cr = new Client(Dr.GetInt32(0), Dr.GetString(1));
                }
                return Cr;
            }
            return null;
        }
        public Client RechercheNom(string Nom)
        {
            string S = "Select * from Client s where s.Nom='" +Nom+"'";
            SqlDataReader Dr = C.ExecuteS(S);
            Client Cr = new Client();
            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Cr = new Client(Dr.GetInt32(0), Dr.GetString(1));
                }
                return Cr;
            }
            return null;
        }

        public bool Ajouter(Client St)
        {
            Client Cr = new Client();
            Cr = RechercheId(St.Id);
            if (Cr == null)
            {
                string S = "Insert into Client values(" + St.Id + ",'" + St.Nom + "')";
                C.ExecuteR(S);
                return true;
            }
            return false;
        }

        public bool Supprimer(Client St)
        {
            Client Cr = new Client();
            Cr = RechercheId(St.Id);
            if (Cr != null)
            {
                string S = "Delete from Client where IdClient=" + St.Id;
                C.ExecuteR(S);
                return true;
            }
            return false;
        }

        public bool Modifier(Client St)
        {
            
            Client Cr = new Client();
            Cr = RechercheId(St.Id);
            if (Cr != null)
            {
                string S = "Update Client set Nom= '" + St.Nom + "' where IdClient=" + St.Id;
                C.ExecuteR(S);
                return true;
            }
            return false;
        }

        public List<Client> Afficher()
        {
            List<Client> listClient = new List<Client>();
            string S = "Select * from Client";
            SqlDataReader Rd = C.ExecuteS(S);
            while (Rd.Read())
            {
                listClient.Add(new Client(Rd.GetInt32(0), Rd.GetString(1)));
            }
            C.Close();
            return listClient;
        }

    }
}
