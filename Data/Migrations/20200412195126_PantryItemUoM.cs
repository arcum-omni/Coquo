using Microsoft.EntityFrameworkCore.Migrations;

namespace Coquo.Data.Migrations
{
    public partial class PantryItemUoM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemUnitOfMeasure",
                table: "PantryItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemUnitOfMeasure",
                table: "PantryItem");
        }
    }
}
