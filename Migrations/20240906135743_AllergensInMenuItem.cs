using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SundryAndViceComfortStationSite.Migrations
{
    /// <inheritdoc />
    public partial class AllergensInMenuItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasDairy",
                table: "LocationMenus");

            migrationBuilder.DropColumn(
                name: "HasEgg",
                table: "LocationMenus");

            migrationBuilder.AddColumn<bool>(
                name: "HasDairy",
                table: "MenuItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasEgg",
                table: "MenuItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 1,
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 2,
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 3,
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 4,
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 5,
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 6,
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 7,
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 8,
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 9,
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemID",
                keyValue: 10,
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasDairy",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "HasEgg",
                table: "MenuItems");

            migrationBuilder.AddColumn<bool>(
                name: "HasDairy",
                table: "LocationMenus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasEgg",
                table: "LocationMenus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 7 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 8 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 9 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 1, 10 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 6 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 7 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 8 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 9 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 2, 10 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 4 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 5 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 8 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 9 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "LocationMenus",
                keyColumns: new[] { "LocationID", "MenuItemID" },
                keyValues: new object[] { 3, 10 },
                columns: new[] { "HasDairy", "HasEgg" },
                values: new object[] { false, false });
        }
    }
}
