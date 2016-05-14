namespace VETPRO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringids : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdditionalContacts", "OwnerId", c => c.String());
            AlterColumn("dbo.AdditionalPetInfoes", "AnimalId", c => c.String());
            AlterColumn("dbo.AnimalBehaviors", "AnimalId", c => c.String());
            AlterColumn("dbo.ChipIdentifications", "AnimalId", c => c.String());
            AlterColumn("dbo.FacilitySecondaryContacts", "FacilityId", c => c.String());
            AlterColumn("dbo.Insurances", "AnimalId", c => c.String());
            AlterColumn("dbo.LiabilityReleases", "AnimalId", c => c.String());
            AlterColumn("dbo.MedicalHistories", "AnimalId", c => c.String());
            AlterColumn("dbo.NonownedAnimals", "AnimalId", c => c.String());
            AlterColumn("dbo.SecondaryContacts", "OwnerId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SecondaryContacts", "OwnerId", c => c.Int(nullable: false));
            AlterColumn("dbo.NonownedAnimals", "AnimalId", c => c.Int(nullable: false));
            AlterColumn("dbo.MedicalHistories", "AnimalId", c => c.Int(nullable: false));
            AlterColumn("dbo.LiabilityReleases", "AnimalId", c => c.Int(nullable: false));
            AlterColumn("dbo.Insurances", "AnimalId", c => c.Int(nullable: false));
            AlterColumn("dbo.FacilitySecondaryContacts", "FacilityId", c => c.Int(nullable: false));
            AlterColumn("dbo.ChipIdentifications", "AnimalId", c => c.Int(nullable: false));
            AlterColumn("dbo.AnimalBehaviors", "AnimalId", c => c.Int(nullable: false));
            AlterColumn("dbo.AdditionalPetInfoes", "AnimalId", c => c.Int(nullable: false));
            AlterColumn("dbo.AdditionalContacts", "OwnerId", c => c.Int(nullable: false));
        }
    }
}
