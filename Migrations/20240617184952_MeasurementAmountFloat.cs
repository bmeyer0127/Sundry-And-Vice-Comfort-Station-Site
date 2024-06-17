using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SundryAndViceComfortStationSite.Migrations
{
    /// <inheritdoc />
    public partial class MeasurementAmountFloat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "MeasurementAmount",
                table: "ItemIngredients",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MeasurementAmount",
                table: "ItemIngredients",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
