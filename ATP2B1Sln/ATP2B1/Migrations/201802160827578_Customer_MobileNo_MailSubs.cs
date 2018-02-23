namespace ATP2B1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customer_MobileNo_MailSubs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MobileNo", c => c.String());
            AddColumn("dbo.Customers", "IsSubscribeToMail", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribeToMail");
            DropColumn("dbo.Customers", "MobileNo");
        }
    }
}
