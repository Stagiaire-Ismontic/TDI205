namespace TP2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class stgrp : DbContext
    {
        public stgrp()
            : base("name=stgrp")
        {
        }
        public DbSet<groupe> groupes { get; set; }
        public DbSet<stg> stgs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
