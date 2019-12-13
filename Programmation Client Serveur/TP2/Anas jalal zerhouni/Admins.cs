using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace EfCodeFirst
{
        public class Admins
        {
            public int Id { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string Passwsord { get; set; }
        
        }
}
