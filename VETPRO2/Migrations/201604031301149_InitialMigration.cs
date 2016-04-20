namespace VETPRO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdditionalContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OwnerId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PetRelation = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AdditionalPetInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnimalId = c.Int(nullable: false),
                        Belongings = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AnimalBehaviors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnimalId = c.Int(nullable: false),
                        AggressionComments = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AnimalHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrentMedication = c.String(),
                        AnimalAllergies = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AnimalInfoes",
                c => new
                    {
                        AnimalId = c.Int(nullable: false, identity: true),
                        OwnerId = c.String(),
                        AnimalName = c.String(),
                        AnimalSpecies = c.String(),
                        AnimalBreed = c.String(),
                        AnimalAge = c.Int(nullable: false),
                        AnimalEstimatedWeight = c.Int(nullable: false),
                        AnimalDescription = c.String(),
                    })
                .PrimaryKey(t => t.AnimalId);
            
            CreateTable(
                "dbo.ChipIdentifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnimalId = c.Int(nullable: false),
                        MicrochipNumber = c.String(),
                        EartagNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EvacCountyAdditionalInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EvacCountyId = c.Int(nullable: false),
                        EvacCountyNotes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EvacCountyContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EvacCountyId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EvacCountyInfoes",
                c => new
                    {
                        EvacCountyId = c.Int(nullable: false, identity: true),
                        LocationName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        PhoneNumber = c.String(),
                        Directions = c.String(),
                        OperationalHours = c.String(),
                    })
                .PrimaryKey(t => t.EvacCountyId);
            
            CreateTable(
                "dbo.EvacCountySecondaryContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EvacCountyId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EvacHubAdditionalInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EvacHubId = c.Int(nullable: false),
                        EvacHubNotes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EvacHubContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EvacHubId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EvacHubInfoes",
                c => new
                    {
                        EvacHubId = c.Int(nullable: false, identity: true),
                        LocationName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        PhoneNumber = c.String(),
                        Directions = c.String(),
                        OperationalHours = c.String(),
                    })
                .PrimaryKey(t => t.EvacHubId);
            
            CreateTable(
                "dbo.EvacHubSecondaryContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EvacHubId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Insurances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnimalId = c.Int(nullable: false),
                        InsuranceName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LiabilityReleases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnimalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MedicalHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnimalId = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Vaccination = c.String(),
                        Reason = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NonownedAnimals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnimalId = c.Int(nullable: false),
                        Organization = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OwnerInfoes",
                c => new
                    {
                        OwnerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        HomeAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        County = c.String(),
                        ZipCode = c.String(),
                        HomePhone = c.Int(nullable: false),
                        CellPhone = c.Int(nullable: false),
                        DriversLicenseNumber = c.String(),
                        HumanEvacNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.OwnerId);
            
            CreateTable(
                "dbo.ReceptionCenterAdditionalInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReceptionCenterId = c.Int(nullable: false),
                        EvacHubNotes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReceptionCenterContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReceptionCenterId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReceptionCenterInfoes",
                c => new
                    {
                        ReceptionCenterId = c.Int(nullable: false, identity: true),
                        LocationName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        PhoneNumber = c.String(),
                        Directions = c.String(),
                        OperationalHours = c.String(),
                    })
                .PrimaryKey(t => t.ReceptionCenterId);
            
            CreateTable(
                "dbo.ReceptionCenterSecondaryContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReceptionCenterId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SecondaryContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OwnerId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        HomeAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        HomePhone = c.String(),
                        CellPhone = c.String(),
                        DriversLicenseNumber = c.String(),
                        HumanEvacNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShelterAdditionalInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShelterId = c.Int(nullable: false),
                        EvacHubNotes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShelterCapacities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SmallAnimalCapacity = c.Int(nullable: false),
                        LargeAnimalCapacity = c.Int(nullable: false),
                        AdditionalCapacityInfo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShelterContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShelterId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShelterInfoes",
                c => new
                    {
                        ShelterId = c.Int(nullable: false, identity: true),
                        LocationName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        PhoneNumber = c.String(),
                        Directions = c.String(),
                        OperationalHours = c.String(),
                    })
                .PrimaryKey(t => t.ShelterId);
            
            CreateTable(
                "dbo.ShelterOccupancies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SmallAnimalOccupancy = c.Int(nullable: false),
                        LargeAnimalOccupancy = c.Int(nullable: false),
                        AdditionalOccupancyInfo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShelterSecondaryContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShelterId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VetMedOpAdditionalInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VetMedId = c.Int(nullable: false),
                        EvacHubNotes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VetMedOpCapacities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SmallAnimalCapacity = c.Int(nullable: false),
                        LargeAnimalCapacity = c.Int(nullable: false),
                        AdditionalCapacityInfo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VetMedOpContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VetMedId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VetMedOpInfoes",
                c => new
                    {
                        VetMedId = c.Int(nullable: false, identity: true),
                        LocationName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        PhoneNumber = c.String(),
                        Directions = c.String(),
                        OperationalHours = c.String(),
                    })
                .PrimaryKey(t => t.VetMedId);
            
            CreateTable(
                "dbo.VetMedOpOccupancies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SmallAnimalOccupancy = c.Int(nullable: false),
                        LargeAnimalOccupancy = c.Int(nullable: false),
                        AdditionalOccupancyInfo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VetMedOpSecondaryContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VetMedId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VetMedOpSecondaryContacts");
            DropTable("dbo.VetMedOpOccupancies");
            DropTable("dbo.VetMedOpInfoes");
            DropTable("dbo.VetMedOpContacts");
            DropTable("dbo.VetMedOpCapacities");
            DropTable("dbo.VetMedOpAdditionalInfoes");
            DropTable("dbo.ShelterSecondaryContacts");
            DropTable("dbo.ShelterOccupancies");
            DropTable("dbo.ShelterInfoes");
            DropTable("dbo.ShelterContacts");
            DropTable("dbo.ShelterCapacities");
            DropTable("dbo.ShelterAdditionalInfoes");
            DropTable("dbo.SecondaryContacts");
            DropTable("dbo.ReceptionCenterSecondaryContacts");
            DropTable("dbo.ReceptionCenterInfoes");
            DropTable("dbo.ReceptionCenterContacts");
            DropTable("dbo.ReceptionCenterAdditionalInfoes");
            DropTable("dbo.OwnerInfoes");
            DropTable("dbo.NonownedAnimals");
            DropTable("dbo.MedicalHistories");
            DropTable("dbo.LiabilityReleases");
            DropTable("dbo.Insurances");
            DropTable("dbo.EvacHubSecondaryContacts");
            DropTable("dbo.EvacHubInfoes");
            DropTable("dbo.EvacHubContacts");
            DropTable("dbo.EvacHubAdditionalInfoes");
            DropTable("dbo.EvacCountySecondaryContacts");
            DropTable("dbo.EvacCountyInfoes");
            DropTable("dbo.EvacCountyContacts");
            DropTable("dbo.EvacCountyAdditionalInfoes");
            DropTable("dbo.ChipIdentifications");
            DropTable("dbo.AnimalInfoes");
            DropTable("dbo.AnimalHistories");
            DropTable("dbo.AnimalBehaviors");
            DropTable("dbo.AdditionalPetInfoes");
            DropTable("dbo.AdditionalContacts");
        }
    }
}
