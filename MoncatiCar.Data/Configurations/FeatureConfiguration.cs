using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MocatiCar.Core.Domain.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoncatiCar.Data.Configurations
{
    public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
    {
        public void Configure(EntityTypeBuilder<Feature> builder)
        {
            builder.HasData(new List<Feature>() {
                new Feature
                {
                    FeatureId = Guid.Parse("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                    FeatureName = "map",
                    DisplayName = "Map",
                    Description = "Provides real-time navigation and location tracking while driving",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fmap-icon.png?alt=media&token=ebf5968e-074f-4f5f-a20c-9020b5dfac7b",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("533a7038-190b-4830-8125-5d2aacb7174e"),
                    FeatureName = "bluetooth",
                    DisplayName = "Bluetooth",
                    Description = "Enables wireless connection for hands-free calls and audio streaming",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbluetooth-icon.png?alt=media&token=422658da-d565-46e6-9e8f-b0ffccbb77dd",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"),
                    FeatureName = "camera360",
                    DisplayName = "Camera 360",
                    Description = "Offers a 360-degree view around the vehicle for safer maneuvering",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2F360_camera-icon.png?alt=media&token=12ef3912-ad25-4216-9d8a-aa3a10f3d956",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"),
                    FeatureName = "parkingCamera",
                    DisplayName = "Parking Camera",
                    Description = "Assists in parking by displaying rearview visuals on the screen",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fparking_camera-icon.png?alt=media&token=39675fd9-2e15-4275-a7e1-085a75fb491f",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("be392eff-ef38-4039-94ec-7922f315ea6a"),
                    FeatureName = "dashCamera",
                    DisplayName = "Dash Camera",
                    Description = "Records front road footage for safety and evidence during drives",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fdash_camera-icon.png?alt=media&token=e863e966-7ce5-432f-9629-bd72fcdfcd1f",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"),
                    FeatureName = "reverseCamera",
                    DisplayName = "Reverse Camera",
                    Description = "Displays rear visuals to aid in reversing safely",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Freverse_camera-icon.png?alt=media&token=fff470fe-095c-4b9e-ac98-aa31827a6f91",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("e285ec6a-3119-43b5-8edb-209fa732a77d"),
                    FeatureName = "tirePressureMonitor",
                    DisplayName = "Tire Pressure Monitor",
                    Description = "Monitors tire pressure to ensure optimal driving safety",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Ftpms-icon.png?alt=media&token=5d93995e-c886-430c-843b-a80fb6ba3f46",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"),
                    FeatureName = "impactSensor",
                    DisplayName = "Impact Sensor",
                    Description = "Detects collisions and triggers safety mechanisms during impacts",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fimpact_sensor-icon.png?alt=media&token=1bc9001d-e5ca-4f48-98f8-dc86934cebc0",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("4481e46d-e85b-4870-a210-cdfea8932641"),
                    FeatureName = "headUp",
                    DisplayName = "Head Up",
                    Description = "Projects essential driving information onto the windshield",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fhead_up-icon.png?alt=media&token=63087d56-26a4-4f72-affc-3c5d55c33f31",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                    FeatureName = "sunRoof",
                    DisplayName = "Sun Roof",
                    Description = "Provides an open roof option for natural light and ventilation",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fsunroof-icon.png?alt=media&token=88b4101d-1fec-40c0-9534-989e39d08516",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"),
                    FeatureName = "gps",
                    DisplayName = "GPS",
                    Description = "Offers satellite-based navigation and route guidance",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fgps-icon.png?alt=media&token=39ae42c8-a678-4f05-b5dd-9e20eb42d31f",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("6ebf1d36-35fa-4cad-9d6f-671476d02020"),
                    FeatureName = "babySeat",
                    DisplayName = "Baby Seat",
                    Description = "Secures infants in a specially designed seat for maximum safety",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbabyseat-icon.png?alt=media&token=2ad93b19-7448-46f9-9029-19871a357eb6",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                    FeatureName = "usbPort",
                    DisplayName = "USB Port",
                    Description = "Allows charging and connecting devices to the vehicle's system",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fusb-icon.png?alt=media&token=3fce192b-6d2f-43f5-8e0b-3546c1e50e31",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("905d9d8f-7b09-4536-82d1-d15b938b2dac"),
                    FeatureName = "spareTire",
                    DisplayName = "Spare Tire",
                    Description = "A backup tire stored in the vehicle for emergency replacements",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fspare_tire-icon.png?alt=media&token=01a8dc7b-e98c-479c-943c-e337e3964e8d",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                    FeatureName = "dvdMonitor",
                    DisplayName = "DVD Monitor",
                    Description = "Displays video content for rear-seat entertainment during trips",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fdvd-icon.png?alt=media&token=49e66de4-ec15-42d5-9787-50f23ba0c074",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("06653486-dec4-4054-ba49-c3a63490453e"),
                    FeatureName = "bonnet",
                    DisplayName = "Bonnet",
                    Description = "Covers and protects the engine compartment from external elements",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbonnet-icon.png?alt=media&token=a39d6283-4a5a-48a9-8c6a-8c2d539cd05b",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                    FeatureName = "etc",
                    DisplayName = "Etc",
                    Description = "Automatically processes toll payments while driving",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fetc-icon.png?alt=media&token=e2494201-b1ff-4cfa-982d-4618537ce4c5",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Feature
                {
                    FeatureId = Guid.Parse("f761d066-304f-49f7-b988-3aca64536d9b"),
                    FeatureName = "airbags",
                    DisplayName = "Air bags",
                    Description = "Deploy in collisions to protect passengers from injury",
                    Icon = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fairbags-icon.png?alt=media&token=55c3c49f-1b88-4782-8124-7828a6df07f8",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
            });
        }
    }
}
