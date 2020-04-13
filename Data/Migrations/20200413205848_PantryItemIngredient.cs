using Microsoft.EntityFrameworkCore.Migrations;

namespace Coquo.Data.Migrations
{
    public partial class PantryItemIngredient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PantryItem_Ingredients_ItemNameIngredientID",
                table: "PantryItem");

            migrationBuilder.DropIndex(
                name: "IX_PantryItem_ItemNameIngredientID",
                table: "PantryItem");

            migrationBuilder.DropColumn(
                name: "ItemNameIngredientID",
                table: "PantryItem");

            migrationBuilder.AddColumn<int>(
                name: "ItemIngredientID",
                table: "PantryItem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PantryItem_ItemIngredientID",
                table: "PantryItem",
                column: "ItemIngredientID");

            migrationBuilder.AddForeignKey(
                name: "FK_PantryItem_Ingredients_ItemIngredientID",
                table: "PantryItem",
                column: "ItemIngredientID",
                principalTable: "Ingredients",
                principalColumn: "IngredientID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PantryItem_Ingredients_ItemIngredientID",
                table: "PantryItem");

            migrationBuilder.DropIndex(
                name: "IX_PantryItem_ItemIngredientID",
                table: "PantryItem");

            migrationBuilder.DropColumn(
                name: "ItemIngredientID",
                table: "PantryItem");

            migrationBuilder.AddColumn<int>(
                name: "ItemNameIngredientID",
                table: "PantryItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PantryItem_ItemNameIngredientID",
                table: "PantryItem",
                column: "ItemNameIngredientID");

            migrationBuilder.AddForeignKey(
                name: "FK_PantryItem_Ingredients_ItemNameIngredientID",
                table: "PantryItem",
                column: "ItemNameIngredientID",
                principalTable: "Ingredients",
                principalColumn: "IngredientID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
