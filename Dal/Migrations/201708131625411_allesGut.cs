namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allesGut : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.FoodInventars", newSchema: "LHELP");
            RenameColumn(table: "LHELP.FoodInventars", name: "Food_Id", newName: "InventarId");
            RenameColumn(table: "LHELP.FoodInventars", name: "Inventar_Id", newName: "FoodId");
            RenameIndex(table: "LHELP.FoodInventars", name: "IX_Food_Id", newName: "IX_InventarId");
            RenameIndex(table: "LHELP.FoodInventars", name: "IX_Inventar_Id", newName: "IX_FoodId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "LHELP.FoodInventars", name: "IX_FoodId", newName: "IX_Inventar_Id");
            RenameIndex(table: "LHELP.FoodInventars", name: "IX_InventarId", newName: "IX_Food_Id");
            RenameColumn(table: "LHELP.FoodInventars", name: "FoodId", newName: "Inventar_Id");
            RenameColumn(table: "LHELP.FoodInventars", name: "InventarId", newName: "Food_Id");
            MoveTable(name: "LHELP.FoodInventars", newSchema: "dbo");
        }
    }
}
