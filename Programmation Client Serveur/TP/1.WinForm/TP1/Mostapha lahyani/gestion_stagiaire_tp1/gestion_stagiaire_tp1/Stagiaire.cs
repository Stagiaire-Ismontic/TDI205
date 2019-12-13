using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_stagiaire_tp1
{
    public class Stagiaire
    {
        private string cin;
        private string nomComple;
        private DateTime date;
        private string email;
        private string groupe;

        public string Cin { get => cin; set => cin = value; }
        public string NomComple { get => nomComple; set => nomComple = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Email { get => email; set => email = value; }
        public string Groupe { get => groupe; set => groupe = value; }

        public Stagiaire()
        {

        }

        public Stagiaire(string cin,string nomComple,DateTime date,string email,string groupe)
        {
            this.cin = cin;
            this.nomComple = nomComple;
            this.date = date;
            this.email = email;
            this.groupe = groupe;
        }
    }
}
