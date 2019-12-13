using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6
{
    public class User
    {
      

            public string CIN { get; set; }
            public string Email { get; set; }
            public int ID { get; set; }

            public string Name { get; set; }
            public string LastName { get; set; }
            public DateTime Birth { get; set; }
            public User(string CIN, string Email, int ID, string Name, String LastName, DateTime birth)
            {
                this.CIN = CIN;
                this.Email = Email;
                this.ID = ID;
                this.Name = Name;
                this.Birth = Birth;
            }

            public User()
            {
            }
        
    }
}
