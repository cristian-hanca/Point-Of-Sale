using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Data.Entity.SqlServerCompact;
using Models;

namespace DababaseConnection
{
    [DbConfigurationType(typeof(DataConfiguration))]
    public class DataContext : DbContext
    {
        public DataContext() : base(Properties.Settings.Default.DatabaseConnectionString)
        {
            // This is a hack to ensure that Entity Framework SQL Provider is copied across to the output folder.
            // As it is installed in the GAC, Copy Local does not work. It is required for probing.
            // Fixed "Provider not loaded" error
            var ensureDLLIsCopied2 = SqlCeProviderServices.Instance;
        }

        public DbSet<Currency> Currencies { get; set; } 
        public DbSet<Models.Settings> Settingses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderEvent> OrderEvents { get; set; }
    }
}