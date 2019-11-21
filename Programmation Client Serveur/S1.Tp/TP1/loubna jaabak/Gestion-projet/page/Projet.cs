using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page
{
 public   class Projet
    {
        public Projet() { }
        
        public string NOM1
        {
            get
            {
                return NOM;
            }

            set
            {
                NOM = value;
            }
        }

        public string PRENOM1
        {
            get
            {
                return PRENOM;
            }

            set
            {
                PRENOM = value;
            }
        }

        public int ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }


        public DateTime DateCreation1
        {
            get
            {
                return DateCreation;
            }

            set
            {
                DateCreation = value;
            }
        }


        public DateTime DateModification1
        {
            get
            {
                return DateModification;
            }

            set
            {
                DateModification = value;
            }
        }

    
        private string NOM;
        private string PRENOM;
        private int ID;
        DateTime DateCreation;
        DateTime DateModification;
        public Projet(string NOM,string PRENOM,int ID, DateTime DateCreation, DateTime DateModification)
        {  
            this.NOM = NOM;
            this.PRENOM = PRENOM;
            this.ID = ID;
            this.DateCreation = DateCreation;
            this.DateModification = DateModification;
        }

        public override string ToString()
        {
            return  "/" + this.NOM + "/" + this.PRENOM+"/"+this.ID+" / "+this.DateCreation+" / "+this.DateModification;
        }
    }
}
