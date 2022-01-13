using Microsoft.EntityFrameworkCore;
using SMEcommerce.Models.EntityModels;

namespace SMEcommerce.Databases.DbContexts
{
    public class SMEcommerceDbcontext : DbContext
    {
        public SMEcommerceDbcontext(DbContextOptions options ): base(options)
        {
                
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Products { get; set; }

        //public DbSet<Brand> Brands { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connectionString = @"Server=DELL\SQLEXPRESS; Database = SMEcommerceDB; Integrated Security=True";
            //optionsBuilder
            //    //.UseLazyLoadingProxies()

            //    .UseSqlServer(connectionString);
        }
    }
}
