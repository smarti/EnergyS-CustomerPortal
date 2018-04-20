using System.Data.Entity.Migrations;

namespace Data.Migrations
{
    public partial class DateTimeNullableRollback : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reports", "LastUpdate", c => c.DateTime(false, 7, storeType: "datetime2"));
        }

        public override void Down()
        {
            AlterColumn("dbo.Reports", "LastUpdate", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
    }
}