using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppel_c
{
    public class etudiant
    {
        int id;
        string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public etudiant() { }
        public etudiant(int id)
        {
            this.id = id;
        }
    }
}
