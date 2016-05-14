namespace VETPRO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.FacilityContacts", "FacilityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FacilityContacts", "FacilityId", c => c.String());
        }
    }
}
