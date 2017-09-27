namespace SampleCustomDBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stu3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "Edu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Edu", c => c.Boolean(nullable: false));
        }
    }
}
