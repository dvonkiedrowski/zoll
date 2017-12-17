namespace Zoll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mandant : DbMigration
    {
        public override void Up()
        {
            
            AddForeignKey("dbo.ZOLLEIN", "LIEF_FIL", "dbo.FILIALE", "RECNUM", cascadeDelete: true);
            
            AddForeignKey("dbo.ZOLLEIN", "MIN_STEUER_KZ", "dbo.MIN_STEU", "RECNUM", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ZOLLEIN", "MIN_STEUER_KZ", "dbo.MIN_STEU");
            
            DropForeignKey("dbo.ZOLLEIN", "LIEF_FIL", "dbo.FILIALE");
            
        }
    }
}
