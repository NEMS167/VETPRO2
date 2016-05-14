namespace VETPRO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updates : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EvacCountyAdditionalInfoes", newName: "FacilityAdditionalInfoes");
            RenameTable(name: "dbo.EvacCountyContacts", newName: "FacilityContacts");
            RenameTable(name: "dbo.ShelterCapacities", newName: "FacilityCapacities");
            RenameTable(name: "dbo.ShelterOccupancies", newName: "FacilityOccupancies");
            CreateTable(
                "dbo.FacilityInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FacilityId = c.String(),
                        LocationName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        PhoneNumber = c.String(),
                        Directions = c.String(),
                        OperationalHours = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FacilitySecondaryContacts",
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
                "dbo.UserAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        Permission = c.Int(nullable: false),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            RenameColumn("OwnerInfoes", "OwnerId", "Id");
            AddColumn("OwnerInfoes", "OwnerId", c => c.String(nullable: false));
            DropTable("dbo.EvacCountyInfoes");
            DropTable("dbo.EvacCountySecondaryContacts");
            DropTable("dbo.EvacHubAdditionalInfoes");
            DropTable("dbo.EvacHubContacts");
            DropTable("dbo.EvacHubInfoes");
            DropTable("dbo.EvacHubSecondaryContacts");
            DropTable("dbo.ReceptionCenterAdditionalInfoes");
            DropTable("dbo.ReceptionCenterContacts");
            DropTable("dbo.ReceptionCenterInfoes");
            DropTable("dbo.ReceptionCenterSecondaryContacts");
            DropTable("dbo.ShelterAdditionalInfoes");
            DropTable("dbo.ShelterContacts");
            DropTable("dbo.ShelterInfoes");
            DropTable("dbo.ShelterSecondaryContacts");
            DropTable("dbo.VetMedOpAdditionalInfoes");
            DropTable("dbo.VetMedOpCapacities");
            DropTable("dbo.VetMedOpContacts");
            DropTable("dbo.VetMedOpInfoes");
            DropTable("dbo.VetMedOpOccupancies");
            DropTable("dbo.VetMedOpSecondaryContacts");
        }
        
        public override void Down()
        {
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
                "dbo.VetMedOpAdditionalInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VetMedId = c.Int(nullable: false),
                        EvacHubNotes = c.String(),
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
                "dbo.ShelterAdditionalInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShelterId = c.Int(nullable: false),
                        EvacHubNotes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.ReceptionCenterAdditionalInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReceptionCenterId = c.Int(nullable: false),
                        EvacHubNotes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.EvacHubAdditionalInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EvacHubId = c.Int(nullable: false),
                        EvacHubNotes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            RenameColumn("OwnerInfoes", "Id", "OwnerId");
            DropColumn("dbo.OwnerInfoes", "Id");
            DropTable("dbo.UserAccounts");
            DropTable("dbo.FacilitySecondaryContacts");
            DropTable("dbo.FacilityInfoes");
            RenameTable(name: "dbo.FacilityOccupancies", newName: "ShelterOccupancies");
            RenameTable(name: "dbo.FacilityCapacities", newName: "ShelterCapacities");
            RenameTable(name: "dbo.FacilityContacts", newName: "EvacCountyContacts");
            RenameTable(name: "dbo.FacilityAdditionalInfoes", newName: "EvacCountyAdditionalInfoes");
        }
    }
}
