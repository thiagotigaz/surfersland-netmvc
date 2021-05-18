namespace SurfersLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBoardTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO BoardTypes (Id, Name) VALUES (1, 'Shortboard')");
            Sql("INSERT INTO BoardTypes (Id, Name) VALUES (2, 'Fish')");
            Sql("INSERT INTO BoardTypes (Id, Name) VALUES (3, 'Funboard')");
            Sql("INSERT INTO BoardTypes (Id, Name) VALUES (4, 'Longboard')");
        }

        public override void Down()
        {
        }
    }
}
