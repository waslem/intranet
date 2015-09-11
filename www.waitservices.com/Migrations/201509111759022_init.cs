namespace www.waitservices.com.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Entry",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        Blog_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Blog", t => t.Blog_ID)
                .Index(t => t.Blog_ID);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CommentText = c.String(),
                        Comment_ID = c.Int(),
                        Entry_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Comment", t => t.Comment_ID)
                .ForeignKey("dbo.Entry", t => t.Entry_ID)
                .Index(t => t.Comment_ID)
                .Index(t => t.Entry_ID);
            
            CreateTable(
                "dbo.Tag",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Entry_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Entry", t => t.Entry_ID)
                .Index(t => t.Entry_ID);
            
            CreateTable(
                "dbo.ContactForm",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Submitted = c.DateTime(nullable: false),
                        EmailAddress = c.String(),
                        Name = c.String(),
                        Subject = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entry", "Blog_ID", "dbo.Blog");
            DropForeignKey("dbo.Tag", "Entry_ID", "dbo.Entry");
            DropForeignKey("dbo.Comment", "Entry_ID", "dbo.Entry");
            DropForeignKey("dbo.Comment", "Comment_ID", "dbo.Comment");
            DropIndex("dbo.Tag", new[] { "Entry_ID" });
            DropIndex("dbo.Comment", new[] { "Entry_ID" });
            DropIndex("dbo.Comment", new[] { "Comment_ID" });
            DropIndex("dbo.Entry", new[] { "Blog_ID" });
            DropTable("dbo.ContactForm");
            DropTable("dbo.Tag");
            DropTable("dbo.Comment");
            DropTable("dbo.Entry");
            DropTable("dbo.Blog");
        }
    }
}
