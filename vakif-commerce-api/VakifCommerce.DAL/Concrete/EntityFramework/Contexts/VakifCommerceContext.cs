using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using VakifCommerce.Entities.Concrete;

namespace VakifCommerce.DAL.Concrete.EntityFramework.Contexts
{
    public class VakifCommerceContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=DESKTOP-26E5S7G;
                Initial Catalog=VakifCommerceDb;
                Integrated Security=True;
                Connect Timeout=30;
                Encrypt=False;
                TrustServerCertificate=False;
                ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False;"
            );
        }

        public DbSet<Product>? Product { get; set; }
        public DbSet<Category>? Category { get; set; }
        public DbSet<ProductSpecs>? ProductsSpecs { get; set; } 
        public DbSet<User>? Users { get; set; }
        public DbSet<OperationClaim>? OperationClaims { get; set; }
        public DbSet<UserOperationClaim>? UserOperationClaims { get; set; }
    }
}

