using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateFeatureNam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Users",
                newName: "Status");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Users",
                newName: "IsActive");
        }
    }
}
