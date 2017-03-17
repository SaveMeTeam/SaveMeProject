namespace SaveMeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AsteriskRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReportAbusers", "AbuseDetails", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReportAbusers", "AbuseDetails", c => c.String());
        }
    }
}
