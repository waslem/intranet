namespace www.waitservices.com.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class start2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blog", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Blog", "User_Id");
            AddForeignKey("dbo.Blog", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blog", "User_Id", "dbo.Users");
            DropIndex("dbo.Blog", new[] { "User_Id" });
            DropColumn("dbo.Blog", "User_Id");
        }
    }
}
