using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class DbInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "FuelConsumption",
                table: "Cars",
                type: "real",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<float>(
                name: "discount",
                table: "Cars",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "year",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "discount",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "year",
                table: "Cars");

            migrationBuilder.AlterColumn<string>(
                name: "FuelConsumption",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }
    }
}
