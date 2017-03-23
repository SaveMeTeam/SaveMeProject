namespace SaveMeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOthertobool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReportAbusers", "Other", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReportAbusers", "Other", c => c.String());
        }
    }
}
