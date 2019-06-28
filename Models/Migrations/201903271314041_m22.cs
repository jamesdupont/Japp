namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M22 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ItemRepairs", "ItemType", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ItemRepairs", "ItemType", c => c.String());
        }
    }
}
