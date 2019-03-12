namespace EndGameEntityDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Message",
                c => new
                    {
                        MessageID = c.Int(nullable: false, identity: true),
                        ChatMessage = c.String(nullable: false),
                        UserID = c.Int(nullable: false),
                        MessageCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MessageID)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 62),
                        Password = c.String(nullable: false),
                        JoinDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .Index(t => t.UserName, unique: true)
                .Index(t => t.Email, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Message", "UserID", "dbo.User");
            DropIndex("dbo.User", new[] { "Email" });
            DropIndex("dbo.User", new[] { "UserName" });
            DropIndex("dbo.Message", new[] { "UserID" });
            DropTable("dbo.User");
            DropTable("dbo.Message");
        }
    }
}
