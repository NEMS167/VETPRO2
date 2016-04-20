namespace VETPRO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrackingMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrackingOperations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovementStatus = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrackingOperations");
        }
    }
}
