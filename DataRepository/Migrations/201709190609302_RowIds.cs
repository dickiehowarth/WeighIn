namespace DataRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RowIds : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "RowId", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "RowId");
        }
    }
}
