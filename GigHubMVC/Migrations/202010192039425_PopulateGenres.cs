namespace GigHubMVC.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES('Blues')");
            Sql("INSERT INTO Genres(Name) VALUES('Jazz')");
            Sql("INSERT INTO Genres(Name) VALUES('Rock')");
            Sql("INSERT INTO Genres(Name) VALUES('Pop')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1,2,3,4)");
        }
    }
}