namespace ATP2B1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customer_Override : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Customers", "MobileNo", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "MobileNo", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
