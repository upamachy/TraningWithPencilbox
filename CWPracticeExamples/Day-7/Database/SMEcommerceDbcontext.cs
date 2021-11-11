using Day_7.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7.Database
{
    class SMEcommerceDbcontext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=DELL\SQLEXPRESS; Database = SMEcommerceDB; Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
