using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initialiseursD_objets
{
    public class objet
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public objet()
        {
        }

        public objet(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
