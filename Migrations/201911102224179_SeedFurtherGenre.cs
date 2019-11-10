namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedFurtherGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (4, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
