namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tokenRemove : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Tokens");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TokenKey = c.String(nullable: false, maxLength: 100),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(),
                        UserID = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
