namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuestionnaireTransactions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questionnaires",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        LastBalanced = c.String(),
                        FinalRegisterBalance = c.String(),
                        FinalRegisterDate = c.String(),
                        ErrorCorrection = c.String(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Orders", t => t.OrderID)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Check = c.String(),
                        Date = c.String(),
                        Deposit = c.String(),
                        OrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.OrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Questionnaires", "OrderID", "dbo.Orders");
            DropIndex("dbo.Transactions", new[] { "OrderID" });
            DropIndex("dbo.Questionnaires", new[] { "OrderID" });
            DropTable("dbo.Transactions");
            DropTable("dbo.Questionnaires");
        }
    }
}
