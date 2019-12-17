using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1gestionbudget
{
    public class User
    {
        
            public string CIN { get; set; }
            public string Email { get; set; }
            public int ID { get; set; }

            public string Name { get; set; }
            public string LastName { get; set; }
            public DateTime Birth { get; set; }
            public Budget budget { get; set; }
        public User(string CIN, string Email, int ID, string Name, String LastName, DateTime birth, Budget budget)
            {
                this.CIN = CIN;
                this.Email = Email;
                this.ID = ID;
                this.Name = Name;
                this.Birth = Birth;
                this.budget = budget;
            }

        public User()
        {
        }
    }
}
