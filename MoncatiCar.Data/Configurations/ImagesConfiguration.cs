using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MocatiCar.Core.Domain.Content;

namespace MoncatiCar.Data.Configurations
{
    public class ImagesConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new List<Image>()
            {
                 new Image
                 {
                     ImageId = Guid.Parse("0831C830-8AB9-41EE-8ABE-AEEA4F832715"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar11.jpg?alt=media&token=41cf30ec-f792-4074-9406-a5d2a98a49e6",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635")
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("16931F6D-B074-4BD2-9082-3DE35B6DB9D5"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar12.jpg?alt=media&token=c1f10fdd-cb99-4c27-933d-4700acc9272e",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635")
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("E33DFAFE-CF13-43BA-93BC-9B150831123E"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar13.jpg?alt=media&token=2782d4ec-0184-47a7-8964-148e4c6928ae",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635")
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("27E79248-04E4-4961-A0B1-CF22C2319AE4"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar14.jpg?alt=media&token=6ce903bb-ce8b-4c6d-bc34-d8a1b664f625",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635")
                 },

                 //car 2
                 new Image
                 {
                     ImageId = Guid.Parse("BF8A664F-88FE-4E7C-B91C-427DD10970C2"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar21.jpg?alt=media&token=735db85a-0e4f-4645-a764-1657d1ccf7d0",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259")
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("4D4C2964-6453-4522-923E-1688DA305391"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar22.jpg?alt=media&token=745493d0-4f34-4c7f-bb8c-f8c891e01422",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259")
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("91762BD8-9200-4D45-9EE8-E8F0E983E921"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar23.jpg?alt=media&token=fd7110ec-aa36-4610-a69d-b00abdf886ec",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259")
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("5F11BA97-BDE5-4400-B6DD-B4E02025A0D7"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar24.jpg?alt=media&token=263ace26-9d00-41d4-869c-760319e406dd",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259")
                 },

