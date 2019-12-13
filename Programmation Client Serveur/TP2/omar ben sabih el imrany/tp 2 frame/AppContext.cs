using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace tp_2_frame
{
    public class AppContext : DbContext
    {
        public DbSet<Client> lst_client { get; set; }
        public DbSet<Compte> lst_compte { get; set; }
    }
}
