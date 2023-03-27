namespace D04_EF6_Migrations_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M02Book_UpField_DDC : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Book", "DDC", c => c.String(nullable: false, maxLength: 9));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Book", "DDC");
        }
    }
}
