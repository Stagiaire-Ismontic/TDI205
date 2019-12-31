namespace tpClient
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CC1 : DbContext
    {
        public CC1()
            : base("Data Source=.;Initial Catalog=Client;Integrated Security=True")
        {
        }

        public DbSet<Client> lstClient { get; set; }
        public DbSet<Commande> lstCommand { get; set; }

    }

}