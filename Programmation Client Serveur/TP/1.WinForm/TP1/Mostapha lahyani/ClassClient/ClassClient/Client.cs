using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassClient
{
    public class Client
    {
        private string cin;
        private int id;
        private string fname;
        private string lname;
        private int nb_Phone;
        private string email;


        public string Cin { get => cin; set => cin = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public int Nb_Phone { get => nb_Phone; set => nb_Phone = value; }
        public string Email { get => email; set => email = value; }
        public int Id { get => id; set => id = value; }

        public Client()
        {

        }

        public Client(string Cin,int id, string Fname, string Lname, int Nb_Phone, string Email)
        {
            this.Cin = Cin;
            this.id = id;
            this.Fname = Fname;
            this.Lname = Lname;
            this.Nb_Phone = Nb_Phone;
            this.Email = Email;
        }

        public override string ToString()
        {
            return "CIN: " + this.Cin+"ID: " + this.id + "First name " + this.Fname + "Last name: " + this.Lname + "nb Phone: " + this.Nb_Phone + "Email:" + this.Email;
        }

    }
}
