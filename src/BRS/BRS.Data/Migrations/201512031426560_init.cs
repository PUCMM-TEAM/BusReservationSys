namespace BRS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditCard",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CardHolder = c.String(),
                        CardNumber = c.String(),
                        CVC = c.String(),
                        ExpirationDate = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        CreditCard_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CreditCard", t => t.CreditCard_ID)
                .Index(t => t.CreditCard_ID);
            
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
                "dbo.Reservation",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumPassenger = c.Int(nullable: false),
                        ReservationDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        CreditCard_ID = c.Int(),
                        Customer_ID = c.Int(),
                        Trip_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CreditCard", t => t.CreditCard_ID)
                .ForeignKey("dbo.Customer", t => t.Customer_ID)
                .ForeignKey("dbo.Trip", t => t.Trip_ID)
                .Index(t => t.CreditCard_ID)
                .Index(t => t.Customer_ID)
                .Index(t => t.Trip_ID);
            
            CreateTable(
                "dbo.Trip",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateAvailable = c.Byte(nullable: false),
                        DepartureTime = c.Int(nullable: false),
                        ArrivalTime = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        Route_ID = c.Int(),
                        Vehicle_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Route", t => t.Route_ID)
                .ForeignKey("dbo.Vehicle", t => t.Vehicle_ID)
                .Index(t => t.Route_ID)
                .Index(t => t.Vehicle_ID);
            
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
            
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PassengerCapacity = c.Int(nullable: false),
                        VehicleType = c.String(),
                        Image = c.String(),
                        Description = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Role",
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
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        Customer_ID = c.Int(),
                        Role_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.Customer_ID)
                .ForeignKey("dbo.Role", t => t.Role_ID)
                .Index(t => t.Customer_ID)
                .Index(t => t.Role_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "Role_ID", "dbo.Role");
            DropForeignKey("dbo.User", "Customer_ID", "dbo.Customer");
            DropForeignKey("dbo.Reservation", "Trip_ID", "dbo.Trip");
            DropForeignKey("dbo.Trip", "Vehicle_ID", "dbo.Vehicle");
            DropForeignKey("dbo.Trip", "Route_ID", "dbo.Route");
            DropForeignKey("dbo.Route", "Pickup_ID", "dbo.Destination");
            DropForeignKey("dbo.Route", "DropOff_ID", "dbo.Destination");
            DropForeignKey("dbo.Reservation", "Customer_ID", "dbo.Customer");
            DropForeignKey("dbo.Reservation", "CreditCard_ID", "dbo.CreditCard");
            DropForeignKey("dbo.Customer", "CreditCard_ID", "dbo.CreditCard");
            DropIndex("dbo.User", new[] { "Role_ID" });
            DropIndex("dbo.User", new[] { "Customer_ID" });
            DropIndex("dbo.Route", new[] { "Pickup_ID" });
            DropIndex("dbo.Route", new[] { "DropOff_ID" });
            DropIndex("dbo.Trip", new[] { "Vehicle_ID" });
            DropIndex("dbo.Trip", new[] { "Route_ID" });
            DropIndex("dbo.Reservation", new[] { "Trip_ID" });
            DropIndex("dbo.Reservation", new[] { "Customer_ID" });
            DropIndex("dbo.Reservation", new[] { "CreditCard_ID" });
            DropIndex("dbo.Customer", new[] { "CreditCard_ID" });
            DropTable("dbo.User");
            DropTable("dbo.Role");
            DropTable("dbo.Vehicle");
            DropTable("dbo.Route");
            DropTable("dbo.Trip");
            DropTable("dbo.Reservation");
            DropTable("dbo.Destination");
            DropTable("dbo.Customer");
            DropTable("dbo.CreditCard");
        }
    }
}
