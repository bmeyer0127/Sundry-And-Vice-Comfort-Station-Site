using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SundryAndViceComfortStationSite.Migrations
{
    /// <inheritdoc />
    public partial class FixingMenuItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_ItemIngredients_ItemIngredientMenuItemID_ItemIngredientIngredientID",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Measurements_ItemIngredients_ItemIngredientMenuItemID_ItemIngredientIngredientID",
                table: "Measurements");

            migrationBuilder.DropTable(
                name: "ItemIngredientMenuItem");

            migrationBuilder.DropIndex(
                name: "IX_Measurements_ItemIngredientMenuItemID_ItemIngredientIngredientID",
                table: "Measurements");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_ItemIngredientMenuItemID_ItemIngredientIngredientID",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ItemIngredientIngredientID",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "ItemIngredientMenuItemID",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "ItemIngredientIngredientID",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ItemIngredientMenuItemID",
                table: "Ingredients");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemIngredients_MenuItems_MenuItemID",
                table: "ItemIngredients",
                column: "MenuItemID",
                principalTable: "MenuItems",
                principalColumn: "MenuItemID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemIngredients_MenuItems_MenuItemID",
                table: "ItemIngredients");

            migrationBuilder.AddColumn<int>(
                name: "ItemIngredientIngredientID",
                table: "Measurements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemIngredientMenuItemID",
                table: "Measurements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemIngredientIngredientID",
                table: "Ingredients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemIngredientMenuItemID",
                table: "Ingredients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ItemIngredientMenuItem",
                columns: table => new
                {
                    MenuItemsMenuItemID = table.Column<int>(type: "int", nullable: false),
                    ItemIngredientsMenuItemID = table.Column<int>(type: "int", nullable: false),
                    ItemIngredientsIngredientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemIngredientMenuItem", x => new { x.MenuItemsMenuItemID, x.ItemIngredientsMenuItemID, x.ItemIngredientsIngredientID });
                    table.ForeignKey(
                        name: "FK_ItemIngredientMenuItem_ItemIngredients_ItemIngredientsMenuItemID_ItemIngredientsIngredientID",
                        columns: x => new { x.ItemIngredientsMenuItemID, x.ItemIngredientsIngredientID },
                        principalTable: "ItemIngredients",
                        principalColumns: new[] { "MenuItemID", "IngredientID" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemIngredientMenuItem_MenuItems_MenuItemsMenuItemID",
                        column: x => x.MenuItemsMenuItemID,
                        principalTable: "MenuItems",
                        principalColumn: "MenuItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_ItemIngredientMenuItemID_ItemIngredientIngredientID",
                table: "Measurements",
                columns: new[] { "ItemIngredientMenuItemID", "ItemIngredientIngredientID" });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_ItemIngredientMenuItemID_ItemIngredientIngredientID",
                table: "Ingredients",
                columns: new[] { "ItemIngredientMenuItemID", "ItemIngredientIngredientID" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemIngredientMenuItem_ItemIngredientsMenuItemID_ItemIngredientsIngredientID",
                table: "ItemIngredientMenuItem",
                columns: new[] { "ItemIngredientsMenuItemID", "ItemIngredientsIngredientID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_ItemIngredients_ItemIngredientMenuItemID_ItemIngredientIngredientID",
                table: "Ingredients",
                columns: new[] { "ItemIngredientMenuItemID", "ItemIngredientIngredientID" },
                principalTable: "ItemIngredients",
                principalColumns: new[] { "MenuItemID", "IngredientID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Measurements_ItemIngredients_ItemIngredientMenuItemID_ItemIngredientIngredientID",
                table: "Measurements",
                columns: new[] { "ItemIngredientMenuItemID", "ItemIngredientIngredientID" },
                principalTable: "ItemIngredients",
                principalColumns: new[] { "MenuItemID", "IngredientID" });
        }
    }
}
