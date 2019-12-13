namespace Code_First
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Gestion_Editeur : DbContext
    {
        public Gestion_Editeur()
            : base("name=Gestion_Editeur")
        {
        }

        public virtual DbSet<Editeur> Editeurs { get; set; }
        public virtual DbSet<Livre> Livres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Editeur>()
                .HasMany(e => e.Livres)
                .WithOptional(e => e.Editeur)
                .HasForeignKey(e => e.idEdit);
        }
    }
}
