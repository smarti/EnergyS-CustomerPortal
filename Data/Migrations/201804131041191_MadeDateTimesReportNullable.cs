namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeDateTimesReportNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reports", "LastUpdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reports", "LastUpdate", c => c.DateTime(nullable: false));
        }
    }
}
