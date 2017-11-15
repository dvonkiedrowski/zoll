namespace Zoll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBEZEICHNUNGToBEZ : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.MIN_STEU", "BEZEICHNUNG", "BEZ");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.MIN_STEU", "BEZ", "BEZEICHNUNG");
        }
    }
}
