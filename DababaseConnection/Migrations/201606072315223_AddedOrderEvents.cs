namespace DababaseConnection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOrderEvents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderEvents",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OrderId = c.Long(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderEvents", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderEvents", new[] { "OrderId" });
            DropTable("dbo.OrderEvents");
        }
    }
}
