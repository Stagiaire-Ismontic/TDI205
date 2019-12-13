using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//import entity framework
using System.Data.Entity;
namespace EfCodeFirst
{
    public class adminsContext : DbContext
    {

        public adminsContext() : base(@"Data Source=DESKTOP-T03IVK2\SQLEXPRESS;Initial Catalog=mamamia;Integrated Security=True")
        {

        }

        public DbSet<Admins> Admins { get; set; }
    }
}
