using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class etablissement
    {
        string nomEtablissement;
        string adresse;

        public string NomEtablissement { get => nomEtablissement; set => nomEtablissement = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public etablissement() { }
        public etablissement(string n,string ad)
        {
            NomEtablissement = n;
            Adresse = ad;
        }

    }
}
