namespace DollarComputers
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DollarComputersContext : DbContext
    {
        public DollarComputersContext()
            : base("name=DollarComputersConnection")
        {
        }

        public virtual DbSet<Products> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .Property(e => e.cost)
                .HasPrecision(19, 2);
        }
    }
}