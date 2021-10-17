namespace PacManProject.DataAcess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameCharacters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Width = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        PositionX = c.Int(nullable: false),
                        PositionY = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                        IsWeak = c.Boolean(nullable: false),
                        PlayerId = c.Int(nullable: false),
                        MapId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Maps", t => t.MapId, cascadeDelete: true)
                .ForeignKey("dbo.Players", t => t.PlayerId, cascadeDelete: true)
                .Index(t => t.PlayerId)
                .Index(t => t.MapId);
            
            CreateTable(
                "dbo.Maps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Width = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MapObjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PositionX = c.Int(nullable: false),
                        PositionY = c.Int(nullable: false),
                        MapId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Maps", t => t.MapId, cascadeDelete: true)
                .Index(t => t.MapId);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GameCharacters", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.MapObjects", "MapId", "dbo.Maps");
            DropForeignKey("dbo.GameCharacters", "MapId", "dbo.Maps");
            DropIndex("dbo.MapObjects", new[] { "MapId" });
            DropIndex("dbo.GameCharacters", new[] { "MapId" });
            DropIndex("dbo.GameCharacters", new[] { "PlayerId" });
            DropTable("dbo.Players");
            DropTable("dbo.MapObjects");
            DropTable("dbo.Maps");
            DropTable("dbo.GameCharacters");
        }
    }
}
