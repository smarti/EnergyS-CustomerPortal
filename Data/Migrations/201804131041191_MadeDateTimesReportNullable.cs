using System.Data.Entity.Migrations;

namespace Data.Migrations
{
    public partial class MadeDateTimesReportNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reports", "LastUpdate", c => c.DateTime());
        }

        public override void Down()
        {
            AlterColumn("dbo.Reports", "LastUpdate", c => c.DateTime(false));
        }
    }
}