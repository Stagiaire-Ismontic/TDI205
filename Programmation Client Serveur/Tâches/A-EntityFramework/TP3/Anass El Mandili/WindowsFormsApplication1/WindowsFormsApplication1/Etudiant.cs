using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Etudiant
    {
        public int Id { get; set; }      
        public string Etud_Name { get; set; }
        public string Etud_Tel { get; set; }
        public Etudiant(int i,string nm,string tl)
        {
            Id = i;
            Etud_Name = nm;
            Etud_Tel = tl;
        }
        public Etudiant()
        {

        }
    }
}
