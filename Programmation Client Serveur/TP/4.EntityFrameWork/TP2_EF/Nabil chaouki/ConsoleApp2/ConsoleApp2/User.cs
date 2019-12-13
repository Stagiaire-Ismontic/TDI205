using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> Birth { get; set; }
        public string CIN { get; set; }
        public string Email { get; set; }
        public int ID { get; set; }
    }
}
