namespace ATP2B1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTypeSeed : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MembershipTypes(Name,SignUpFee,Duration,Discount) values('PayAsYouGo',0,0,0)");
            Sql("Insert into MembershipTypes(Name,SignUpFee,Duration,Discount) values('Monthly',10,1,10)");
            Sql("Insert into MembershipTypes(Name,SignUpFee,Duration,Discount) values('Quaterly',35,3,15)");
            Sql("Insert into MembershipTypes(Name,SignUpFee,Duration,Discount) values('Anually',100,12,25)");
        }
        
        public override void Down()
        {
            Sql("Delete from MembershipTypes");
        }
    }
}
