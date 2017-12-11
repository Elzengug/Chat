namespace MyChat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixlal : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Messages", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Messages", "ApplicationUserId");
            RenameColumn(table: "dbo.Messages", name: "ApplicationUser_Id", newName: "ApplicationUserId");
            AlterColumn("dbo.Messages", "ApplicationUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Messages", "ApplicationUserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Messages", new[] { "ApplicationUserId" });
            AlterColumn("dbo.Messages", "ApplicationUserId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Messages", name: "ApplicationUserId", newName: "ApplicationUser_Id");
            AddColumn("dbo.Messages", "ApplicationUserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Messages", "ApplicationUser_Id");
        }
    }
}
