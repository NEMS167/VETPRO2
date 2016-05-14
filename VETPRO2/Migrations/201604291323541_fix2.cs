namespace VETPRO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.FacilityAdditionalInfoes", "FacilityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FacilityAdditionalInfoes", "FacilityId", c => c.String());
        }
    }
}
