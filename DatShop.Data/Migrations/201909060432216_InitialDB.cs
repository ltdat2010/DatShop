namespace DatShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Content = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MenuGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 80),
                        Menus_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Menus", t => t.Menus_ID)
                .Index(t => t.Menus_ID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 80),
                        URL = c.String(maxLength: 200),
                        DisplayOrder = c.Int(nullable: false),
                        Target = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        GroupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID })
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(maxLength: 80),
                        CustomerAddress = c.String(maxLength: 80),
                        CustomerEmail = c.String(maxLength: 40),
                        CustomerMobile = c.String(maxLength: 20),
                        CustomerMessage = c.String(maxLength: 200),
                        PaymentMethod = c.String(maxLength: 40),
                        PaymentStatus = c.String(maxLength: 40),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 80),
                        Alias = c.String(maxLength: 80),
                        ProductCatagoryID = c.Int(nullable: false),
                        Image = c.String(),
                        Description = c.String(maxLength: 200),
                        Content = c.String(maxLength: 200),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PromotionPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Warranty = c.Int(nullable: false),
                        ViewCount = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                        MetaKeyword = c.String(),
                        MetaDescription = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProductCatagories", t => t.ProductCatagoryID, cascadeDelete: true)
                .Index(t => t.ProductCatagoryID);
            
            CreateTable(
                "dbo.ProductCatagories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 80),
                        Alias = c.String(maxLength: 80),
                        ParentID = c.Int(nullable: false),
                        Description = c.String(maxLength: 200),
                        DisplayOrder = c.Int(nullable: false),
                        Image = c.String(),
                        HomeFlag = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                        MetaKeyword = c.String(),
                        MetaDescription = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 80),
                        Content = c.String(maxLength: 200),
                        MetaKeyword = c.String(),
                        MetaDescription = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PostCatagories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 80),
                        Alias = c.String(maxLength: 80),
                        ParentID = c.Int(nullable: false),
                        Description = c.String(maxLength: 200),
                        DisplayOrder = c.Int(nullable: false),
                        Image = c.String(),
                        HomeFlag = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                        MetaKeyword = c.String(),
                        MetaDescription = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 80),
                        Alias = c.String(maxLength: 80),
                        PostCatagoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PostCatagories", t => t.PostCatagoryID, cascadeDelete: true)
                .Index(t => t.PostCatagoryID);
            
            CreateTable(
                "dbo.ProductTags",
                c => new
                    {
                        ProductTagID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        TagID = c.String(maxLength: 128),
                        PostTags = c.String(maxLength: 80),
                        PostID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductTagID, t.ProductID })
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID)
                .Index(t => t.ProductID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 80),
                        Type = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 80),
                        Description = c.String(maxLength: 200),
                        Image = c.String(),
                        URL = c.String(maxLength: 80),
                        DisplayOrder = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SupportOnlines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 80),
                        Skype = c.String(maxLength: 80),
                        Mobile = c.String(maxLength: 20),
                        Email = c.String(maxLength: 80),
                        Yahoo = c.String(maxLength: 80),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SystemConfigs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 80),
                        ValueString = c.String(maxLength: 80),
                        ValueInt = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VisitDate = c.DateTime(nullable: false),
                        IPAddress = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.ProductTags", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Posts", "PostCatagoryID", "dbo.PostCatagories");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductCatagoryID", "dbo.ProductCatagories");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.MenuGroups", "Menus_ID", "dbo.Menus");
            DropIndex("dbo.ProductTags", new[] { "TagID" });
            DropIndex("dbo.ProductTags", new[] { "ProductID" });
            DropIndex("dbo.Posts", new[] { "PostCatagoryID" });
            DropIndex("dbo.Products", new[] { "ProductCatagoryID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.MenuGroups", new[] { "Menus_ID" });
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.SystemConfigs");
            DropTable("dbo.SupportOnlines");
            DropTable("dbo.Slides");
            DropTable("dbo.Tags");
            DropTable("dbo.ProductTags");
            DropTable("dbo.Posts");
            DropTable("dbo.PostCatagories");
            DropTable("dbo.Pages");
            DropTable("dbo.ProductCatagories");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Menus");
            DropTable("dbo.MenuGroups");
            DropTable("dbo.Footers");
        }
    }
}
