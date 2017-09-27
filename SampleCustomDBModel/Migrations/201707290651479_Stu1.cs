namespace SampleCustomDBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stu1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "MaritalStatus", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "MaritalStatus");
        }
    }
}
