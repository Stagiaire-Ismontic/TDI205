namespace WindowsFormsApplication1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=ManagementOptionnel;Integrated Security =True;")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<Etablissement> Etablissement1 { get; set; }
        public virtual DbSet<Etudiant> Etudiant { get; set; }

       
    }
}
