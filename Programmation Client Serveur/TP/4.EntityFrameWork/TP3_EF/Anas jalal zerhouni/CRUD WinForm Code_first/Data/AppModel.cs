using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Entities;
namespace WindowsFormsApp2.Data
{
    public class AppModel : DbContext
    {
        public AppModel() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=AdminsDB;Integrated Security=True")
        {

        }
        public virtual DbSet<Admins> admins { get; set; }
    }
}
