﻿using System.Data.Entity;
using System.Data.Entity.SqlServer;
using DababaseConnection.Properties;
using Models;

namespace DababaseConnection
{
    public sealed class DataContext : DbContext
    {
        public DataContext() : base(Properties.Settings.Default.DatabaseConnectionString)
        {
            // This is a hack to ensure that Entity Framework SQL Provider is copied across to the output folder.
            // As it is installed in the GAC, Copy Local does not work. It is required for probing.
            // Fixed "Provider not loaded" error
            var ensureDLLIsCopied = SqlProviderServices.Instance;
        }

        public DbSet<Models.Settings> Settingses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}