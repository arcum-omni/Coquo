using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coquo.Data.Migrations
{
    public partial class PantryItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PantryItem",
                columns: table => new
                {
                    ItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemNameIngredientID = table.Column<int>(nullable: false),
                    ItemDescription = table.Column<string>(nullable: true),
                    ItemVendor = table.Column<string>(nullable: true),
                    ItemQuantity = table.Column<double>(nullable: false),
                    DateReceived = table.Column<DateTime>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PantryItem", x => x.ItemID);
                    table.ForeignKey(
                        name: "FK_PantryItem_Ingredients_ItemNameIngredientID",
                        column: x => x.ItemNameIngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PantryItem_ItemNameIngredientID",
                table: "PantryItem",
                column: "ItemNameIngredientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PantryItem");
        }
    }
}
