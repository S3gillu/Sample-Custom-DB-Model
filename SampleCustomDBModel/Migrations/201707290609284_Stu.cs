namespace SampleCustomDBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Qualification", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "EmailId", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Age", c => c.String(nullable: false));
            DropColumn("dbo.Students", "Department");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Department", c => c.String());
            AlterColumn("dbo.Students", "Age", c => c.String());
            AlterColumn("dbo.Students", "EmailId", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
            DropColumn("dbo.Students", "Qualification");
        }
    }
}
