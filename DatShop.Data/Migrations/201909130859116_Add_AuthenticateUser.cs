namespace DatShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_AuthenticateUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BirthDay", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "BirthDay");
        }
    }
}
