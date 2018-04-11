namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAllTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        StreetName = c.String(),
                        HouseNumber = c.String(),
                        PostalCode = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        BillId = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        PaymentStatus = c.String(),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BillId);
            
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        ContractId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ContractNotification = c.String(),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContractId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EMail = c.String(),
                        PhoneNumber = c.String(),
                        ValidFrom = c.DateTime(nullable: false),
                        ValidThrough = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        Address_AddressId = c.Int(),
                        Contract_ContractId = c.Int(),
                        MeterReading_MeterReadingId = c.Int(),
                        Password_PasswordId = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressId)
                .ForeignKey("dbo.Contracts", t => t.Contract_ContractId)
                .ForeignKey("dbo.MeterReadings", t => t.MeterReading_MeterReadingId)
                .ForeignKey("dbo.Passwords", t => t.Password_PasswordId)
                .Index(t => t.Address_AddressId)
                .Index(t => t.Contract_ContractId)
                .Index(t => t.MeterReading_MeterReadingId)
                .Index(t => t.Password_PasswordId);
            
            CreateTable(
                "dbo.MeterReadings",
                c => new
                    {
                        MeterReadingId = c.Int(nullable: false, identity: true),
                        MeterStand = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MeterReadingId);
            
            CreateTable(
                "dbo.Passwords",
                c => new
                    {
                        PasswordId = c.Int(nullable: false, identity: true),
                        UserPassword = c.String(),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PasswordId);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        ReportId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        DescriptionStatus = c.String(),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReportId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Password_PasswordId", "dbo.Passwords");
            DropForeignKey("dbo.Customers", "MeterReading_MeterReadingId", "dbo.MeterReadings");
            DropForeignKey("dbo.Customers", "Contract_ContractId", "dbo.Contracts");
            DropForeignKey("dbo.Customers", "Address_AddressId", "dbo.Addresses");
            DropIndex("dbo.Customers", new[] { "Password_PasswordId" });
            DropIndex("dbo.Customers", new[] { "MeterReading_MeterReadingId" });
            DropIndex("dbo.Customers", new[] { "Contract_ContractId" });
            DropIndex("dbo.Customers", new[] { "Address_AddressId" });
            DropTable("dbo.Reports");
            DropTable("dbo.Passwords");
            DropTable("dbo.MeterReadings");
            DropTable("dbo.Customers");
            DropTable("dbo.Contracts");
            DropTable("dbo.Bills");
            DropTable("dbo.Addresses");
        }
    }
}
