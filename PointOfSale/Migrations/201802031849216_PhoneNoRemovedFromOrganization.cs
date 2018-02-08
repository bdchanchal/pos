namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneNoRemovedFromOrganization : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Organizations", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Organizations", "Phone", c => c.String());
        }
    }
}
