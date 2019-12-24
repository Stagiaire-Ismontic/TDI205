using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFW1
{
    public class PharmacieContext :DbContext
    {
        public PharmacieContext():  base ()
        {

        }
        public DbSet<Medicament> medicaments { get; set; }
        public DbSet<Pharmacie> pharmacies { get; set; }

    }
}
