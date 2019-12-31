using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpClient
{
    public class GestionClient
    {
        public static CC1 context = new CC1();

        public void Ajouter(Client c)
        {
            context.lstClient.Add(c);
            context.SaveChanges();
        }

        public Client RechercheById(string cinR)
        {
            foreach (var Cl in context.lstClient)
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
            context.lstClient.Remove(cs);
            context.SaveChanges();

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
            return context.lstClient.ToList();
        }
    }
}
