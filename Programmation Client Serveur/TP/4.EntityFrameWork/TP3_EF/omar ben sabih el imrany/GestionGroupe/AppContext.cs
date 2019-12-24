using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GestionGroupe
{
    public class AppContext : DbContext
    {
        public DbSet<Personne> lst_personne { get; set; }
    }
}
