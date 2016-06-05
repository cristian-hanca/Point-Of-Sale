using System.Data.Entity.Migrations;

namespace DababaseConnection.Migrations
{
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                {
                    Id = c.Long(false, true),
                    ParentCategoryId = c.Long(),
                    Name = c.String(false, 64)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.ParentCategoryId)
                .Index(t => t.ParentCategoryId);

            CreateTable(
                "dbo.Products",
                c => new
                {
                    Id = c.Long(false, true),
                    CategoryId = c.Long(false),
                    Name = c.String(false, 64),
                    Price = c.Decimal(false, 18, 2),
                    Vat = c.Decimal(false, 18, 2)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, true)
                .Index(t => t.CategoryId);

            CreateTable(
                "dbo.Customers",
                c => new
                {
                    Id = c.Long(false, true),
                    Cnp = c.String(false, 13),
                    Name = c.String(false, 64),
                    LastName = c.String(maxLength: 64),
                    Phone = c.String(maxLength: 64)
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Categories", "ParentCategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] {"CategoryId"});
            DropIndex("dbo.Categories", new[] {"ParentCategoryId"});
            DropTable("dbo.Customers");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}