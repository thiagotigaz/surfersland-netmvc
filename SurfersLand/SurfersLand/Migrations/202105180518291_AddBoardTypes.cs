namespace SurfersLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBoardTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BoardTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Boards", "BoardTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Boards", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Boards", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Boards", "NumberInStock", c => c.Byte(nullable: false));
            AlterColumn("dbo.Boards", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Boards", "BoardTypeId");
            AddForeignKey("dbo.Boards", "BoardTypeId", "dbo.BoardTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Boards", "BoardTypeId", "dbo.BoardTypes");
            DropIndex("dbo.Boards", new[] { "BoardTypeId" });
            AlterColumn("dbo.Boards", "Name", c => c.String());
            DropColumn("dbo.Boards", "NumberInStock");
            DropColumn("dbo.Boards", "ReleaseDate");
            DropColumn("dbo.Boards", "DateAdded");
            DropColumn("dbo.Boards", "BoardTypeId");
            DropTable("dbo.BoardTypes");
        }
    }
}
