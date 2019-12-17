using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacture
{
    public class GestionClient
    {
        public static List<Client> List_Client = new List<Client>();


        public static int Indice;

        public void Ajouter(Client C)
        {
            C.ClientId = ++Indice;
            List_Client.Add(C);
        }

        public Client Recherche(int Id)
        {
            List_Client.SingleOrDefault(s => s.ClientId == Id);
            return null;
        }

        public bool Supprimer(int Id)
        {

            Client Ct = Recherche(Id);
            if (Ct != null)
            {
                List_Client.Remove(Ct);
                return true;
            }
            return false;

        }

        public bool Modifier(Client C)
        {

            Client Ct = Recherche(C.ClientId);
            if (Ct!= null)
            {
                Ct.Nom = C.Nom;
                return true;
            }
            return false;
        }

        public List<Client> Donne()
        {
            return List_Client;
        }
    }
}
