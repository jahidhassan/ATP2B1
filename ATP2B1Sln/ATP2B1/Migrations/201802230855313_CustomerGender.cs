namespace ATP2B1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerGender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Gender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Gender");
        }
    }
}
