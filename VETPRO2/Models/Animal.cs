using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using Microsoft.Owin.Security;

namespace VETPRO2.Models
{
    public class CompositeModel
    {
        public AnimalInfo AnimalInfo { get; set; }
        public AnimalBehavior AnimalBehavior { get; set;}
        public AdditionalPetInfo AdditionalPetInfo { get; set; }
        public AnimalHistory2 AnimalHistory2 { get; set; }
        public ChipIdentification ChipIdentification { get; set; }
        //public MedicalHistory MedicalHistory { get; set; }



    }

    public class OwnerCompositeModel
    {
        public OwnerInfo OwnerInfo { get; set; }
        public AdditionalContact AdditionalContact { get; set; }
        public Insurance Insurance { get; set; }
        public LiabilityRelease LiabilityRelease { get; set; }
        public SecondaryContact SecondaryContact { get; set; }
    }

    public class FacilityCompositeModel
    {
        public EvacCountyAdditionalInfo EvacCountyAdditionalInfo { get; set; }
        public EvacCountyContact EvacCountyContact { get; set; }
        public EvacCountySecondaryContact EvacCountySecondaryContact { get; set; }
        public EvacCountyInfo EvacCountyInfo { get; set; }
        public EvacHubAdditionalInfo EvacHubAdditionalInfo { get; set; }
        public EvacHubContact EvacHubContact { get; set; }
        public EvacHubSecondaryContact EvacHubSecondaryContact { get; set; }
        public EvacHubInfo EvacHubInfo { get; set; }
        public ReceptionCenterInfo ReceptionCenterInfo { get; set; }
        public ReceptionCenterAdditionalInfo  ReceptionCenterAdditionalInfo{ get; set;}
        public ReceptionCenterSecondaryContact ReceptionCenterSecondaryContact { get; set; }
        public ShelterContact ShelterContact { get; set; }
        public ShelterAdditionalInfo ShelterAdditionalInfo { get; set; }
        public ShelterSecondaryContact ShelterSecondaryContact { get; set; }
        public ShelterCapacity ShelterCapacity { get; set; }
        public ShelterOccupancy ShelterOccupancy { get; set; }
        public ShelterOperations ShelterOperations { get; set; }
        public VetMedOpAdditionalInfo VetMedOpAdditionalInfo { get; set; }
        public VetMedOpContact VetMedOpContact { get; set; }
        public VetMedOpSecondaryContact VetMedOpSecondaryContact { get; set; }
        public VetMedOpInfo VetMedOpInfo { get; set; }
        public VetMedOpCapacity VetMedOpCapacity { get; set; }
        public VetMedOpOccupancy VetMedOpOccupancy { get; set; }



    }


    public class AdditionalContact
    {
        public int Id { get; set; }
        public int OwnerId { get; set; } //foreign key, grab owner id number from owner id table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PetRelation { get; set; }
        public int PhoneNumber { get; set; }

    }

    public class AdditionalPetInfo
    {
        public int Id { get; set; }
        public int AnimalId { get; set; } //foreign key, grab animal id number from animal id table
        [Display(Name = "Belongings")]
        public string Belongings { get; set; }
        [Display(Name = "Comments")]
        public string Comment { get; set; }

    }

    public class AnimalBehavior
    {
        public int Id { get; set; }
        public int AnimalId { get; set; } //foreign key, grab animal id number from animal id table
        [Display(Name="Agression Comments")]
        public string AggressionComments { get; set; }
    }

    /*public class AnimalHistory
    {
        public int Id { get; set; } //foreign key, grab animal id number from animal id table
        [Display(Name = "Current Medications")]
        public string CurrentMedication { get; set; }
        [Display(Name = "Allergies")]
        public string AnimalAllergies { get; set; }
    }*/

    public class AnimalHistory2
    {
        public int Id { get; set; } //foreign key, grab animal id number from animal id table
        [Display(Name = "Current Medications")]
        public string CurrentMedication { get; set; }
        [Display(Name = "Allergies")]
        public string AnimalAllergies { get; set; }
    }

    public class AnimalInfo
    {
        [Key]
        public int AnimalId { get; set; } //this is the primary key number you'll be needing for a lot of tables!!!
        public string OwnerId { get; set; } //foreign key, grab owner id number from the owner id table
        [Display(Name = "Name")]
        public string AnimalName { get; set; }
        [Display(Name = "Species")]
        public string AnimalSpecies { get; set; }
        [Display(Name = "Breed")]
        public string AnimalBreed { get; set; }
        [Display(Name = "Gender")]
        public char AnimalGender { get; set; }
        [Display(Name = "Age")]
        public int AnimalAge { get; set; }
        [Display(Name = "Estimated Weight")]
        public int AnimalEstimatedWeight { get; set; }
        [Display(Name = "Description")]
        public string AnimalDescription { get; set; }        //we need to figure out how to add the animals photos to this!!
    }