                 //car 3
                 new Image
                 {
                     ImageId = Guid.Parse("119D2E54-A9C0-4B7C-87D6-5CD2F2501DA9"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar31.jpg?alt=media&token=6c0188d7-d743-4e0b-9795-a0ceeae64dba",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("24971C14-5F2F-41AA-886B-1C114186D3BC"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar32.jpg?alt=media&token=9a497c45-8b33-40ae-bf8a-86b29747324b",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("782D4C8E-2605-4A2D-87BA-3D1F2C9EB4D6"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar33.jpg?alt=media&token=557246dd-3d64-45a5-97fa-9b122cd316c9",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("DAD87D5E-C756-4EE5-AE27-C3F84901C9D3"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar34.jpg?alt=media&token=d7874dde-8f83-4d86-a902-04ce22c9942c",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                 },

                 ///car 4
                 new Image
                 {
                     ImageId = Guid.Parse("2263A83A-5199-4240-9ECB-B19701D1FCF5"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar41.jpg?alt=media&token=e8d9380a-0931-4215-a080-96204098774d",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("8705F403-06BC-4983-8C81-86310959CC37"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("6EBFAF1C-748F-484A-B8B7-B7DDAC7C883D"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar42.jpg?alt=media&token=78c1211b-d7a7-45ed-a03a-09a442c2b529",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("8705F403-06BC-4983-8C81-86310959CC37"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("D898F1D5-CF63-4250-A8F7-C8CF25C61A46"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar43.jpg?alt=media&token=b994c70b-b366-44dc-bcbe-d4c6219ba189",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("8705F403-06BC-4983-8C81-86310959CC37"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("38E6DB85-3E32-4077-804C-F2287D118FD0"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar44.jpg?alt=media&token=e55eeb29-93b0-47b3-911f-df204e877469",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("8705F403-06BC-4983-8C81-86310959CC37"),
                 },

                 ///Car 5 
                 new Image
                 {
                     ImageId = Guid.Parse("03071DDF-22C3-4321-9CFC-4C1DD506A9A3"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar51.jpg?alt=media&token=6e55f0be-c666-4c50-a30e-44b4a703260d",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("589B7E11-94C3-4C5B-B4CB-2B3D215BE33B"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar52.jpg?alt=media&token=ad7a0fd8-b4eb-4326-a475-342a9e0b01b8",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("82428E6A-19F6-4599-AAE1-13712934B3F8"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar53.jpg?alt=media&token=c76e6223-2ca1-4bac-bd7b-dd3f18323f37",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("155E7784-A812-4571-BEAD-F8D7CA2478B5"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar54.jpg?alt=media&token=ed8a9204-288e-44f8-b047-ba4a80d5a45e",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                 },

                 //car 6
                 new Image
                 {
                     ImageId = Guid.Parse("13AECFDA-8E98-4C0E-ABC0-E20F1D13E961"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar61.jpg?alt=media&token=fab2b814-962d-4098-839c-758fb97642e5",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("C5DE75B4-9631-43C0-8AC6-A9DA568A967A"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar62.jpg?alt=media&token=159d9f2e-fad1-4846-876d-3c4b9fa1e720",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("BFBBAA76-998F-4D46-BBFE-664BE8C4F6A5"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar63.jpg?alt=media&token=34a62380-de76-46c7-9752-9b13e8cc7ac5",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("90FE95A8-3617-4676-ABFA-9F86ED314BBB"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar64.jpg?alt=media&token=9a4b198d-c2c4-4585-b424-fd2b326fc97c",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("FDF80856-DA90-4190-BF4E-66ED0601A4BA"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar65.jpg?alt=media&token=8761aa35-f030-4fa7-a020-66f0a6810090",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("643C0C50-B89E-4D60-B339-28254D008738"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar66.jpg?alt=media&token=d3102c30-035b-47cd-a8f8-f66be7a24f6f",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),

                 },
                 new Image
                 {
                     ImageId = Guid.Parse("146A6452-4BC4-4922-BB33-A69D1D0612DD"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar67.jpg?alt=media&token=63ef5ae3-3d82-4e38-8412-aaa93f6785b6",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                 },

                 //car 7
                 new Image
                 {
                     ImageId = Guid.Parse("53337DAF-C5AF-452F-802A-D8B829A9D068"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar71.jpg?alt=media&token=f67cdcdb-55a4-46da-bcab-a498b8eea245",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("E746AF29-8CFB-4F2A-B1D8-593F44E0ACD7"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar72.jpg?alt=media&token=30a3ac2a-0797-4240-b65e-8a3ceb63a839",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("DE16B5E0-65E8-45D1-AE2C-A446FEBB4B0D"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar73.jpg?alt=media&token=1750f1a1-62c5-4ab9-87ad-89301f4bc9b2",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("6C521908-21FF-4E8D-A8D0-4C05C8A2E5A7"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar74.jpg?alt=media&token=95622732-d623-4eda-aa62-6c8ee1e96f28",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                 },
                 //car 8
                
                 new Image
                 {
                     ImageId = Guid.Parse("113D7987-DEA8-4093-8B09-3EE0DE72BB3C"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar81.jpg?alt=media&token=22679c70-85f4-4b86-8934-fb1d2a60b1b9",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("23FBF12E-52D0-4438-A9FE-F681D12B89FA"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar82.jpg?alt=media&token=de9c9bc7-c8e8-4969-b680-11fd990fe8a2",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("1DF708B5-2560-4664-89D6-6EE1E3B88D26"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar83.jpg?alt=media&token=127dc8ca-bcdb-42a1-9e7c-44e35ca985c8",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("61C40521-3A6F-4A6A-816D-8C2A7F449997"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar84.jpg?alt=media&token=0c49d25b-e1c5-4b31-b5eb-a313baa44b5e",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("BFBF38C4-5645-4392-9020-6C5B992FF46E"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar85.jpg?alt=media&token=8ab32d35-6b26-4fb7-8a5a-4e013161a768",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                 },

                 //car 9
                 new Image
                 {
                     ImageId = Guid.Parse("8DF59A4B-C2FE-4023-8A1E-7F308C8F68B8"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar91.jpg?alt=media&token=466bda06-2bf1-493f-9dd5-eee4ce0a94ab",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId =  Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A")
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("D539CBDB-A20C-4FD9-AC69-21FCB067249B"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar92.jpg?alt=media&token=fc46713e-0c32-486c-9c6c-546318f09d9d",
                     CreatedAt = DateTime.Parse("2024-8-27"),
                     CarId =  Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A")
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("A870408E-435B-4448-BB23-93BF329E40D5"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar93.jpg?alt=media&token=782b1c2f-49d2-4673-8101-330020231a01",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId =   Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A")
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("EC97ACCB-B58D-4677-B6C5-4C87E3441DE9"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar94.jpg?alt=media&token=94d25ed1-c76b-4edf-be53-0fe909ec5307",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId =  Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A")
                 },
                 // car 10
                 new Image
                 {
                     ImageId = Guid.Parse("63D8419B-AE3C-4867-96E2-2773531291D3"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar101.jpg?alt=media&token=77127151-3472-4206-8540-6909ec874c71",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("35FA8298-81A2-4DDD-9312-0876455BF402"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("F0E7A8C5-16E7-4A32-BF1D-3CADAFAF7153"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar102.jpg?alt=media&token=46f90372-9790-43f5-ae41-6f35c7961660",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("35FA8298-81A2-4DDD-9312-0876455BF402"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("FB35D1D2-5FF3-4016-86F0-DF5D5657C736"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar103.jpg?alt=media&token=b9e6ed3c-1328-4935-9eab-d3335638e503",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("35FA8298-81A2-4DDD-9312-0876455BF402"),
                 },
                 new Image
                 {
                     ImageId = Guid.Parse("8DD7C100-CCF9-4E7B-A2E6-AA3525698243"),
                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar104.jpg?alt=media&token=9688114d-001b-4f26-a5d8-562d9fb42bf7",
                     CreatedAt =  DateTime.Parse("2024-8-27"),
                     CarId = Guid.Parse("35FA8298-81A2-4DDD-9312-0876455BF402"),
                 }

            });
        }
    }
}
