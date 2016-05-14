namespace VETPRO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FacilityInfoes", "LocationKind", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FacilityInfoes", "LocationKind");
        }
    }
}
