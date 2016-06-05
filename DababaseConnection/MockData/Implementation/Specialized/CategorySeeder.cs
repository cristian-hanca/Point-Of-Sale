using System.Data.Entity.Migrations;
using Models;

namespace DababaseConnection.MockData.Implementation.Specialized
{
    /// <summary>
    ///     Specialized Mock Data Seeder for Categories.
    /// </summary>
    internal class CategorySeeder : BaseMockSeeder
    {
        public new void SeedCategories(DataContext context)
        {
            var hardware = new Category {Name = "Hardware"};
            var software = new Category {Name = "Software"};
            context.Categories.AddOrUpdate(hardware, software);
            context.SaveChanges();

            context.Categories.AddOrUpdate(
                new Category {Name = "Motherboards", ParentCategory = hardware},
                new Category {Name = "Processors", ParentCategory = hardware},
                new Category {Name = "Memories", ParentCategory = hardware},
                new Category {Name = "Storage", ParentCategory = hardware});
            context.SaveChanges();

            context.Categories.AddOrUpdate(
                new Category {Name = "Operating Systems", ParentCategory = software},
                new Category {Name = "Productivity", ParentCategory = software},
                new Category {Name = "Games", ParentCategory = software});
            context.SaveChanges();
        }
    }
}