namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForceGlobalUseOfDateTime2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "LastUpdate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Bills", "LastUpdate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Customers", "ValidFrom", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Customers", "ValidThrough", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Customers", "LastUpdate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Passwords", "LastUpdate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Contracts", "LastUpdate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.MeterReadings", "LastUpdate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Reports", "LastUpdate", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reports", "LastUpdate", c => c.DateTime());
            AlterColumn("dbo.MeterReadings", "LastUpdate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Contracts", "LastUpdate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Passwords", "LastUpdate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "LastUpdate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "ValidThrough", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "ValidFrom", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Bills", "LastUpdate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Addresses", "LastUpdate", c => c.DateTime(nullable: false));
        }
    }
}
