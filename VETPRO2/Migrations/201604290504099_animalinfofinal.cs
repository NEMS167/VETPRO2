namespace VETPRO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class animalinfofinal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AnimalInfoes", "AnimalId", c => c.String(nullable: false));
            AddColumn("dbo.AnimalInfoes", "FacilityId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AnimalInfoes", "FacilityId");
            DropColumn("dbo.AnimalInfoes", "AnimalId");
        }
    }
}
