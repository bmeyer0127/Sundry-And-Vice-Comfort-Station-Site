using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SundryAndViceComfortStationSite.Migrations
{
    /// <inheritdoc />
    public partial class AddLocationMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_MenuItems_MenuItemID",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_Locations_LocationID",
                table: "MenuItems");

            migrationBuilder.DropIndex(
                name: "IX_MenuItems_LocationID",
                table: "MenuItems");

            migrationBuilder.DropIndex(
                name: "IX_Locations_MenuItemID",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "MenuItemID",
                table: "Locations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "MenuItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MenuItemID",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_LocationID",
                table: "MenuItems",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_MenuItemID",
                table: "Locations",
                column: "MenuItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_MenuItems_MenuItemID",
                table: "Locations",
                column: "MenuItemID",
                principalTable: "MenuItems",
                principalColumn: "MenuItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_Locations_LocationID",
                table: "MenuItems",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
