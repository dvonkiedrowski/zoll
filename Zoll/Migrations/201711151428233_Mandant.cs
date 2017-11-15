namespace Zoll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mandant : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ZOLL", "LIEF_FIL", c => c.Int(nullable: false));
            AlterColumn("dbo.ZOLL", "MIN_STEUER_KZ", c => c.Int(nullable: false));
            AlterColumn("dbo.ZOLL", "MANDANT", c => c.Int(nullable: false));
            CreateIndex("dbo.ZOLL", "LIEF_FIL");
            CreateIndex("dbo.ZOLL", "MIN_STEUER_KZ");
            CreateIndex("dbo.ZOLL", "MANDANT");
            AddForeignKey("dbo.ZOLL", "LIEF_FIL", "dbo.FILIALE", "RECNUM", cascadeDelete: true);
            AddForeignKey("dbo.ZOLL", "MANDANT", "dbo.MANDANT", "RECNUM", cascadeDelete: true);
            AddForeignKey("dbo.ZOLL", "MIN_STEUER_KZ", "dbo.MIN_STEU", "RECNUM", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ZOLL", "MIN_STEUER_KZ", "dbo.MIN_STEU");
            DropForeignKey("dbo.ZOLL", "MANDANT", "dbo.MANDANT");
            DropForeignKey("dbo.ZOLL", "LIEF_FIL", "dbo.FILIALE");
            DropIndex("dbo.ZOLL", new[] { "MANDANT" });
            DropIndex("dbo.ZOLL", new[] { "MIN_STEUER_KZ" });
            DropIndex("dbo.ZOLL", new[] { "LIEF_FIL" });
            AlterColumn("dbo.ZOLL", "MANDANT", c => c.Short(nullable: false));
            AlterColumn("dbo.ZOLL", "MIN_STEUER_KZ", c => c.Short(nullable: false));
            AlterColumn("dbo.ZOLL", "LIEF_FIL", c => c.Short(nullable: false));
        }
    }
}
