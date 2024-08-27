using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedFeatureData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "CreatedAt", "CreatedBy", "Description", "FeatureName", "Icon", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3819), null, "Automatically processes toll payments while driving", "etc", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fetc-icon.png?alt=media&token=e2494201-b1ff-4cfa-982d-4618537ce4c5", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3820), null },
                    { new Guid("06653486-dec4-4054-ba49-c3a63490453e"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3815), null, "Covers and protects the engine compartment from external elements", "bonnet", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbonnet-icon.png?alt=media&token=a39d6283-4a5a-48a9-8c6a-8c2d539cd05b", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3815), null },
                    { new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3785), null, "Displays rear visuals to aid in reversing safely", "reverseCamera", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Freverse_camera-icon.png?alt=media&token=fff470fe-095c-4b9e-ac98-aa31827a6f91", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3785), null },
                    { new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3797), null, "Provides an open roof option for natural light and ventilation", "sunRoof", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fsunroof-icon.png?alt=media&token=88b4101d-1fec-40c0-9534-989e39d08516", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3798), null },
                    { new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3775), null, "Offers a 360-degree view around the vehicle for safer maneuvering", "camera360", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2F360_camera-icon.png?alt=media&token=12ef3912-ad25-4216-9d8a-aa3a10f3d956", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3775), null },
                    { new Guid("4481e46d-e85b-4870-a210-cdfea8932641"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3793), null, "Projects essential driving information onto the windshield", "headUp", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fhead_up-icon.png?alt=media&token=63087d56-26a4-4f72-affc-3c5d55c33f31", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3793), null },
                    { new Guid("533a7038-190b-4830-8125-5d2aacb7174e"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3772), null, "Enables wireless connection for hands-free calls and audio streaming", "bluetooth", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbluetooth-icon.png?alt=media&token=422658da-d565-46e6-9e8f-b0ffccbb77dd", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3772), null },
                    { new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3807), null, "Allows charging and connecting devices to the vehicle's system", "usbPort", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fusb-icon.png?alt=media&token=3fce192b-6d2f-43f5-8e0b-3546c1e50e31", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3807), null },
                    { new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3804), null, "Secures infants in a specially designed seat for maximum safety", "babySeat", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbabyseat-icon.png?alt=media&token=2ad93b19-7448-46f9-9029-19871a357eb6", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3805), null },
                    { new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3758), null, "Provides real-time navigation and location tracking while driving", "map", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fmap-icon.png?alt=media&token=ebf5968e-074f-4f5f-a20c-9020b5dfac7b", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3768), null },
                    { new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3809), null, "A backup tire stored in the vehicle for emergency replacements", "spareTire", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fspare_tire-icon.png?alt=media&token=01a8dc7b-e98c-479c-943c-e337e3964e8d", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3810), null },
                    { new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3800), null, "Offers satellite-based navigation and route guidance", "gps", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fgps-icon.png?alt=media&token=39ae42c8-a678-4f05-b5dd-9e20eb42d31f", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3801), null },
                    { new Guid("be392eff-ef38-4039-94ec-7922f315ea6a"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3780), null, "Records front road footage for safety and evidence during drives", "dashCamera", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fdash_camera-icon.png?alt=media&token=e863e966-7ce5-432f-9629-bd72fcdfcd1f", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3781), null },
                    { new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3778), null, "Assists in parking by displaying rearview visuals on the screen", "parkingCamera", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fparking_camera-icon.png?alt=media&token=39675fd9-2e15-4275-a7e1-085a75fb491f", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3778), null },
                    { new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3812), null, "Displays video content for rear-seat entertainment during trips", "dvdMonitor", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fdvd-icon.png?alt=media&token=49e66de4-ec15-42d5-9787-50f23ba0c074", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3813), null },
                    { new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3788), null, "Monitors tire pressure to ensure optimal driving safety", "tirePressureMonitor", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Ftpms-icon.png?alt=media&token=5d93995e-c886-430c-843b-a80fb6ba3f46", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3788), null },
                    { new Guid("f761d066-304f-49f7-b988-3aca64536d9b"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3823), null, "Deploy in collisions to protect passengers from injury", "airbags", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fairbags-icon.png?alt=media&token=55c3c49f-1b88-4782-8124-7828a6df07f8", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3823), null },
                    { new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3790), null, "Detects collisions and triggers safety mechanisms during impacts", "impactSensor", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fimpact_sensor-icon.png?alt=media&token=1bc9001d-e5ca-4f48-98f8-dc86934cebc0", new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3791), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("06653486-dec4-4054-ba49-c3a63490453e"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("4481e46d-e85b-4870-a210-cdfea8932641"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("533a7038-190b-4830-8125-5d2aacb7174e"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("be392eff-ef38-4039-94ec-7922f315ea6a"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f761d066-304f-49f7-b988-3aca64536d9b"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"));
        }
    }
}
