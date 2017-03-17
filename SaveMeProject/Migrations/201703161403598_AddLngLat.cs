namespace SaveMeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLngLat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReportAbusers", "Latitude", c => c.String());
            AddColumn("dbo.ReportAbusers", "Longitude", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReportAbusers", "Longitude");
            DropColumn("dbo.ReportAbusers", "Latitude");
        }
    }
}
