using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SundryAndViceComfortStationSite.Migrations
{
    /// <inheritdoc />
    public partial class Removed_Gal_Hours_LocationMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "HoursOpens");

            migrationBuilder.DropTable(
                name: "LocationMenus");

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "MenuItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "MenuItemID",
                table: "Locations",
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
                name: "IX_MenuItems_ItemTypeID",
                table: "MenuItems",
                column: "ItemTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_LocationID",
                table: "MenuItems",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_ItemIngredientMenuItemID_ItemIngredientIngredientID",
                table: "Measurements",
                columns: new[] { "ItemIngredientMenuItemID", "ItemIngredientIngredientID" });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_MenuItemID",
                table: "Locations",
                column: "MenuItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemIngredients_IngredientID",
                table: "ItemIngredients",
                column: "IngredientID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemIngredients_MeasurementID",
                table: "ItemIngredients",
                column: "MeasurementID");

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
                name: "FK_ItemIngredients_Ingredients_IngredientID",
                table: "ItemIngredients",
                column: "IngredientID",
                principalTable: "Ingredients",
                principalColumn: "IngredientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemIngredients_Measurements_MeasurementID",
                table: "ItemIngredients",
                column: "MeasurementID",
                principalTable: "Measurements",
                principalColumn: "MeasurementID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_MenuItems_MenuItemID",
                table: "Locations",
                column: "MenuItemID",
                principalTable: "MenuItems",
                principalColumn: "MenuItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Measurements_ItemIngredients_ItemIngredientMenuItemID_ItemIngredientIngredientID",
                table: "Measurements",
                columns: new[] { "ItemIngredientMenuItemID", "ItemIngredientIngredientID" },
                principalTable: "ItemIngredients",
                principalColumns: new[] { "MenuItemID", "IngredientID" });

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_ItemTypes_ItemTypeID",
                table: "MenuItems",
                column: "ItemTypeID",
                principalTable: "ItemTypes",
                principalColumn: "ItemTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_Locations_LocationID",
                table: "MenuItems",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_ItemIngredients_ItemIngredientMenuItemID_ItemIngredientIngredientID",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemIngredients_Ingredients_IngredientID",
                table: "ItemIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemIngredients_Measurements_MeasurementID",
                table: "ItemIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_MenuItems_MenuItemID",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Measurements_ItemIngredients_ItemIngredientMenuItemID_ItemIngredientIngredientID",
                table: "Measurements");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_ItemTypes_ItemTypeID",
                table: "MenuItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_Locations_LocationID",
                table: "MenuItems");

            migrationBuilder.DropTable(
                name: "ItemIngredientMenuItem");

            migrationBuilder.DropIndex(
                name: "IX_MenuItems_ItemTypeID",
                table: "MenuItems");

            migrationBuilder.DropIndex(
                name: "IX_MenuItems_LocationID",
                table: "MenuItems");

            migrationBuilder.DropIndex(
                name: "IX_Measurements_ItemIngredientMenuItemID_ItemIngredientIngredientID",
                table: "Measurements");

            migrationBuilder.DropIndex(
                name: "IX_Locations_MenuItemID",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_ItemIngredients_IngredientID",
                table: "ItemIngredients");

            migrationBuilder.DropIndex(
                name: "IX_ItemIngredients_MeasurementID",
                table: "ItemIngredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_ItemIngredientMenuItemID_ItemIngredientIngredientID",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "ItemIngredientIngredientID",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "ItemIngredientMenuItemID",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "MenuItemID",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "ItemIngredientIngredientID",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ItemIngredientMenuItemID",
                table: "Ingredients");

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    PathToPicture = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PictureDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => new { x.LocationID, x.PathToPicture });
                });

            migrationBuilder.CreateTable(
                name: "HoursOpens",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    DayOfWeek = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CloseTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OpenTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoursOpens", x => new { x.LocationID, x.DayOfWeek });
                });

            migrationBuilder.CreateTable(
                name: "LocationMenus",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    MenuItemID = table.Column<int>(type: "int", nullable: false),
                    HasDairy = table.Column<bool>(type: "bit", nullable: false),
                    HasEgg = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationMenus", x => new { x.LocationID, x.MenuItemID });
                });
        }
    }
}
