using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class etudiant:etablissement
    {
        int id;
        string nom;
        string prenom;
        string cin;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Cin { get => cin; set => cin = value; }
        public etudiant() { }
        public etudiant(int i, string n, string p, string cin,string nomEtablissement,string adr) : base(nomEtablissement, adr )
        {
            this.Id = i;
            this.Nom = n;
            this.Prenom = p;
            this.Cin = cin;

        }
    }
}
