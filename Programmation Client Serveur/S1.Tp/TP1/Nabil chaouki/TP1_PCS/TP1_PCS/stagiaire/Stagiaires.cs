using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_PCS
{
    public class Stagiaires
    {
        int IdS;
        string NomS;
        string Prenom;
        int age;

        public int IdS1
        {
            get
            {
                return IdS;
            }

            set
            {
                IdS = value;
            }
        }

        public string NomS1
        {
            get
            {
                return NomS;
            }

            set
            {
                NomS = value;
            }
        }

        public string Prenom1
        {
            get
            {
                return Prenom;
            }

            set
            {
                Prenom = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        public Stagiaires( int IdS,string NomS,string Prenom,int age)
        {
            this.IdS1 = IdS;
            this.NomS = NomS;
            this.Prenom = Prenom;
            this.age = age;

        }
    }
}
