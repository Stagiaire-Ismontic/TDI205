using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_PCS
{
    public class GROUPE
    {
        string NomG;
        int NBS;
        string Filiere;

        public string NomG1
        {
            get
            {
                return NomG;
            }

            set
            {
                NomG = value;
            }
        }

        public int NBS1
        {
            get
            {
                return NBS;
            }

            set
            {
                NBS = value;
            }
        }

        public string Filiere1
        {
            get
            {
                return Filiere;
            }

            set
            {
                Filiere = value;
            }
        }
        public GROUPE(string NomG,int NBS,string Filiere)
        {
            this.NomG = NomG;
            this.NBS = NBS;
            this.Filiere = Filiere;
        }
        public override string ToString()
        {
            return "NomG" + this.NomG + "NBs" + this.NBS + "Filiere" + this.Filiere;
        }
    }

}
