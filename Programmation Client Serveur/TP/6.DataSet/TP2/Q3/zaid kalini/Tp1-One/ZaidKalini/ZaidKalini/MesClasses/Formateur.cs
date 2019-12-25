using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidKalini.BusnissLayer
{
    public class Formateur
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public Module Modules { get; set; }
    }
}
