using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNullAbleForCarId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarFeatures_Cars_CarId",
                table: "CarFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_CarFeatures_Features_FeatureId",
                table: "CarFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Cars_CarId",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Features",
                newName: "FeatureName");

            migrationBuilder.AlterColumn<Guid>(
                name: "CarId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "FeatureId",
                table: "CarFeatures",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CarId",
                table: "CarFeatures",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeatures_Cars_CarId",
                table: "CarFeatures",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeatures_Features_FeatureId",
                table: "CarFeatures",
                column: "FeatureId",
                principalTable: "Features",
                principalColumn: "FeatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Cars_CarId",
                table: "Images",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarFeatures_Cars_CarId",
                table: "CarFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_CarFeatures_Features_FeatureId",
                table: "CarFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Cars_CarId",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "FeatureName",
                table: "Features",
                newName: "Name");

            migrationBuilder.AlterColumn<Guid>(
                name: "CarId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FeatureId",
                table: "CarFeatures",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CarId",
                table: "CarFeatures",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeatures_Cars_CarId",
                table: "CarFeatures",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeatures_Features_FeatureId",
                table: "CarFeatures",
                column: "FeatureId",
                principalTable: "Features",
                principalColumn: "FeatureId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Cars_CarId",
                table: "Images",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
