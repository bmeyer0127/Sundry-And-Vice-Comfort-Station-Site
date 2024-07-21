using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SundryAndViceComfortStationSite.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientID", "IngredientName" },
                values: new object[,]
                {
                    { 1, "Lemon Juice" },
                    { 2, "Lime Juice" },
                    { 3, "Pineapple Juice" },
                    { 4, "Grapefruit Juice" },
                    { 5, "Orange Juice" },
                    { 6, "Simple Syrup" },
                    { 7, "Honey Syrup" },
                    { 8, "Ginger Syrup" },
                    { 9, "Demerara Syrup" },
                    { 10, "Passionfruit Liqueur" },
                    { 11, "Vodka (Non-Specific)" },
                    { 12, "Gin (Non-Specific)" },
                    { 13, "Rum (Non-Specific)" },
                    { 14, "Tequila (Non-Specific)" },
                    { 15, "Bourbon (Non-Specific)" },
                    { 16, "Rye (Non-Specific)" },
                    { 17, "Scotch (Non-Specific)" },
                    { 18, "New Riff Kentucky Wild Gin" },
                    { 19, "Angostura Bitters" },
                    { 20, "Orange Bitters" },
                    { 21, "Peychaud's Bitters" },
                    { 22, "Serrano Pepper" },
                    { 23, "Fresh Mint" },
                    { 24, "Grapefruit Peel" },
                    { 25, "Saline" }
                });

            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "ItemTypeID", "ItemTypeDescription" },
                values: new object[,]
                {
                    { 1, "Classic" },
                    { 2, "House" },
                    { 3, "Draft" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "LocationAddress", "LocationName" },
                values: new object[,]
                {
                    { 1, "850 Massachusetts Ave, Indianapolis, IN 46204", "Sundry and Vice - Indy" },
                    { 2, "18 W 13th St, Cincinnati, OH 45202", "Sundry and Vice - Cincy" },
                    { 3, "793 E McMillan St, Cincinnati, OH 45206", "Comfort Station - Cincy" }
                });

            migrationBuilder.InsertData(
                table: "Measurements",
                columns: new[] { "MeasurementID", "MeasurementDescription" },
                values: new object[,]
                {
                    { 1, "oz" },
                    { 2, "ml" },
                    { 3, "dash(es)" },
                    { 4, "leaf/leaves" },
                    { 5, "peel(s)" },
                    { 6, "slice(s)" }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemID", "CreatorName", "ItemDescription", "ItemName", "ItemTypeID" },
                values: new object[,]
                {
                    { 1, null, "Curing", "Night Cure", 2 },
                    { 2, null, "Refreshing", "Gimlet", 1 },
                    { 3, "Brett", "Sweet and evil", "Persephone's Papercut", 2 },
                    { 4, null, "You know", "Whiskey Sour", 1 },
                    { 5, null, "You need one", "Daiquiri", 1 }
                });

            migrationBuilder.InsertData(
                table: "ItemIngredients",
                columns: new[] { "IngredientID", "MenuItemID", "MeasurementAmount", "MeasurementID" },
                values: new object[,]
                {
                    { 1, 1, 0.75f, 1 },
                    { 7, 1, 0.75f, 1 },
                    { 15, 1, 2f, 1 },
                    { 24, 1, 1f, 5 },
                    { 2, 2, 1f, 1 },
                    { 6, 2, 0.75f, 1 },
                    { 12, 2, 2f, 1 },
                    { 1, 3, 0.75f, 1 },
                    { 7, 3, 0.25f, 1 },
                    { 10, 3, 0.5f, 1 },
                    { 18, 3, 1.5f, 1 },
                    { 22, 3, 1f, 6 },
                    { 23, 3, 6f, 4 },
                    { 1, 4, 0.75f, 1 },
                    { 6, 4, 0.75f, 1 },
                    { 15, 4, 2f, 1 },
                    { 2, 5, 1f, 1 },
                    { 6, 5, 0.75f, 1 },
                    { 13, 5, 2f, 1 },
                    { 25, 5, 1f, 3 }
                });

            migrationBuilder.InsertData(
                table: "LocationMenus",
                columns: new[] { "LocationID", "MenuItemID", "HasDairy", "HasEgg" },
                values: new object[,]
                {
                    { 1, 1, false, false },
                    { 1, 2, false, false },
                    { 1, 3, false, false },
                    { 1, 5, false, false },
                    { 2, 1, false, false },
                    { 2, 2, false, false },
                    { 2, 5, false, false },
                    { 3, 2, false, false },
                    { 3, 4, false, false },
                    { 3, 5, false, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 22, 3 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 23, 3 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "ItemIngredients",
                keyColumns: new[] { "IngredientID", "MenuItemID" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "MeasurementID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "MeasurementID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "MeasurementID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "MeasurementID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "MeasurementID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "MeasurementID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 2);
        }
    }
}
