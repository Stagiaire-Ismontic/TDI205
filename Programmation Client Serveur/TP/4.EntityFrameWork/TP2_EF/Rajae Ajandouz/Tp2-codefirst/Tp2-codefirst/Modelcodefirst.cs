namespace Tp2_codefirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Modelcodefirst : DbContext
    {
        public Modelcodefirst()
            : base("name=Modelcodefirst")
        {
        }

        public virtual DbSet<Employe> Employe { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employe>()
                .Property(e => e.Nom)
                .IsUnicode(false);

            modelBuilder.Entity<Employe>()
                .Property(e => e.Prenom)
                .IsUnicode(false);

            modelBuilder.Entity<Employe>()
                .Property(e => e.Adress)
                .IsUnicode(false);
        }
    }
}
