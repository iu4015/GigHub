namespace GigHubMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        GigId = c.Int(nullable: false),
                        AttendieId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.GigId, t.AttendieId })
                .ForeignKey("dbo.AspNetUsers", t => t.AttendieId, cascadeDelete: true)
                .ForeignKey("dbo.Gigs", t => t.GigId)
                .Index(t => t.GigId)
                .Index(t => t.AttendieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "GigId", "dbo.Gigs");
            DropForeignKey("dbo.Attendances", "AttendieId", "dbo.AspNetUsers");
            DropIndex("dbo.Attendances", new[] { "AttendieId" });
            DropIndex("dbo.Attendances", new[] { "GigId" });
            DropTable("dbo.Attendances");
        }
    }
}
