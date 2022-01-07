namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRUD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cruds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EId = c.Int(nullable: false),
                        EName = c.String(),
                        Place = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.cruds");
        }
    }
}
