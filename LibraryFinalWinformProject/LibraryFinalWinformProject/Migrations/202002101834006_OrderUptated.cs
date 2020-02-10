namespace LibraryFinalWinformProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderUptated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "BookId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "overdueDebt", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            CreateIndex("dbo.Orders", "BookId");
            AddForeignKey("dbo.Orders", "BookId", "dbo.Books", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "BookId", "dbo.Books");
            DropIndex("dbo.Orders", new[] { "BookId" });
            DropColumn("dbo.Orders", "overdueDebt");
            DropColumn("dbo.Orders", "BookId");
        }
    }
}
