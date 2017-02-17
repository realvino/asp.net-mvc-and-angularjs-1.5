namespace AdminLTE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addtabless : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Phno", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Phno");
        }
    }
}
