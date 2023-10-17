namespace test1017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createOrg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orgs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        InitDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orgs");
        }
    }
}
