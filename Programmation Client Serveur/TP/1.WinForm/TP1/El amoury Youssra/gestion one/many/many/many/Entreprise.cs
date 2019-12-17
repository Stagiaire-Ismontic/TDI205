using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace many
{
   public  class Entreprise
    {
       // private Employer ls = new Employer();
        private int id;
        private string nom;



      

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
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

        public Entreprise(int id,string nom/*,Employer e*/)
        {
            this.Nom = nom;
            this.Id = id;
          //  this.ls = e;
         
           
        }
        public Entreprise()
        { }

        public override string ToString()
        {
            return Nom;
        }
    }
}
