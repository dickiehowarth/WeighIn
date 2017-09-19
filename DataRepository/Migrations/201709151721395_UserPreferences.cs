namespace DataRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserPreferences : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "UserPreferences_Id", c => c.Long());
            AlterColumn("dbo.UserPreferences", "Kg", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "UserPreferences_Id");
            AddForeignKey("dbo.Users", "UserPreferences_Id", "dbo.UserPreferences", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserPreferences_Id", "dbo.UserPreferences");
            DropIndex("dbo.Users", new[] { "UserPreferences_Id" });
            AlterColumn("dbo.UserPreferences", "Kg", c => c.Boolean(nullable: false));
            DropColumn("dbo.Users", "UserPreferences_Id");
            DropColumn("dbo.Users", "Age");
        }
    }
}
