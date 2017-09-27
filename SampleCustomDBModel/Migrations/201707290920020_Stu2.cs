namespace SampleCustomDBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stu2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Edu", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Edu");
        }
    }
}
