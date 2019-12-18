using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class Salle
    {
        private int id;
        private string description;

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

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

        public Salle()
        {

        }
        public Salle(int id,string description)
        {
            Id = id;
            Description = description;
        }
    }
}
