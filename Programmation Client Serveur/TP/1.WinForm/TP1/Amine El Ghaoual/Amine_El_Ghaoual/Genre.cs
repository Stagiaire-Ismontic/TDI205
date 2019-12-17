using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amine_El_Ghaoual
{
    public class Genre
    {
        public int id { get; set; }

        public string type { get; set; }

        public Genre()
        {

        }

        public Genre(string type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return type;
        }
    }
}
