namespace Participation5
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyProductsDb : DbContext
    {
        public MyProductsDb()
            : base("name=MyProductsDb")
        {
        }
        // create DbSet of the Product class called Products
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Product_Number)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
