namespace GigHubMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addusername : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
