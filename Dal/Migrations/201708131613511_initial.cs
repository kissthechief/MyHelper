namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
        //    DropForeignKey("dbo.UserInventars", "User_Id", "LHELP.User");
        //    DropForeignKey("dbo.UserInventars", "Inventar_Id", "LHELP.Inventar");
        //    DropForeignKey("dbo.FoodInventars", "Food_Id", "LHELP.Food");
        //    DropForeignKey("dbo.FoodInventars", "Inventar_Id", "LHELP.Inventar");
        //    DropIndex("dbo.UserInventars", new[] { "User_Id" });
        //    DropIndex("dbo.UserInventars", new[] { "Inventar_Id" });
        //    DropIndex("dbo.FoodInventars", new[] { "Food_Id" });
        //    DropIndex("dbo.FoodInventars", new[] { "Inventar_Id" });
        //    CreateIndex("LHELP.Inventar", "Food_Id");
        //    CreateIndex("LHELP.Inventar", "User_Id");
        //    AddForeignKey("LHELP.Inventar", "User_Id", "LHELP.User", "Id");
        //    AddForeignKey("LHELP.Inventar", "Food_Id", "LHELP.Food", "Id");
        //    DropTable("dbo.UserInventars");
        //    DropTable("dbo.FoodInventars");
        }
        
        public override void Down()
        {
            //CreateTable(
            //    "dbo.FoodInventars",
            //    c => new
            //        {
            //            Food_Id = c.Int(nullable: false),
            //            Inventar_Id = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.Food_Id, t.Inventar_Id });
            
            //CreateTable(
            //    "dbo.UserInventars",
            //    c => new
            //        {
            //            User_Id = c.Int(nullable: false),
            //            Inventar_Id = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.User_Id, t.Inventar_Id });
            
            //DropForeignKey("LHELP.Inventar", "Food_Id", "LHELP.Food");
            //DropForeignKey("LHELP.Inventar", "User_Id", "LHELP.User");
            //DropIndex("LHELP.Inventar", new[] { "User_Id" });
            //DropIndex("LHELP.Inventar", new[] { "Food_Id" });
            //CreateIndex("dbo.FoodInventars", "Inventar_Id");
            //CreateIndex("dbo.FoodInventars", "Food_Id");
            //CreateIndex("dbo.UserInventars", "Inventar_Id");
            //CreateIndex("dbo.UserInventars", "User_Id");
            //AddForeignKey("dbo.FoodInventars", "Inventar_Id", "LHELP.Inventar", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.FoodInventars", "Food_Id", "LHELP.Food", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.UserInventars", "Inventar_Id", "LHELP.Inventar", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.UserInventars", "User_Id", "LHELP.User", "Id", cascadeDelete: true);
        }
    }
}
