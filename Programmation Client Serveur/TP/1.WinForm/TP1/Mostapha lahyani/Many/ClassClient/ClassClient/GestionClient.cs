using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassClient
{
    public class GestionClient
    {
        public static List<Client> lst_Client = new List<Client>();

        public void Ajouter(Client c)
        {
            lst_Client.Add(c);
        }

        public Client RechercheById(string cinR)
        {
            foreach (var Cl in lst_Client)
            {
                if (Cl.Cin == cinR)
                {
                    return Cl;
                }
            }
            return null;
        }

        public void Delete(Client c)
        {
            Client cs = this.RechercheById(c.Cin);
            lst_Client.Remove(cs);

        }

        public void Modifier(Client C)
        {
            Client cl = this.RechercheById(C.Cin);
            cl.Cin = C.Cin;
            cl.Id = C.Id;
            cl.Fname = C.Fname;
            cl.Lname = C.Lname;
            cl.Email = C.Email;
            cl.Nb_Phone = C.Nb_Phone;
        }

        public List<Client> Get()
        {
            ///kat eti liste kamla
            return lst_Client;
        }

    }
}