    public class ChipIdentification
    {
        public int Id { get; set; }
        public int AnimalId { get; set; } //foreign key, grab animal id number from the animal id table
        [Display(Name = "Microchip Number")]
        public string MicrochipNumber { get; set; }
        [Display(Name = "Eartag Number")]
        public string EartagNumber { get; set; }
    }

    public class EvacCountyAdditionalInfo
    {
        public int Id { get; set; }
        public int EvacCountyId { get; set; } //foreign key, grab evac county id number from the evac county id table
        public string EvacCountyNotes { get; set; }
    }

    public class EvacCountyContact
    {
        public int Id { get; set; }
        public int EvacCountyId { get; set; } //foreign key, grab evac county id number from the evac county id table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class EvacCountySecondaryContact
    {
        public int Id { get; set; }
        public int EvacCountyId { get; set; } //foreign key, grab evac county id number from the evac county id table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class EvacCountyInfo
    {
        [Key]
        public int EvacCountyId { get; set; }//this is the primary key number for all the evac county tables
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Directions { get; set; }
        public string OperationalHours { get; set; }

    }

    public class EvacHubAdditionalInfo
    {
        public int Id { get; set; }
        public int EvacHubId { get; set; }
        public string EvacHubNotes { get; set; }
    }

    public class EvacHubContact
    {
        public int Id { get; set; }
        public int EvacHubId { get; set; } //foreign key, grab evac hub id number from the evac hub id table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class EvacHubSecondaryContact
    {
        public int Id { get; set; }
        public int EvacHubId { get; set; } //foreign key, grab evac hub id number from the evac hub id table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class EvacHubInfo
    {
        [Key]
        public int EvacHubId { get; set; }//this is the primary key number for all the evac hub tables
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Directions { get; set; }
        public string OperationalHours { get; set; }

    }

    public class Insurance
    {
        public int Id { get; set; }
        public int AnimalId { get; set; } //foreign key, get the animal id number from the animal id table
        public char YesorNo { get; set; }
        public string InsuranceName { get; set; }
    }

    public class LiabilityRelease
    {
        public int Id { get; set; }
        public int AnimalId { get; set; } //foreign key, get the animal id number from the animal id table
        public char YesorNo { get; set; }
        //we need a space for image upload for "form upload"

    }

    public class MedicalHistory
    {
        public int Id { get; set; }
        public int AnimalId { get; set; } //foreign key, get the animal id number from the animal id table
        public int Year { get; set; }
        public string Vaccination { get; set; }
        public string Reason { get; set; }
    }

    public class NonownedAnimal
    {
        public int Id { get; set; }
        public int AnimalId { get; set; } //foreign key, get the animal id number from the animal id table
        public string Organization { get; set; }
        public string Phone { get; set; }
    }

    public class OwnerInfo
    {
        [Key]
        public int OwnerId { get; set; } //this is the primary key number for several other important tables to use
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string ZipCode { get; set; }
        public int HomePhone { get; set; }
        public int CellPhone { get; set; }
        public string DriversLicenseNumber { get; set; }
        public string HumanEvacNumber { get; set; }
        public string Email { get; set; }
        //we need a thing to save owner photos

    }

    public class ReceptionCenterAdditionalInfo
    {
        public int Id { get; set; }
        public int ReceptionCenterId { get; set; }
        public string EvacHubNotes { get; set; }
    }

    public class ReceptionCenterContact
    {
        public int Id { get; set; }
        public int ReceptionCenterId { get; set; } //foreign key, grab evac hub id number from the evac hub id table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class ReceptionCenterSecondaryContact
    {
        public int Id { get; set; }
        public int ReceptionCenterId { get; set; } //foreign key, grab evac hub id number from the evac hub id table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class ReceptionCenterInfo
    {
        [Key]
        public int ReceptionCenterId { get; set; } //this is the primary key number for all the evac hub tables
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Directions { get; set; }
        public string OperationalHours { get; set; }

    }

    public class SecondaryContact
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string DriversLicenseNumber { get; set; }
        public string HumanEvacNumber { get; set; }

    }


    public class ShelterAdditionalInfo
    {
        public int Id { get; set; }
        public int ShelterId { get; set; }
        public string EvacHubNotes { get; set; }
    }

    public class ShelterContact
    {
        public int Id { get; set; }
        public int ShelterId { get; set; } //foreign key, grab evac hub id number from the evac hub id table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class ShelterSecondaryContact 
    {
        public int Id { get; set; }
        public int ShelterId { get; set; } //foreign key, grab evac hub id number from the evac hub id table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class ShelterInfo 
    {
        [Key]
        public int ShelterId { get; set; } //this is the primary key number for all the evac hub tables
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Directions { get; set; }
        public string OperationalHours { get; set; }

    }

    public class ShelterCapacity
    {
        public int Id { get; set; }
        public int SmallAnimalCapacity { get; set; }
        public int LargeAnimalCapacity { get; set; }
        public string AdditionalCapacityInfo { get; set; }
    }

    public class ShelterOccupancy
    {
        public int Id { get; set; }
        public int SmallAnimalOccupancy { get; set; }
        public int LargeAnimalOccupancy { get; set; }
        public string AdditionalOccupancyInfo { get; set; }
    }

    public class ShelterOperations
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public string Description { get; set; }
    }

    public class TrackingOperations
    {
        public int Id { get; set; }
        public string MovementStatus { get; set; }
        public string Description { get; set; }
    }

    public class VetMedOpAdditionalInfo
    {
        public int Id { get; set; }
        public int VetMedId { get; set; }
        public string EvacHubNotes { get; set; }
    }

    public class VetMedOpContact
    {
        public int Id { get; set; }
        public int VetMedId { get; set; } //foreign key, grab evac hub id number from the evac hub id table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class VetMedOpSecondaryContact
    {
        public int Id { get; set; }
        public int VetMedId { get; set; } //foreign key, grab evac hub id number from the evac hub id table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class VetMedOpInfo
    {
        [Key]
        public int VetMedId { get; set; } //this is the primary key number for all the evac hub tables
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Directions { get; set; }
        public string OperationalHours { get; set; }

    }

    public class VetMedOpCapacity
    {
        public int Id { get; set; }
        public int SmallAnimalCapacity { get; set; }
        public int LargeAnimalCapacity { get; set; }
        public string AdditionalCapacityInfo { get; set; }
    }

    public class VetMedOpOccupancy
    {
        public int Id { get; set; }
        public int SmallAnimalOccupancy { get; set; }
        public int LargeAnimalOccupancy { get; set; }
        public string AdditionalOccupancyInfo { get; set; }
    }

    public class VetContext : DbContext
    {
        public DbSet<AdditionalContact> AdditionalContact { get; set; }
        public DbSet<AdditionalPetInfo> AdditonalPetInfo { get; set; }
        public DbSet<AnimalBehavior> AnimalBehavior { get; set; }
        public DbSet<AnimalHistory2> AnimalHistory { get; set; }
        public DbSet<AnimalInfo> AnimalInfos { get; set; }
        public DbSet<ChipIdentification> ChipIdentification { get; set; }
        public DbSet<EvacCountyAdditionalInfo> EvacCountyAdditionalInfo { get; set; }
        public DbSet<EvacCountyContact> EvacCountyContact { get; set; }
        public DbSet<EvacCountySecondaryContact> EvacCountySecondaryContact { get; set; }
        public DbSet<EvacCountyInfo> EvacCountyInfos { get; set; }
        public DbSet<EvacHubAdditionalInfo> EvacHubAdditionalInfo { get; set; }
        public DbSet<EvacHubContact> EvacHubContact { get; set; }
        public DbSet<EvacHubSecondaryContact> EvacHubSecondaryContact { get; set; }
        public DbSet<EvacHubInfo> EvacHubInfos { get; set; }
        public DbSet<Insurance> Insurance { get; set; }
        public DbSet<LiabilityRelease> LiabilityRelease { get; set; }
        public DbSet<MedicalHistory> MedicalHistory { get; set; }
        public DbSet<NonownedAnimal> Nonowned { get; set; }
        public DbSet<OwnerInfo> OwnerInfos { get; set; }
        public DbSet<ReceptionCenterAdditionalInfo> ReceptionCenterAdditionalInfos { get; set; }
        public DbSet<ReceptionCenterContact> ReceptionCenterContacts { get; set; }
        public DbSet<ReceptionCenterSecondaryContact> ReceptionCenterSecondaryContacts { get; set; }
        public DbSet<ReceptionCenterInfo> ReceptionCenterInfos { get; set; }
        public DbSet<SecondaryContact> SecondaryContacts { get; set; }
        public DbSet<ShelterAdditionalInfo> ShelterAdditionalInfos { get; set; }
        public DbSet<ShelterCapacity> ShelterCapacities { get; set; }
        public DbSet<ShelterContact> ShelterContacts { get; set; }
        public DbSet<ShelterInfo> ShelterInfos { get; set; }
        public DbSet<ShelterOccupancy> ShelterOccupancies { get; set; }
        public DbSet<ShelterSecondaryContact> ShelterSecondaryContacts { get; set; }
        public DbSet<ShelterOperations> ShelterOperationses { get; set; }
        public DbSet<TrackingOperations> TrackingOperationses { get; set; }
        public DbSet<VetMedOpAdditionalInfo> VetMedOpAdditionalInfos { get; set; }
        public DbSet<VetMedOpCapacity> VetMedOpCapacities { get; set; }
        public DbSet<VetMedOpContact> VetMedOpContacts { get; set; }
        public DbSet<VetMedOpInfo> VetMedOpInfos { get; set; }
        public DbSet<VetMedOpOccupancy> VetMedOpOccupancies { get; set; }
        public DbSet<VetMedOpSecondaryContact> VetMedOpSecondaryContacts { get; set; }



        public VetContext() : base("name=DefaultConnection")
        {

        }
    }

}