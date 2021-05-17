using System;
using System.Collections.Generic;
using System.Text;
using EntityFramework.Entity;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class OrderProcessingContext : DbContext
    {
        public OrderProcessingContext(DbContextOptions<OrderProcessingContext> options)
        : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ProductOrderMapping> ProductOrderMapping { get; set; }
    }
}
