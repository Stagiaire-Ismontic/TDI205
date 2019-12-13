
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1gestionbudget
{
   public class serviceudget
    {
        private List<User> u1 = new List<User>();

        public List<User> U1 { get => u1; set => u1 = value; }

        public void add(User g)

        {
            U1.Add(g);
        }

        public void delete(int id)
        {
            User userss = this.Findall().Find(g => g.ID == id);
            if (userss != null)
                this.Findall().Remove(userss);

        }
        public List<User> Findall()
        {
            return U1;
        }
        public  void Update(User u1)
        {
            User Userss = this.Findall().Find(g => g.ID == u1.ID);
            Userss.Name = u1.Name;
            Userss.ID = u1.ID;
            Userss.LastName = u1.LastName;
            Userss.Email = u1.Email;
            Userss.CIN = u1.CIN;
        }
            
    }
}
