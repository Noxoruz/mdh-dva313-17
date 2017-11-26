namespace PaymentGateway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracija1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WebShopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.WebShop", t => t.WebShopId, cascadeDelete: true)
                .Index(t => t.WebShopId);
            
            CreateTable(
                "dbo.Transaction",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PaymentMethod = c.Int(),
                        Fee = c.Double(nullable: false),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        SurName = c.String(),
                        Role = c.String(),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WebShop",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "WebShopId", "dbo.WebShop");
            DropForeignKey("dbo.Transaction", "UserId", "dbo.User");
            DropForeignKey("dbo.Transaction", "ProductId", "dbo.Product");
            DropIndex("dbo.Transaction", new[] { "ProductId" });
            DropIndex("dbo.Transaction", new[] { "UserId" });
            DropIndex("dbo.Product", new[] { "WebShopId" });
            DropTable("dbo.WebShop");
            DropTable("dbo.User");
            DropTable("dbo.Transaction");
            DropTable("dbo.Product");
        }
    }
}
