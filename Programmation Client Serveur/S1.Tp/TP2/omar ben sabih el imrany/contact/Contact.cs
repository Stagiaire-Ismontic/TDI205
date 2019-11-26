using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact
{
    public class Contact
    {
        private string ide;
        private string nom;
        private string email;

        public string Ide { get => ide; set => ide = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Email { get => email; set => email = value; }

        public Contact (string ide,string nom,string email)
        {
            
            this.ide = ide;
            this.nom = nom;
            this.email = email;
        }

        public static bool valide(string email)
        {
            int i;
            if (email[0] >= '0' && email[0] <= '9') return false;
            for ( i = 0; email[i]!='@'; i++)
            {
                if (email[i] < '0' ||( email[i] > '9' && email[i] < 'a') || email[i] > 'z' ||)
                    return false;
               
            }
           // Console.WriteLine("Fg");
            string str = email.Substring(i, email.Length-i);
            if ((str == "@gmail.com" || str == "@gmail.fr")&&i!=0)
                return true;
            return false;


        }
    }
}
