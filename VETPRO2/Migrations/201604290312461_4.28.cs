namespace VETPRO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _428 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AnimalHistory2", newName: "AnimalHistories");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AnimalHistories", newName: "AnimalHistory2");
        }
    }
}
