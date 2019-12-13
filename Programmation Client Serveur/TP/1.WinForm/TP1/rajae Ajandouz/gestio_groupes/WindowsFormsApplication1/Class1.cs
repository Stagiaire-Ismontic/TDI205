using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Group
    {
       private int numero;
      private  string nom;

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

  
        public Group() { }

        public Group(int id,string nom)
        {
            this.numero = id;
            this.nom = nom;

        }

        

    }
}
