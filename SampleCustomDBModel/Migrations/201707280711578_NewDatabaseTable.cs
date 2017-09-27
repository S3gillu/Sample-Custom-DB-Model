namespace SampleCustomDBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDatabaseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Age", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Age");
        }
    }
}
