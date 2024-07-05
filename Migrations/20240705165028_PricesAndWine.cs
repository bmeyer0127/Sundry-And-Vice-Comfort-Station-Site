using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SundryAndViceComfortStationSite.Migrations
{
    /// <inheritdoc />
    public partial class PricesAndWine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "LocationMenus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "ItemTypeID", "ItemTypeDescription" },
                values: new object[] { 5, "Wine" });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 1 },
                column: "Price",
                value: 14);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 2 },
                column: "Price",
                value: 15);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 3 },
                column: "Price",
                value: 12);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 5 },
                column: "Price",
                value: 6);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 6 },
                column: "Price",
                value: 5);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 7 },
                column: "Price",
                value: 6);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 8 },
                column: "Price",
                value: 4);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 1 },
                column: "Price",
                value: 13);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 2 },
                column: "Price",
                value: 16);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 5 },
                column: "Price",
                value: 7);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 6 },
                column: "Price",
                value: 5);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 7 },
                column: "Price",
                value: 6);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 8 },
                column: "Price",
                value: 7);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 2 },
                column: "Price",
                value: 15);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 4 },
                column: "Price",
                value: 16);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 5 },
                column: "Price",
                value: 12);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 8 },
                column: "Price",
                value: 4);

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemID", "CreatorName", "ItemDescription", "ItemName", "ItemTypeID" },
                values: new object[,]
                {
                    { 9, null, "Dry and fine", "Cabernet", 5 },
                    { 10, null, "Extremely mid", "Chenin Blanc", 5 }
                });

            migrationBuilder.InsertData(
                table: "LocationMenus",
                columns: new[] { "LocationID", "MenuItemID", "HasDairy", "HasEgg", "Price" },
                values: new object[,]
                {
                    { 1, 9, false, false, 12 },
                    { 1, 10, false, false, 11 },
                    { 2, 9, false, false, 12 },
                    { 2, 10, false, false, 11 },
                    { 3, 9, false, false, 12 },
                    { 3, 10, false, false, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Price",
                table: "LocationMenus");
        }
    }
}
