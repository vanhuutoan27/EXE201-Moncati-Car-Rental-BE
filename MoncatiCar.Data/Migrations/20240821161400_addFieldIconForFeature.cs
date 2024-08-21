using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class addFieldIconForFeature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Features",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Features");
        }
    }
}
