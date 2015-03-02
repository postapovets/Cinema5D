namespace Cinema5D.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Films : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        FilmID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 160),
                        RunningTime = c.Int(nullable: false),
                        CommandLink = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.FilmID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Films");
        }
    }
}
