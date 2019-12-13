namespace ConsoleApplication1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=Etablissement15;Integrated Security =True;")
        {
        }

        public virtual DbSet<Etablissement1> Etablissement1 { get; set; }
        public virtual DbSet<Etudiant> Etudiant { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Etablissement1>()
                .Property(e => e.Etab_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Etablissement1>()
                .Property(e => e.Etab_Desc)
                .IsUnicode(false);

            //modelBuilder.Entity<Etablissement1>()
            //    .HasOptional(e => e.Etudiant)
            //    .WithRequired(e => e.Etablissement1);

            modelBuilder.Entity<Etudiant>()
                .Property(e => e.Etud_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Etudiant>()
                .Property(e => e.Etud_Tel)
                .IsUnicode(false);
        }
    }
}
