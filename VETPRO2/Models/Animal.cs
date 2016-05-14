using System;
using System.Collections.Generic;
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
    public class UserAccount
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int Permission { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Passwords don't match!")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }

    public class CompositeModel
    {
        public AnimalInfo AnimalInfo { get; set; }
        public AnimalBehavior AnimalBehavior { get; set;}
        public AnimalHistory AnimalHistory { get; set; }
        public AdditionalPetInfo AdditionalPetInfo { get; set; }
        public ChipIdentification ChipIdentification { get; set; }
        //public MedicalHistory MedicalHistory { get; set; }
    }

    public class OwnerCompositeModel
    {
        public OwnerInfo OwnerInfo { get; set; }
        public AdditionalContact AdditionalContact { get; set; }
        public Insurance Insurance { get; set; }
        public SecondaryContact SecondaryContact { get; set; }
        public UserAccount UserAccount { get; set; }
    }

    public class FacilityCompositeModel
    {
        public FacilityAdditionalInfo FacilityAdditionalInfo { get; set; }
        public FacilityContact FacilityContact { get; set; }
        public FacilitySecondaryContact FacilitySecondaryContact { get; set; }
        public FacilityInfo FacilityInfo { get; set; }
        public FacilityCapacity FacilityCapacity { get; set; }
        public FacilityOccupancy FacilityOccupancy { get; set; }
        public UserAccount UserAccount { get; set; }
    }


    public class AdditionalContact
    {
        public int Id { get; set; }
        public string OwnerId { get; set; } //foreign key, grab owner id number from owner id table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PetRelation { get; set; }
        public int PhoneNumber { get; set; }
    }

    public class AdditionalPetInfo
    {
        public int Id { get; set; }
        public string AnimalId { get; set; } //foreign key, grab animal id number from animal id table
        public string Belongings { get; set; }
        public string Comment { get; set; }

    }

    public class AnimalBehavior
    {
        public int Id { get; set; }
        public string AnimalId { get; set; } //foreign key, grab animal id number from animal id table
        [Display(Name="Agression Comments")]
        public string AggressionComments { get; set; }
    }

    public class AnimalHistory
    {
        public int Id { get; set; } //foreign key, grab animal id number from animal id table
        public string CurrentMedication { get; set; }
        public string AnimalAllergies { get; set; }
    }

    public class AnimalInfo
    {
        public int Id { get; set; } //this is the primary key number you'll be needing for a lot of tables!!!
        public string AnimalId { get; set; }
        public string FacilityId { get; set; }
        public string OwnerId { get; set; } //foreign key, grab owner id number from the owner id table
        public string AnimalName { get; set; }
        public string AnimalSpecies { get; set; }
        public string AnimalBreed { get; set; }
        public char AnimalGender { get; set; }
        public int AnimalAge { get; set; }
        public int AnimalEstimatedWeight { get; set; }
        public string AnimalDescription { get; set; }        //we need to figure out how to add the animals photos to this!!
    }

    public class ChipIdentification
    {
        public int Id { get; set; }
        public string AnimalId { get; set; } //foreign key, grab animal id number from the animal id table
        public string MicrochipNumber { get; set; }
        public string EartagNumber { get; set; }
    }

    public class FacilityAdditionalInfo
    {
        public int Id { get; set; }
        public string FacilityId { get; set; } //foreign key, grab evac county id number from the evac county id table
        public string FacilityNotes { get; set; }
    }

    public class FacilityContact
    {
        public int Id { get; set; }
        public string FacilityId { get; set; } //foreign key, grab evac county id number from the evac county id table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class FacilitySecondaryContact
    {
        public int Id { get; set; }
        public string FacilityId { get; set; } //foreign key, grab evac county id number from the evac county id table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class FacilityInfo
    {
        public int Id { get; set; }
        public string FacilityId { get; set; }//this is the primary key number for all the evac county tables
        public string LocationKind { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Directions { get; set; }
        public string OperationalHours { get; set; }
        public UserAccount UserAccount { get; set; }
    }

    public class Insurance
    {
        public int Id { get; set; }
        public string AnimalId { get; set; } //foreign key, get the animal id number from the animal id table
        public char YesorNo { get; set; }
        public string InsuranceName { get; set; }
    }

    public class LiabilityRelease
    {
        public int Id { get; set; }
        public string AnimalId { get; set; } //foreign key, get the animal id number from the animal id table
        public char YesorNo { get; set; }
        //we need a space for image upload for "form upload"

    }

    public class MedicalHistory
    {
        public int Id { get; set; }
        public string AnimalId { get; set; } //foreign key, get the animal id number from the animal id table
        public int Year { get; set; }
        public string Vaccination { get; set; }
        public string Reason { get; set; }
    }

    public class NonownedAnimal
    {
        public int Id { get; set; }
        public string AnimalId { get; set; } //foreign key, get the animal id number from the animal id table
        public string Organization { get; set; }
        public string Phone { get; set; }
    }

    public class OwnerInfo
    {
        public int Id { get; set; }
        public string OwnerId { get; set; } //this is the primary key number for several other important tables to use
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
        public UserAccount UserAccount { get; set; }
    }

    public class SecondaryContact
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
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

    public class FacilityCapacity
    {
        public int Id { get; set; }
        public string FacilityId { get; set; }
        public int SmallAnimalCapacity { get; set; }
        public int LargeAnimalCapacity { get; set; }
        public string AdditionalCapacityInfo { get; set; }
    }

    public class FacilityOccupancy
    {
        public int Id { get; set; }
        public string FacilityId { get; set; }
        public int SmallAnimalOccupancy { get; set; }
        public int LargeAnimalOccupancy { get; set; }
        public string AdditionalOccupancyInfo { get; set; }
    }

    public class ShelterOperations
    {
        public int Id { get; set; }
        public string FacilityId { get; set; }
        public string JobName { get; set; }
        public string Description { get; set; }
    }

    public class TrackingOperations
    {
        public int Id { get; set; }
        public string FacilityId { get; set; }
        public string MovementStatus { get; set; }
        public string Description { get; set; }
    }

    public class VetContext : DbContext
    {
        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<AdditionalContact> AdditionalContact { get; set; }
        public DbSet<AdditionalPetInfo> AdditonalPetInfo { get; set; }
        public DbSet<AnimalBehavior> AnimalBehavior { get; set; }
        public DbSet<AnimalHistory> AnimalHistory { get; set; }
        public DbSet<AnimalInfo> AnimalInfo { get; set; }
        public DbSet<ChipIdentification> ChipIdentification { get; set; }
        public DbSet<FacilityAdditionalInfo> FacilityAdditionalInfo { get; set; }
        public DbSet<FacilityContact> FacilityContact { get; set; }
        public DbSet<FacilitySecondaryContact> FacilitySecondaryContact { get; set; }
        public DbSet<FacilityInfo> FacilityInfo { get; set; }
        public DbSet<FacilityCapacity> FacilityCapacity { get; set; }
        public DbSet<FacilityOccupancy> FacilityOccupancy { get; set; }
        public DbSet<Insurance> Insurance { get; set; }
        public DbSet<LiabilityRelease> LiabilityRelease { get; set; }
        public DbSet<MedicalHistory> MedicalHistory { get; set; }
        public DbSet<NonownedAnimal> Nonowned { get; set; }
        public DbSet<OwnerInfo> OwnerInfos { get; set; }
        public DbSet<SecondaryContact> SecondaryContact { get; set; }
        public DbSet<ShelterOperations> ShelterOperations { get; set; }
        public DbSet<TrackingOperations> TrackingOperations { get; set; }



        public VetContext() : base("name=DefaultConnection")
        {

        }
    }

}