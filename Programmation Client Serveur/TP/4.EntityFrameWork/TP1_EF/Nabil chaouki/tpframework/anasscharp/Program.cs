using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpframework;

namespace anasscharp
{
    class Program
    {
        public static List<User> lstuser;
        static void Main(string[] args)
        {
            using(budgetEntities db=new budgetEntities())
            {
                lstuser= db.Users.ToList();
                foreach ( var item in lstuser)
                {
                    Console.WriteLine(item.Name);
                }
                //User user = new User();
                //user.Name = "Ali";
                //user.LastName = "Ibrhimvoic";
                //user.Email = "Ali@gmail.com";
                //user.Birth = new DateTime(1999, 06, 25);


                //db.Users.Add(user);


                //AjouterUser(new User() { Birth = new DateTime(1999, 06, 4), ID = 298, Name = "zaineb", LastName = "jackline", Email = "zaineb@gmail.com" },db );
                //affiche(db);
                /*UpdateUser(new User() { Birth = new DateTime(1996, 06, 4), ID = 1, Name = "nabil", LastName = "chawki", Email = "zaineb@gm*//*ail.com", CIN = "G556216" }, db);*/
                deleteUser(298, db);

                Console.ReadLine();
                    
            }

        }
        public static void affiche(budgetEntities db)
        {
            foreach (User s in lstuser )
            {
                Console.WriteLine(s.ID + "" + s.Name + "  " + s.LastName + " " + s.Email+ s.Birth +" ");
            }

            
        }

        public static void AjouterUser(User a, budgetEntities db)
        {
            if (db.Users.Find(a.ID) == null)
            {
                db.Users.Add(a);
                Console.WriteLine("accomplished ");
               
            }
            else
            {
                Console.WriteLine("this id doesnt exist");
            }
        }

        public static void deleteUser(int Id, budgetEntities db)
        {
            if (db.Users.Find(Id) != null)
            {
                db.Users.Remove(db.Users.Find(Id));
                Console.WriteLine("Done");
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Id doesnt exist");
            }
        }
        public static void UpdateUser(User a, budgetEntities db)
        {
            if (db.Users.Find(a.ID) != null)
            {
                db.Users.Where(aa => a.ID == aa.ID).ToList().ForEach(aa => aa = a);
                Console.WriteLine("Done");
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Id doesnt exist");
            }
        }
    }
}
