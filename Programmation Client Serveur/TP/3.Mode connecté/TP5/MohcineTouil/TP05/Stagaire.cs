using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
    class Stagaire
    {
        private int id;
        private string nom;
        private string cin;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Cin { get => cin; set => cin = value; }

        public Stagaire(int id,string nom, string cin)
        {
            this.Id = id;
            this.Nom = nom;
            this.Cin = cin;
        }

    }
}
