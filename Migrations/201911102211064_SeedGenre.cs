namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (2, 'Action')");
        }
        
        public override void Down()
        {
        }
    }
}
