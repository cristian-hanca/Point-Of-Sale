using System.Data.Entity.Migrations;
using System.Linq;
using Models;

namespace DababaseConnection.MockData.Implementation.Specialized
{
    /// <summary>
    ///     Specialized Mock Data Seeder for Products.
    /// </summary>
    internal class ProductSeeder : MockDataSeeder
    {
        public new void SeedProducts(DataContext context)
        {
            SeedMotherboards(context);
            SeedProcessors(context);
            SeedMemories(context);
            SeedStorage(context);

            SeedOs(context);
            SeedProductivity(context);
            SeedGames(context);
        }

        private static void SeedMotherboards(DataContext context)
        {
            var category = context.Categories.First(x => x.Name.Equals("Motherboards"));
            context.Products.AddOrUpdate(
                new Product
                {
                    Category = category,
                    Name = "Basic Motherboard",
                    Vat = 20,
                    Price = 150
                },
                new Product
                {
                    Category = category,
                    Name = "Gamer Motherboard",
                    Vat = 20,
                    Price = 550
                },
                new Product
                {
                    Category = category,
                    Name = "Server Motherboard",
                    Vat = 20,
                    Price = 1150
                });
            context.SaveChanges();
        }

        private static void SeedProcessors(DataContext context)
        {
            var category = context.Categories.First(x => x.Name.Equals("Processors"));
            context.Products.AddOrUpdate(
                new Product
                {
                    Category = category,
                    Name = "Basic Processor",
                    Vat = 20,
                    Price = 375
                },
                new Product
                {
                    Category = category,
                    Name = "Gamer Processor",
                    Vat = 20,
                    Price = 625
                },
                new Product
                {
                    Category = category,
                    Name = "Server Processor",
                    Vat = 20,
                    Price = 1500
                },
                new Product
                {
                    Category = category,
                    Name = "eXtreme Processor",
                    Vat = 20,
                    Price = 2999
                });
            context.SaveChanges();
        }

        private static void SeedMemories(DataContext context)
        {
            var category = context.Categories.First(x => x.Name.Equals("Memories"));
            context.Products.AddOrUpdate(
                new Product
                {
                    Category = category,
                    Name = "2GB Memory",
                    Vat = 20,
                    Price = 99
                },
                new Product
                {
                    Category = category,
                    Name = "4GB Memory",
                    Vat = 20,
                    Price = 129
                },
                new Product
                {
                    Category = category,
                    Name = "8GB Memory",
                    Vat = 20,
                    Price = 169
                },
                new Product
                {
                    Category = category,
                    Name = "16GB Memory",
                    Vat = 20,
                    Price = 229
                },
                new Product
                {
                    Category = category,
                    Name = "32GB Memory",
                    Vat = 20,
                    Price = 549
                });
            context.SaveChanges();
        }

        private static void SeedStorage(DataContext context)
        {
            var category = context.Categories.First(x => x.Name.Equals("Storage"));
            context.Products.AddOrUpdate(
                new Product
                {
                    Category = category,
                    Name = "500GB HDD",
                    Vat = 20,
                    Price = 134
                },
                new Product
                {
                    Category = category,
                    Name = "1TB HDD",
                    Vat = 20,
                    Price = 199
                },
                new Product
                {
                    Category = category,
                    Name = "2TB HDD",
                    Vat = 20,
                    Price = 229
                },
                new Product
                {
                    Category = category,
                    Name = "128GB SSD",
                    Vat = 20,
                    Price = 199
                },
                new Product
                {
                    Category = category,
                    Name = "256GB SSD",
                    Vat = 20,
                    Price = 399
                },
                new Product
                {
                    Category = category,
                    Name = "512GB SSD",
                    Vat = 20,
                    Price = 599
                },
                new Product
                {
                    Category = category,
                    Name = "960GB SSD",
                    Vat = 20,
                    Price = 999
                });
            context.SaveChanges();
        }

        private static void SeedOs(DataContext context)
        {
            var category = context.Categories.First(x => x.Name.Equals("Operating Systems"));
            context.Products.AddOrUpdate(
                new Product
                {
                    Category = category,
                    Name = "Free OS",
                    Vat = 20,
                    Price = 0
                },
                new Product
                {
                    Category = category,
                    Name = "Basic OS",
                    Vat = 20,
                    Price = 199
                },
                new Product
                {
                    Category = category,
                    Name = "Pro OS",
                    Vat = 20,
                    Price = 299
                },
                new Product
                {
                    Category = category,
                    Name = "Server OS",
                    Vat = 20,
                    Price = 599
                });
            context.SaveChanges();
        }

        private static void SeedProductivity(DataContext context)
        {
            var category = context.Categories.First(x => x.Name.Equals("Productivity"));
            context.Products.AddOrUpdate(
                new Product
                {
                    Category = category,
                    Name = "Basic Productivity",
                    Vat = 20,
                    Price = 59
                },
                new Product
                {
                    Category = category,
                    Name = "Student Productivity",
                    Vat = 20,
                    Price = 119
                },
                new Product
                {
                    Category = category,
                    Name = "Pro Productivity",
                    Vat = 20,
                    Price = 209
                },
                new Product
                {
                    Category = category,
                    Name = "Business Productivity",
                    Vat = 20,
                    Price = 199
                },
                new Product
                {
                    Category = category,
                    Name = "Corporate Productivity",
                    Vat = 20,
                    Price = 1999
                });
            context.SaveChanges();
        }

        private static void SeedGames(DataContext context)
        {
            var category = context.Categories.First(x => x.Name.Equals("Games"));
            context.Products.AddOrUpdate(
                new Product
                {
                    Category = category,
                    Name = "Arcade Game",
                    Vat = 20,
                    Price = 59
                },
                new Product
                {
                    Category = category,
                    Name = "Shooter Game",
                    Vat = 20,
                    Price = 149
                },
                new Product
                {
                    Category = category,
                    Name = "Sports Game",
                    Vat = 20,
                    Price = 189
                });
            context.SaveChanges();
        }
    }
}