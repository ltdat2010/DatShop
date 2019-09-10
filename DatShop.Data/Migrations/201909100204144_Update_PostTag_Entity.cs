namespace DatShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_PostTag_Entity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductTags", "TagID", "dbo.Tags");
            DropIndex("dbo.ProductTags", new[] { "TagID" });
            DropPrimaryKey("dbo.Tags");
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PostID = c.Int(nullable: false),
                        TagID = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID)
                .Index(t => t.PostID)
                .Index(t => t.TagID);
            
            AddColumn("dbo.Posts", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Posts", "CreatedBy", c => c.String());
            AddColumn("dbo.Posts", "UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Posts", "UpdateBy", c => c.String());
            AddColumn("dbo.Posts", "MetaKeyword", c => c.String());
            AddColumn("dbo.Posts", "MetaDescription", c => c.String());
            AddColumn("dbo.Posts", "Status", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ProductTags", "TagID", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Tags", "ID", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AddPrimaryKey("dbo.Tags", "ID");
            CreateIndex("dbo.ProductTags", "TagID");
            AddForeignKey("dbo.ProductTags", "TagID", "dbo.Tags", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.PostTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.PostTags", "PostID", "dbo.Posts");
            DropIndex("dbo.ProductTags", new[] { "TagID" });
            DropIndex("dbo.PostTags", new[] { "TagID" });
            DropIndex("dbo.PostTags", new[] { "PostID" });
            DropPrimaryKey("dbo.Tags");
            AlterColumn("dbo.Tags", "ID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ProductTags", "TagID", c => c.String(maxLength: 128));
            DropColumn("dbo.Posts", "Status");
            DropColumn("dbo.Posts", "MetaDescription");
            DropColumn("dbo.Posts", "MetaKeyword");
            DropColumn("dbo.Posts", "UpdateBy");
            DropColumn("dbo.Posts", "UpdateDate");
            DropColumn("dbo.Posts", "CreatedBy");
            DropColumn("dbo.Posts", "CreatedDate");
            DropTable("dbo.PostTags");
            AddPrimaryKey("dbo.Tags", "ID");
            CreateIndex("dbo.ProductTags", "TagID");
            AddForeignKey("dbo.ProductTags", "TagID", "dbo.Tags", "ID");
        }
    }
}
