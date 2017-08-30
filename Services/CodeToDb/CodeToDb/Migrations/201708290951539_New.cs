namespace CodeToDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Newcol", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "Newcol");
        }
    }
}
