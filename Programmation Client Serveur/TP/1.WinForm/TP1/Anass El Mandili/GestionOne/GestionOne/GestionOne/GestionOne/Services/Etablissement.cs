using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionOne.Services
{
   public class Etablissement
    {
        int Etabli_Id;
        string Etabli_Nom;
        string Etabli_Des;
        public Etablissement(int i,string n,string d)
        {
            Etabli_Id1 = i;
            Etabli_Nom1 = n;
            Etabli_Des1 = d;
        }
        public int Etabli_Id1
        {
            get
            {
                return Etabli_Id;
            }

            set
            {
                Etabli_Id = value;
            }
        }

        public string Etabli_Nom1
        {
            get
            {
                return Etabli_Nom;
            }

            set
            {
                Etabli_Nom = value;
            }
        }

        public string Etabli_Des1
        {
            get
            {
                return Etabli_Des;
            }

            set
            {
                Etabli_Des = value;
            }
        }
    }
}
