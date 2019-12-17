using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1gestionbudget
{
  public  class Budget
    {
        public int id;
        private string type_salaire;
        

        public string Type_salaire { get => type_salaire; set => type_salaire = value; }
        

        public Budget(string Type_salaire, int id)
        {
            this.Type_salaire = Type_salaire;
            
        }
        public Budget()
        {

        }
    }
}
