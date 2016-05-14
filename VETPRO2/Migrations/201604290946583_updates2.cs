namespace VETPRO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updates2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FacilityInfoes", "UserAccount_Id", c => c.Int());
            AddColumn("dbo.OwnerInfoes", "UserAccount_Id", c => c.Int());
            CreateIndex("dbo.FacilityInfoes", "UserAccount_Id");
            CreateIndex("dbo.OwnerInfoes", "UserAccount_Id");
            AddForeignKey("dbo.FacilityInfoes", "UserAccount_Id", "dbo.UserAccounts", "Id");
            AddForeignKey("dbo.OwnerInfoes", "UserAccount_Id", "dbo.UserAccounts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OwnerInfoes", "UserAccount_Id", "dbo.UserAccounts");
            DropForeignKey("dbo.FacilityInfoes", "UserAccount_Id", "dbo.UserAccounts");
            DropIndex("dbo.OwnerInfoes", new[] { "UserAccount_Id" });
            DropIndex("dbo.FacilityInfoes", new[] { "UserAccount_Id" });
            DropColumn("dbo.OwnerInfoes", "UserAccount_Id");
            DropColumn("dbo.FacilityInfoes", "UserAccount_Id");
        }
    }
}
