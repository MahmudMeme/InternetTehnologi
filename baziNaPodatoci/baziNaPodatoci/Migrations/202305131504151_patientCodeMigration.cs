namespace baziNaPodatoci.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class patientCodeMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "PatientCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Patients", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Patients", "Gender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "Gender", c => c.String());
            AlterColumn("dbo.Patients", "Name", c => c.String());
            DropColumn("dbo.Patients", "PatientCode");
        }
    }
}
