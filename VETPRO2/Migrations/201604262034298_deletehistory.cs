namespace VETPRO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletehistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnimalHistory2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrentMedication = c.String(),
                        AnimalAllergies = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.AnimalHistories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AnimalHistories",
                c => new
                    {
                        AnimalHistoryId = c.Int(nullable: false, identity: true),
                        CurrentMedication = c.String(),
                        AnimalAllergies = c.String(),
                    })
                .PrimaryKey(t => t.AnimalHistoryId);
            
            DropTable("dbo.AnimalHistory2");
        }
    }
}
