namespace DababaseConnection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCurrencies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 3),
                        Name = c.String(nullable: false, maxLength: 64),
                        ToBase = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Orders", "CurrencyId", c => c.Long(nullable: false));
            AddColumn("dbo.Settings", "BaseCurrencyId", c => c.Long(nullable: false));
            CreateIndex("dbo.Orders", "CurrencyId");
            CreateIndex("dbo.Settings", "BaseCurrencyId");
            AddForeignKey("dbo.Orders", "CurrencyId", "dbo.Currencies", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Settings", "BaseCurrencyId", "dbo.Currencies", "Id", cascadeDelete: true);
            DropColumn("dbo.Settings", "BaseCurrency");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Settings", "BaseCurrency", c => c.String(nullable: false, maxLength: 3));
            DropForeignKey("dbo.Settings", "BaseCurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.Orders", "CurrencyId", "dbo.Currencies");
            DropIndex("dbo.Settings", new[] { "BaseCurrencyId" });
            DropIndex("dbo.Orders", new[] { "CurrencyId" });
            DropColumn("dbo.Settings", "BaseCurrencyId");
            DropColumn("dbo.Orders", "CurrencyId");
            DropTable("dbo.Currencies");
        }
    }
}
