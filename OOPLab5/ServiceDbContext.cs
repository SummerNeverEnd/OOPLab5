using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace Lab5
{
    class ServiceDbContext : DbContext
    {
        public ServiceDbContext() : base(@"Server=DESKTOP-I4L1KPR\SQLEXPRESS;Database=dbContext;Trusted_Connection=True;") {
            
        }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}