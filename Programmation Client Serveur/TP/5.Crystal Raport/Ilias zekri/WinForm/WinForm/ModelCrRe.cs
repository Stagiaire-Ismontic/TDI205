namespace WinForm
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelCrRe : DbContext
    {
      
        public ModelCrRe()
            : base()
        {
        }

        public virtual DbSet<Produit> ListP { get; set; }
        public virtual DbSet<Commande> ListC { get; set; }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}