namespace WebAPI_Assessment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Texts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Line = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Texts");
        }
    }
}
