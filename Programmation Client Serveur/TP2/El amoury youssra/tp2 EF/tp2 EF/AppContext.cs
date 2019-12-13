using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace tp2_EF
{
    class AppContext:DbContext
    {
        public AppContext()
                : base("AppContext")
{
        }

       




        public virtual DbSet<Employer> Employer { get; set; }
        public virtual DbSet<Entreprise> Entreprise { get; set; }
    }
}
