using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Etudiant
{
    public class Etudiant
    {
        int Etud_Id;
        string Etud_Name;
        string Etud_Tel;

        public int Etud_Id1
        {
            get
            {
                return Etud_Id;
            }

            set
            {
                Etud_Id = value;
            }
        }


            

        public string Etud_Tel1
        {
            get
            {
                return Etud_Tel;
            }

            set
            {
                Etud_Tel = value;
            }
        }

        public string Etud_Name1
        {
            get
            {
                return Etud_Name;
            }

            set
            {
                Etud_Name = value;
            }
        }

        public Etudiant()
        {

        }

        public Etudiant(int id, string nom, string tel)
        {
            this.Etud_Id1 = id;
            this.Etud_Name1 = nom;
            this.Etud_Tel = tel;
        }
    }
}
