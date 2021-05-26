namespace SurfersLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeReleaseDateToNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Boards", "ReleaseDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Boards", "ReleaseDate", c => c.DateTime(nullable: false));
        }
    }
}
