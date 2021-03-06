using System.Data.Entity.Migrations;

namespace Data.Migrations
{
    public partial class UpdatedAllTables1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Passwords", "PasswordHash", c => c.String());
            AddColumn("dbo.Passwords", "Salt", c => c.String());
            AddColumn("dbo.Contracts", "ContractStatus", c => c.String());
            AddColumn("dbo.MeterReadings", "CurrentReading", c => c.Int(false));
            AlterColumn("dbo.Bills", "Amount", c => c.Single(false));
            DropColumn("dbo.Passwords", "UserPassword");
            DropColumn("dbo.Contracts", "ContractNotification");
            DropColumn("dbo.MeterReadings", "MeterStand");
        }

        public override void Down()
        {
            AddColumn("dbo.MeterReadings", "MeterStand", c => c.Int(false));
            AddColumn("dbo.Contracts", "ContractNotification", c => c.String());
            AddColumn("dbo.Passwords", "UserPassword", c => c.String());
            AlterColumn("dbo.Bills", "Amount", c => c.Int(false));
            DropColumn("dbo.MeterReadings", "CurrentReading");
            DropColumn("dbo.Contracts", "ContractStatus");
            DropColumn("dbo.Passwords", "Salt");
            DropColumn("dbo.Passwords", "PasswordHash");
        }
    }
}