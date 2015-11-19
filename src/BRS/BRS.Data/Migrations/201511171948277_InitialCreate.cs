namespace BRS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Destination",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Route",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        DropOff_ID = c.Int(),
                        Pickup_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Destination", t => t.DropOff_ID)
                .ForeignKey("dbo.Destination", t => t.Pickup_ID)
                .Index(t => t.DropOff_ID)
                .Index(t => t.Pickup_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Route", "Pickup_ID", "dbo.Destination");
            DropForeignKey("dbo.Route", "DropOff_ID", "dbo.Destination");
            DropIndex("dbo.Route", new[] { "Pickup_ID" });
            DropIndex("dbo.Route", new[] { "DropOff_ID" });
            DropTable("dbo.Route");
            DropTable("dbo.Destination");
        }
    }
}
