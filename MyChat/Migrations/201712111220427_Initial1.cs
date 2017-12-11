namespace MyChat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "ApplicationUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Messages", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "Sign", c => c.String());
            CreateIndex("dbo.Messages", "ApplicationUser_Id");
            AddForeignKey("dbo.Messages", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Messages", "Sign");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "Sign", c => c.String());
            DropForeignKey("dbo.Messages", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Messages", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.AspNetUsers", "Sign");
            DropColumn("dbo.Messages", "ApplicationUser_Id");
            DropColumn("dbo.Messages", "ApplicationUserId");
        }
    }
}
