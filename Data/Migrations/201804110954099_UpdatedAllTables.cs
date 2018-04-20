using System.Data.Entity.Migrations;

namespace Data.Migrations
{
    public partial class UpdatedAllTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Contract_ContractId", "dbo.Contracts");
            DropForeignKey("dbo.Customers", "MeterReading_MeterReadingId", "dbo.MeterReadings");
            DropIndex("dbo.Customers", new[] {"Contract_ContractId"});
            DropIndex("dbo.Customers", new[] {"MeterReading_MeterReadingId"});
            AddColumn("dbo.Bills", "Customer_CustomerId", c => c.Int());
            AddColumn("dbo.Contracts", "Customer_CustomerId", c => c.Int());
            AddColumn("dbo.MeterReadings", "Customer_CustomerId", c => c.Int());
            AddColumn("dbo.Reports", "Customer_CustomerId", c => c.Int());
            CreateIndex("dbo.Bills", "Customer_CustomerId");
            CreateIndex("dbo.Contracts", "Customer_CustomerId");
            CreateIndex("dbo.MeterReadings", "Customer_CustomerId");
            CreateIndex("dbo.Reports", "Customer_CustomerId");
            AddForeignKey("dbo.Bills", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.Contracts", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.MeterReadings", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.Reports", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            DropColumn("dbo.Customers", "Contract_ContractId");
            DropColumn("dbo.Customers", "MeterReading_MeterReadingId");
        }

        public override void Down()
        {
            AddColumn("dbo.Customers", "MeterReading_MeterReadingId", c => c.Int());
            AddColumn("dbo.Customers", "Contract_ContractId", c => c.Int());
            DropForeignKey("dbo.Reports", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.MeterReadings", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Contracts", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Bills", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Reports", new[] {"Customer_CustomerId"});
            DropIndex("dbo.MeterReadings", new[] {"Customer_CustomerId"});
            DropIndex("dbo.Contracts", new[] {"Customer_CustomerId"});
            DropIndex("dbo.Bills", new[] {"Customer_CustomerId"});
            DropColumn("dbo.Reports", "Customer_CustomerId");
            DropColumn("dbo.MeterReadings", "Customer_CustomerId");
            DropColumn("dbo.Contracts", "Customer_CustomerId");
            DropColumn("dbo.Bills", "Customer_CustomerId");
            CreateIndex("dbo.Customers", "MeterReading_MeterReadingId");
            CreateIndex("dbo.Customers", "Contract_ContractId");
            AddForeignKey("dbo.Customers", "MeterReading_MeterReadingId", "dbo.MeterReadings", "MeterReadingId");
            AddForeignKey("dbo.Customers", "Contract_ContractId", "dbo.Contracts", "ContractId");
        }
    }
}