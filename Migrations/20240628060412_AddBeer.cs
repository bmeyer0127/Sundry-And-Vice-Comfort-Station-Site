using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SundryAndViceComfortStationSite.Migrations
{
    /// <inheritdoc />
    public partial class AddBeer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "ItemTypeID", "ItemTypeDescription" },
                values: new object[] { 4, "Beer" });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemID", "CreatorName", "ItemDescription", "ItemName", "ItemTypeID" },
                values: new object[] { 8, null, "It's fine", "Draft Old Fashioned", 3 });

            migrationBuilder.InsertData(
                table: "LocationMenus",
                columns: new[] { "LocationID", "MenuItemID", "HasDairy", "HasEgg" },
                values: new object[,]
                {
                    { 1, 8, false, false },
                    { 2, 8, false, false },
                    { 3, 8, false, false }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemID", "CreatorName", "ItemDescription", "ItemName", "ItemTypeID" },
                values: new object[,]
                {
                    { 6, null, "Taste the East Coast", "Narraganset", 4 },
                    { 7, null, "I want it so bad", "PBR", 4 }
                });

            migrationBuilder.InsertData(
                table: "LocationMenus",
                columns: new[] { "LocationID", "MenuItemID", "HasDairy", "HasEgg" },
                values: new object[,]
                {
                    { 1, 6, false, false },
                    { 1, 7, false, false },
                    { 2, 6, false, false },
                    { 2, 7, false, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 4);
        }
    }
}
