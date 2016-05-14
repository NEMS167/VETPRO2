using VETPRO2.Models;

namespace VETPRO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class animalinfoid : DbMigration
    {
        public override void Up()
        {
            RenameColumn("AnimalInfoes", "AnimalId", "Id");
        }
        
        public override void Down()
        {
            RenameColumn("AnimalInfoes", "Id", "AnimalId");
        }
    }
}
