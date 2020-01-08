namespace Syndic
{
    using MesClasses;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AppContext : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « AppContext » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « Syndic.AppContext » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « AppContext » dans le fichier de configuration de l'application.
        public AppContext()
            : base("name=AppContext")
        {
        }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet <Ville> Ville { get; set; }
        public virtual DbSet<MesClasses.Syndic> Syndic { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Quartier> Quartier { get; set; }
        public virtual DbSet<Contrat> Contrat { get; set; }
        public virtual DbSet<Bien_Immobilier> Bien_Immobilier { get; set; }


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}