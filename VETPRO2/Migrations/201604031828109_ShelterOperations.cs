namespace VETPRO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShelterOperations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShelterOperations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ShelterOperations");
        }
    }
}
