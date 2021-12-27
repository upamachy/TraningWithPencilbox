using Microsoft.EntityFrameworkCore;
using RepoPractice.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPractice.Database
{
    class ClassPractice5DbContext: DbContext
    {
        
        public DbSet<Item> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=DELL\SQLEXPRESS; Database = ClassPractice5DB; Integrated Security=True";
            optionsBuilder
                //.UseLazyLoadingProxies()

                .UseSqlServer(connectionString);
        }
    }
}
