namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeNullableRollback : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reports", "LastUpdate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reports", "LastUpdate", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
    }
}
