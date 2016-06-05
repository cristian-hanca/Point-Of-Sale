namespace DababaseConnection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ParentCategoryId = c.Long(),
                        Name = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.ParentCategoryId)
                .Index(t => t.ParentCategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CategoryId = c.Long(nullable: false),
                        Name = c.String(nullable: false, maxLength: 64),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Vat = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Cnp = c.String(nullable: false, maxLength: 13),
                        Name = c.String(nullable: false, maxLength: 64),
                        LastName = c.String(maxLength: 64),
                        Phone = c.String(maxLength: 64),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Categories", "ParentCategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Categories", new[] { "ParentCategoryId" });
            DropTable("dbo.Customers");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
