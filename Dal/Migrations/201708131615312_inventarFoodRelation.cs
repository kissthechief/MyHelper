namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inventarFoodRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("LHELP.Inventar", "Food_Id", "LHELP.Food");
            DropIndex("LHELP.Inventar", new[] { "Food_Id" });
            CreateTable(
                "dbo.FoodInventars",
                c => new
                    {
                        Food_Id = c.Int(nullable: false),
                        Inventar_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Food_Id, t.Inventar_Id })
                .ForeignKey("LHELP.Food", t => t.Food_Id, cascadeDelete: true)
                .ForeignKey("LHELP.Inventar", t => t.Inventar_Id, cascadeDelete: true)
                .Index(t => t.Food_Id)
                .Index(t => t.Inventar_Id);
            
            DropColumn("LHELP.Inventar", "Food_Id");
        }
        
        public override void Down()
        {
            AddColumn("LHELP.Inventar", "Food_Id", c => c.Int());
            DropForeignKey("dbo.FoodInventars", "Inventar_Id", "LHELP.Inventar");
            DropForeignKey("dbo.FoodInventars", "Food_Id", "LHELP.Food");
            DropIndex("dbo.FoodInventars", new[] { "Inventar_Id" });
            DropIndex("dbo.FoodInventars", new[] { "Food_Id" });
            DropTable("dbo.FoodInventars");
            CreateIndex("LHELP.Inventar", "Food_Id");
            AddForeignKey("LHELP.Inventar", "Food_Id", "LHELP.Food", "Id");
        }
    }
}
