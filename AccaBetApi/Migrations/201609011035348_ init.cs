namespace AccaBetApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CountryName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Leagues",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        LeagueName = c.String(nullable: false, maxLength: 50),
                        LeagueIcon = c.String(),
                        CountryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.CountryID, cascadeDelete: true)
                .Index(t => t.CountryID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        TeamName = c.String(nullable: false, maxLength: 75),
                        LeagueID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Leagues", t => t.LeagueID, cascadeDelete: true)
                .Index(t => t.LeagueID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "LeagueID", "dbo.Leagues");
            DropForeignKey("dbo.Leagues", "CountryID", "dbo.Countries");
            DropIndex("dbo.Teams", new[] { "LeagueID" });
            DropIndex("dbo.Leagues", new[] { "CountryID" });
            DropTable("dbo.Teams");
            DropTable("dbo.Leagues");
            DropTable("dbo.Countries");
        }
    }
}
