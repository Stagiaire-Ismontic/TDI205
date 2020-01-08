namespace FormsApp.Db
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using FormsApp.Classes;

    public class Gestionnaire : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « Gestionnaire » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « FormsApp.Db.Gestionnaire » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « Gestionnaire » dans le fichier de configuration de l'application.
        public Gestionnaire()
: base(@"data source = (LocalDb)\MSSQLLocalDB; initial catalog =Gestion; integrated security = True;")
        {
        }
        public virtual DbSet<Quartier> ListQuartier { get; set; }
        public virtual DbSet<Ville> ListVille { get; set; }
        public virtual DbSet<BienImmobilier> ListBienImmobilier { get; set; }
        public virtual DbSet<Syndic> ListSyndic { get; set; }
        public virtual DbSet<Contrat> ListContrat { get; set; }
        public virtual DbSet<Region> ListRegion { get; set; }

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