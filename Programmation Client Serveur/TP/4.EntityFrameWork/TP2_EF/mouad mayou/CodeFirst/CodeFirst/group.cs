using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class group
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public group()
        {

        }
        public group(int id,string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }
    }
}
