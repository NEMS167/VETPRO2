namespace VETPRO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FacilityAdditionalInfoes", "FacilityId", c => c.String());
            AddColumn("dbo.FacilityContacts", "FacilityId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FacilityContacts", "FacilityId");
            DropColumn("dbo.FacilityAdditionalInfoes", "FacilityId");
        }
    }
}
