namespace VETPRO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedsomestuff : DbMigration
    {
        public override void Up()
        {
            RenameColumn("FacilityAdditionalInfoes", "EvacCountyId", "FacilityId");
            RenameColumn("FacilityAdditionalInfoes", "EvacCountyNotes", "FacilityNotes");
            RenameColumn("FacilityContacts", "EvacCountyId", "FacilityId");
            RenameColumn("FacilitySecondaryContacts", "EvacCountyId", "FacilityId");
            AddColumn("dbo.FacilityCapacities", "FacilityId", c => c.String());
            AddColumn("dbo.FacilityOccupancies", "FacilityId", c => c.String());
            AddColumn("dbo.ShelterOperations", "FacilityId", c => c.String());
            AddColumn("dbo.TrackingOperations", "FacilityId", c => c.String());
        }
        
        public override void Down()
        {
            RenameColumn("FacilityAdditionalInfoes", "FacilityId", "EvacCountyId");
            RenameColumn("FacilityAdditionalInfoes", "FacilityNotes", "EvacCountyNotes");
            RenameColumn("FacilityContacts", "FacilityId", "EvacCountyId");
            RenameColumn("FacilitySecondaryContacts", "FacilityId", "EvacCountyId");
            DropColumn("dbo.TrackingOperations", "FacilityId");
            DropColumn("dbo.ShelterOperations", "FacilityId");
            DropColumn("dbo.FacilityOccupancies", "FacilityId");
            DropColumn("dbo.FacilityCapacities", "FacilityId");
        }
    }
}
