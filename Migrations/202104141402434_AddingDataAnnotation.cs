namespace TrialTours.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDataAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registrations", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Registrations", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "ConfirmPassword", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registrations", "ConfirmPassword", c => c.String());
            AlterColumn("dbo.Registrations", "Password", c => c.String());
            AlterColumn("dbo.Registrations", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Registrations", "Email", c => c.String());
            AlterColumn("dbo.Registrations", "Name", c => c.String());
        }
    }
}
