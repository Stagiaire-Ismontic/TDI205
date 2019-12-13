namespace tp2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class biblio_Entity : DbContext
    {
        public biblio_Entity()
            : base("name=biblio_Entity")
        {
        }

        public virtual DbSet<editeur> editeurs { get; set; }
        public virtual DbSet<Livre> Livres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<editeur>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<editeur>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<Livre>()
                .Property(e => e.titre)
                .IsUnicode(false);

            modelBuilder.Entity<Livre>()
                .Property(e => e.categorie)
                .IsUnicode(false);

            modelBuilder.Entity<Livre>()
                .HasMany(e => e.editeurs)
                .WithOptional(e => e.Livre)
                .HasForeignKey(e => e.id_livre);
        }
    }
}
