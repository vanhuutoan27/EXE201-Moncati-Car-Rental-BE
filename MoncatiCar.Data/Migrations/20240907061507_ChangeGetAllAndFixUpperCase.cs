using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeGetAllAndFixUpperCase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("02ec8f94-9674-460f-ab22-435ffc495efc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("03a4629c-2f41-453f-a9a3-7a839888b619"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("03c9be57-fc41-4666-adbc-40a83d5e84dc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("054986cc-6b3d-44f1-ae3d-9777d8922cc6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("07719d43-6f77-4965-985b-daee391b7947"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("092a3211-65ff-4511-b4ab-dd1a894272a7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0bdf8f5c-f500-4fad-97ff-a461e13905cf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("11a209fc-6e6a-4714-9af6-b45727db9caf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("121ab852-ab27-4fdd-8ab8-04ac50754b7c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("14160925-92c7-40a8-9164-0f9abb615e18"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("156e2566-73a8-4c3e-a61f-c426b3e09c18"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("162ad3a7-e4f9-4fc0-8d15-2b0f578bdf24"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1c8c0650-5894-4fa8-80ad-7a11a2342dbb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1cb77c72-ce50-4302-a272-546874dda547"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1e49c3f5-3fca-49bc-8a8b-d727b1b83803"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1e888e48-26c6-4d81-b6f2-aa06f142f863"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("21272cd8-2878-4e85-9f9a-c8f462fccb52"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2195bea0-7146-47e2-a4cd-fd053ba24ff4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("249d86a6-253b-454d-a4c9-6391d28c5750"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("32c151d1-b974-4f57-9e7b-e9b3b50df75d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3309b1be-0073-4be4-b69e-ea46de62fd60"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("33c074bd-bdc2-4eac-b4c9-b9cd323b222e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3623a80e-5de7-4917-b5f6-c3720a1ff93b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("38da7ec9-c8ec-4119-825a-91d9a6e8c49e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3bf213c8-f4e0-4bb7-806c-78a9217cf47d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3d58d6e3-82eb-4581-b81b-19fbb6e4e186"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3ffe6b0a-e4fd-418c-a7d3-d671ec3a81cd"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("402e0bfa-6d38-47f5-abbe-7ca040d96769"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("40f2e869-8569-4002-a74d-a2e08969571c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("41e1315d-5556-4a3f-a341-7baf3ef153ff"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4444d9f2-144f-4949-9846-ac8188c277cf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("456db785-3afe-4628-970b-1b6a9f988f1c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("46742a77-6a49-463f-9b63-703135e4032e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("46b90506-0340-4b21-9d7a-14ea9a69a5b0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4786a8ff-03c7-4336-b0f4-3cc020d92edd"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("489da897-7fda-41b5-9c4b-762980c64451"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4c2cea26-8325-40d9-be73-5e4d367f483e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4e2c40d6-71c6-4bac-b41d-8f967e27b3a8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("510983a4-d4c9-4825-9537-cef66d32b63f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("53e47106-1f3a-428b-b81a-97458862a9dc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("56185fb0-c5d9-4190-b71d-e298edcfc409"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("56bf72af-f8ef-46c9-89f1-73aba46b476d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5918cf8f-e308-4aa4-8aaa-64a6ccf3c5af"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("59d8a3a2-ce1b-412c-9eda-e6f9d8359ce5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5b42365e-b82c-4d24-b7eb-e66504d66347"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5cf968a8-b829-43e2-b15f-75908d1b5f1b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5f2846d9-33a3-447a-b13f-4ec587345804"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5f303da2-f2ca-41e2-94d0-1db8616d37f3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("61d306f1-2ae1-4771-9c83-5399c622a3af"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("63b2a6ba-5dc0-4de7-9a06-5089a410f9ec"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("63dee7ab-cb46-4462-aaa5-1503606b7c9b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("668490d0-ea07-44b9-bbb3-befc37afc86b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("68b300d8-7c57-4ab5-a2db-4ddbdd4bc8b3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6c3f0dd8-ad4b-4c84-b57f-615d26bbcce6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6d25538e-69cb-4662-9b0f-e19795b3678a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6eda9414-0fce-41e3-b4ca-77cb074e771e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6f8491a1-3c43-4c5b-9794-71e26793034e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("71274e99-784e-4330-80bc-2e3761d0c655"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("71c0a686-dcb4-4716-8356-0b0e41cf2d4f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("71f826ad-f12e-4ba3-b2b8-3661c5a7d4ec"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7580ef8a-8646-44ee-ab2a-8b2a90c5831c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("76640fd5-f237-4817-9953-cd7e25acf1ee"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7829b6d7-5f5e-441a-8b66-998b20043945"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("80a6c05d-4ee9-4c7a-aafd-999f863ac50a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("811ff6cc-1a23-411a-a17f-d0cd5981d9c5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("81aae46a-8910-484d-bc01-ce03b6a61a41"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("822940c6-ff7a-4ec9-976d-7226ab0703b3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8296df8c-9f5e-483a-a171-df95a5cfd93c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("82d7c269-6cc2-4b68-a695-115b56d51154"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("84aa9a21-15e2-4c95-bce1-cb5dfe0f17d8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("85b6fb46-aa37-46bf-8217-f25a43aa378f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("869102fc-7a25-4274-a3f0-b0c2a88405da"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8869c890-db10-4e55-b1d2-868314a7221e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8875f4aa-ad69-457f-8de4-b43a7379d4e5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8a0bfe1f-eb7e-4dc8-b59c-3d9d1ba99bb2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8b43838b-c29d-40ed-b93b-fa6d9570d6ef"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8c2f48c2-58f9-4d0f-bbc7-d3a9ca854ab4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8e8a9140-e461-4fd5-871a-b9405cecf60a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("95252db8-240b-4e35-bddd-6e0d920a13fb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9586fd7b-e1ba-48c1-a456-abf4303e6a8d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("96765117-f858-4d0e-84bd-e644cebc247e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("973623fa-8e56-4a73-9763-c856c486d249"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("97f70df3-4210-42cf-98b2-0587e7dd166a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9843e74f-988a-4b08-bceb-b7c634e04168"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9e7dbc61-f7e0-4a2a-b862-26d71c643c8e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a2babdf5-3d2e-4ffb-a2e2-4a09163b7d75"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a3c891ef-203c-4abb-a332-a9ccd7a448fb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a427b5a1-e511-44ee-a83b-fa7f5bd67edc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a77d96e6-04ea-4834-9c01-aa5fa3dd33de"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a7ac274d-4ed5-4caf-bc33-11fd31728d36"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a98e1d23-0971-4c19-8386-5b6153521ea2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ad105bb0-e75b-463f-a3ed-592d79ab0d41"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b0d2c18a-f261-4d21-a6a9-b4904bd9def0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b39bb450-cc24-40b2-aef0-0b8ae7eb647b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b6e82353-a6c3-491a-a9a7-001074fc495f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b7aa3c7e-19fb-47bf-baa7-0f13aef05f70"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("badacae6-ff8a-437f-a9b3-355fab013fac"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("be6dc4d5-a1e9-49e8-b942-8eb16ba55a28"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bf66b192-8348-42da-844e-1407e3fcfacb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c1fae8c8-b5bc-46a7-a355-d9e7f6054528"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c2cd4660-b2bf-4a6f-9d37-1513c1fe9676"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c44c12cf-4bf1-4ff5-bbfb-2b9d84bf41c1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c48a968e-2996-45cc-97bf-9f6f1bd594f8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c7527287-a6d2-4eaf-9756-fefe4b09f142"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c783430e-84c5-4f08-8239-05bd0320ffda"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c90d20ca-5711-4af2-bf18-f056329f257d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cd87aa5a-ceb7-4667-9c18-da7dea2992a5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d0f13770-ebeb-4fef-851d-90c8c7b06168"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d2789d05-e5a3-45fc-95db-be7f2afd46b4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d4d9b5c3-e38b-4dc6-8f1b-10537aa75d8a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d67bbdfe-7307-46b4-af47-9ecec6e0e626"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d96480ca-7b0c-411d-b58d-fbfb469d4caf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dba2ffc8-fdc3-4238-8239-14c932c75d13"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dcc41630-97d7-4829-b7f4-0d95dbb26232"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dd2ddf15-a09b-4e5a-8992-1f235da8f9f3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("de3a2803-c8d4-44d3-8dca-2109c025a99d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("decc84d8-241c-43f4-baef-aa81f11ddb20"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("df133e33-a7e4-4df4-9924-9bfbfb4c06f0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("df97dd1c-db9f-4d00-b1c4-93db2312f334"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e08107f7-9715-41e2-ad35-5dc64d4da0b2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e16e7d9e-506c-4f69-815a-f928a0000567"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e3c7f9bd-935e-40f9-838e-8c0a534f9679"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e51534c9-1c3a-4874-9007-f7b4b4c818e5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e8e09eda-1ebe-498d-924d-5838ec4a8ee2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ea90b5d0-af5e-415f-9da3-90bb0d4a09ba"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("eb51347d-5eef-4013-b385-cfb4b6e98bee"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ec3fc798-3893-43a6-8f19-d67c3fcf1550"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ed2d815b-6668-4b7e-b400-796f904961ca"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("edefb9e2-c51c-4815-b6cc-88966ecd99a8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ee6e9cb6-59bf-47c4-8c29-c4a324253d09"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ef24e802-61e8-4930-b898-d2037b338418"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f0e46bd2-eb7e-4d8b-97ea-2f9ecdda7de5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f14c4e11-e493-4874-ad9b-4a7cc8cfe2f5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f4ed0248-ec39-4458-9939-e0fc6035e7c3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f7da3695-bd73-4325-b36e-ecea06cdb34f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f8583f6e-05b7-4f45-a977-7495467fbc3c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fb088c38-6f28-4317-a03b-202895adaca2"));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4483), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4505), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4479), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4470), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b802da6e-e178-46f5-9884-442e0f1067dc"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4500), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4488), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c6669c8e-f8a8-443c-8446-83c010b44ec0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4461), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("de716878-747e-4b02-9fce-46d67a13c30f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4475), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "CarFeatureId", "CarId", "FeatureId" },
                values: new object[,]
                {
                    { new Guid("00ec8fd3-97e4-4c82-aa89-312d4309c589"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("055bd977-c952-4035-b928-3a39026f09e8"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("057a1372-7663-41ef-8ffa-e9ec174c4b95"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("07aa159d-0a5b-4003-94aa-9b772a66d4fc"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("08ac7803-f139-45c0-92e2-d3e9e20e2867"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("0d1cf63f-a200-478f-b6d3-87eeb4d9d823"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("0ed3daa1-caf6-4578-8e15-5197c43996b4"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("10889c43-989e-4d41-937f-48509d558de1"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("183f0573-f048-434f-9597-e3bf6679be9b"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("18ea6c2d-f789-46bf-b84b-812a76251fa1"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("18f5955c-87e3-4fa6-98c5-714cb64872e1"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("1c0ea67d-f6da-4ecf-a222-6d68059d0f3c"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("1c6f73eb-9676-4f03-9a3a-e942ea6fb4bf"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("1cb3a7f6-ff53-41b0-9f02-bf61a025411b"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("22fbc477-6fd7-4eda-beb1-d201b935aa68"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("263bdf4a-4786-48c1-b157-7e049f0bcaa5"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("2b6f08db-34fe-45c4-9c8c-c571aa71139c"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("2dbdf096-96c5-4b95-bb6f-8a62ad099e8b"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("2e6cacb9-cf8b-4407-8a62-a5a58005854b"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("2f310705-44c3-409b-a62e-2878fb153ec7"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("2ff68a82-d233-484c-9d0f-5a0204a58b67"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("30b35d5b-1cb1-4fa9-9231-071d57596fb9"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("30dac6d4-18f6-42e6-bcaf-335ba64a3e4e"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("328e5ba1-a1f1-494f-bf68-931f055a8fc7"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("36d3f87b-b567-43e1-a6bb-0117a43659e3"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("36db9f20-a5fd-4b75-9cf9-233934b811b7"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("375acda4-eb91-47c7-b064-e2413bbd56f3"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("375f320b-237e-44cd-8df9-767c31a3d855"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("39aff6de-c350-4156-82f8-6ce7a343ab61"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("3a27005f-87a7-4aca-8c93-c2b3afc455c2"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("3ebcada5-6b52-4e95-adaa-a4af8b49143a"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("4021c8e1-dd9c-4edb-9d18-a4848dc8bd5d"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("40409547-6947-4797-accf-19e92326010b"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("4b31e1b9-c348-4394-9112-825942c92266"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("4bc7afa9-b70e-4975-bc5d-6f6d2d414787"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("4edddb33-0a14-4c51-97d9-200bf61bb627"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("5865d365-5cb8-44b4-bf26-a30fe330a51b"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("5881fad7-f478-4519-86e9-74d715ed627c"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("59102cd1-6b10-4476-96ec-1e07b17e19c1"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("5b916f14-90f8-4317-831f-7bf81b2bd7bc"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("5bad367e-6aa4-41f5-87c7-31c653ca3c45"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("5c8e41b5-e2b7-4057-a0a3-c8199cc1a9fc"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("5cd0f48a-9f68-4aac-8ce2-090172b9483e"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("64dbd9fd-670c-4b9c-b420-6eafc90a29f1"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("64f3b182-bd65-4f51-8316-17db4e75463f"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("655fbb7f-037e-42c5-a3c1-92507c38502d"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("65cbeb47-4625-4359-ba71-3ce477690c50"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("6959b9dc-dc23-4503-81ed-933c1e031c03"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("6ae5d65a-971a-44af-9a74-595ef4b25a76"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("6b2f3bb9-af42-4499-b338-385ae6cdf892"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("6ccfdc3e-aff8-4158-bf5a-7dcaf2f68410"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("6ebe3997-d742-45ea-bac0-f8735d725c40"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("6f56709b-663e-4751-bfb1-040af1cb900c"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("71abb662-998b-4f01-8414-4b74d4586234"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("758a9068-30e8-4f80-a2bd-748627c87205"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("75d65d7d-5e45-48be-9454-9818178318bf"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("79a5cb18-156f-47ae-9ac0-cdfdd4af0647"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("7c1242d1-6f81-4f1a-beec-4e0260b52af0"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("7f40ac59-7b19-4048-852f-ca4897133398"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("8247fbfc-c86c-416e-9b48-1b40e4ad7b5e"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("83f9dabb-88d1-4966-9005-7bb5a6ea0573"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("85ef4b5e-a83c-4827-b906-a494f14e2d1b"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("865f0bdf-74ca-4b2f-bba0-6c4cae1586de"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("8881cd3c-4145-4ee5-9785-704a1441ca9b"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("8a775c23-becf-4106-8ac0-42e41637e816"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("8a962ef3-9947-4723-8f1c-e7e1d6b461be"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("8adfddd0-85fc-45ff-8475-b2adac745b44"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("8db3e296-315b-4a35-a72b-a1c39a63a20b"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("8f39c694-bf8d-46e2-a172-19363c72a384"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("906cf5f9-5cb5-4047-9910-449f5867ba4e"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("91ecf0c7-b67a-43ff-8afc-984afc1bdd43"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("9285d949-c02c-4dcd-9374-6bb18ea458e7"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("97748245-e72d-4075-9d21-07d2a1742f27"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("997f0043-9429-4c6d-a85c-5b04dbb52581"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("99b7ba70-149c-41c7-9ff2-a34aaa986142"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("99f96be0-b919-4a1d-87ae-1d761ecfc74f"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("9a5c7c5e-579a-4a2c-a8ee-d91ea8134741"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020") },
                    { new Guid("9b272eb2-82bf-4f18-a3b4-5d5bcb11624e"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("9d1e4561-2767-4b46-84bc-07baa696ff5c"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("9ddf3155-13a9-42e6-be07-b9b822339aee"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("a110b5b7-b0f5-401b-b24c-af43267729f5"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("a14d2bb4-9f81-4782-954e-140bfa3202e8"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("a2669f20-60ae-41fe-9372-7c6e9b957533"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("a4f1626c-e934-4a75-abcf-04603ad4e79c"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("a5b6af74-f3b4-42b7-95d0-90c993f245d6"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("a73ee156-a511-4986-b59c-d8e4d584cb89"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("a7521444-a5b6-4877-82f4-fb75aab487d5"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("a89c8d6d-de9d-4ccb-8fce-0822be145a82"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("abc9b834-fcd3-4ba9-bebb-8d93b9612edb"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("ad49c758-f0b9-4d23-aada-4b060e377919"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("adfa28de-e224-42a9-9cb1-c94f14c08256"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("ae45eb77-cda4-4aa5-920e-8fb9266be364"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("af79aae4-e924-4200-a5f3-62f369611567"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("b14f734b-2967-49cd-82d0-2ce2ee97e08a"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("b2c89505-f047-423b-a98e-b4a1e45aa59d"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("b50408fc-c7d0-4e1c-a941-1420bd415f2a"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("b5c41e9c-4e42-4e11-82cf-571a96836628"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("ba2cb5d4-9fb8-4946-8abe-4dc47e54e6df"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("baf054f7-a78c-4d79-804e-edebc019557f"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("bd9533d1-be9a-43d0-8b74-d33c3bfff129"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("be731081-cb08-418d-82df-fa8af9c6a815"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("bf28c684-dc32-4198-b300-841045e21c49"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("c0cea25e-33e5-47c2-8f21-9ef25cd30d43"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("c11a0141-b630-4ba7-b613-bc6561995044"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("c2dd3fbc-8f78-4cfd-a43c-8a829aa39808"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("c44a631a-8b73-4ee4-b15f-9c50cb9c5d58"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("c8fcc7c3-5376-4f07-9a93-4be3027ddef5"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("ca782b74-f572-47ce-9e1c-0ab6cbcb1683"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("cadb6ae2-2532-45d8-9ebf-6506f44d7175"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("cb3bf370-4df4-4e22-8785-13433685274a"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("cc90a83a-f6d0-48c2-a089-107f86741038"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("d2c62392-900f-4db5-b4a1-d9e396206c69"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("d314e44a-e018-4a67-b213-d99ac600b310"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("d472d395-5526-4e32-8069-711264754af5"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("d58be081-332f-4635-af6d-34c2fab11639"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("d62d5800-d062-4da7-8a1e-57ef1b082194"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("d650fdee-9a54-47fc-9c4c-1e0c8c8db429"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("d8a0e4d4-6f33-4e7f-856d-59b35a6aa002"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("db28dc87-c990-42bd-9543-4484709f65e0"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("df8ad1f3-ccfd-4bd1-b213-a8563df05549"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("e123201a-d927-47f1-90cf-18ad9ef88f38"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("e1abc905-df8d-430e-9ce7-aa7fcbc53f52"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("e44bf399-aca5-40a5-a81c-51633292a55f"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("e54d4407-c435-4198-bd2e-f9fd64f49011"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("e8244036-5bf9-4446-a466-6977fe8e7484"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("e982c371-5b7d-4ae1-8a91-eab370b0e572"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("eb59f904-6332-4c05-86f3-82eb9af2bca8"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("ec327f83-e493-40ee-a8e7-271b84c60490"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("ec5f0b71-759f-4a0e-880c-03b08edb2cbe"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("ee4283a4-c542-4c82-8008-2eba342ced69"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("f2471242-78c8-475b-b07e-ff5cb2ddd02e"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("f8671110-1086-4482-af16-a81a0db4a3fb"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("f98a0c6b-f6f0-4832-814d-13efbcaa43dc"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("fba78d77-93e9-4195-a8df-351f001eb5da"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("fdeea9cf-80b4-4955-94ee-adfaf8fc8c8a"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("ff06241b-2e29-41b1-91c5-f4e8ae776812"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("ff9a6a81-9eac-48ae-be1e-0c0e5efd33bd"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5028), "peugeot-2008-gt-2022-x5uac6", new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5018), "hyundai-tucson-premium-2021-nixl5v", new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5052), "toyota-innova-2020-3ymd75", new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4993), "lexus-rx450h-2010-4urh11", new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("8705f403-06bc-4983-8c81-86310959cc37"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4980), "ford-ecosport-2015-duz4bh", new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4937), "mazda-cx5-deluxe-2017-vq57kp", new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4956), "vinfast-vf6-plus-2024-j7tjxw", new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4969), "peugeot-3008-2022-wlh7hm", new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5040), "mg-zs-standard-2022-k18fhr", new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5006), "hyundai-creta-2022-wesu5v", new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4270), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("06653486-dec4-4054-ba49-c3a63490453e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4264), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4169), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4203), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("4481e46d-e85b-4870-a210-cdfea8932641"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4183), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("533a7038-190b-4830-8125-5d2aacb7174e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4141), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4250), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4241), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4115), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4255), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4208), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("be392eff-ef38-4039-94ec-7922f315ea6a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4160), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4155), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4260), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4174), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f761d066-304f-49f7-b988-3aca64536d9b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4276), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4178), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("03071ddf-22c3-4321-9cfc-4c1dd506a9a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0831c830-8ab9-41ee-8abe-aeea4f832715"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("113d7987-dea8-4093-8b09-3ee0de72bb3c"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("119d2e54-a9c0-4b7c-87d6-5cd2f2501da9"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("13aecfda-8e98-4c0e-abc0-e20f1d13e961"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("146a6452-4bc4-4922-bb33-a69d1d0612dd"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("155e7784-a812-4571-bead-f8d7ca2478b5"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("16931f6d-b074-4bd2-9082-3de35b6db9d5"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1df708b5-2560-4664-89d6-6ee1e3b88d26"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2263a83a-5199-4240-9ecb-b19701d1fcf5"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("23fbf12e-52d0-4438-a9fe-f681d12b89fa"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("24971c14-5f2f-41aa-886b-1c114186d3bc"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("27e79248-04e4-4961-a0b1-cf22c2319ae4"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("38e6db85-3e32-4077-804c-f2287d118fd0"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4d4c2964-6453-4522-923e-1688da305391"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("53337daf-c5af-452f-802a-d8b829a9d068"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("589b7e11-94c3-4c5b-b4cb-2b3d215be33b"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5f11ba97-bde5-4400-b6dd-b4e02025a0d7"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("61c40521-3a6f-4a6a-816d-8c2a7f449997"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("63d8419b-ae3c-4867-96e2-2773531291d3"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("643c0c50-b89e-4d60-b339-28254d008738"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6c521908-21ff-4e8d-a8d0-4c05c8a2e5a7"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6ebfaf1c-748f-484a-b8b7-b7ddac7c883d"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("782d4c8e-2605-4a2d-87ba-3d1f2c9eb4d6"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("82428e6a-19f6-4599-aae1-13712934b3f8"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("8dd7c100-ccf9-4e7b-a2e6-aa3525698243"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("8df59a4b-c2fe-4023-8a1e-7f308c8f68b8"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("90fe95a8-3617-4676-abfa-9f86ed314bbb"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("91762bd8-9200-4d45-9ee8-e8f0e983e921"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a870408e-435b-4448-bb23-93bf329e40d5"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("bf8a664f-88fe-4e7c-b91c-427dd10970c2"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("bfbbaa76-998f-4d46-bbfe-664be8c4f6a5"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("bfbf38c4-5645-4392-9020-6c5b992ff46e"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c5de75b4-9631-43c0-8ac6-a9da568a967a"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d539cbdb-a20c-4fd9-ac69-21fcb067249b"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d898f1d5-cf63-4250-a8f7-c8cf25c61a46"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("dad87d5e-c756-4ee5-ae27-c3f84901c9d3"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("de16b5e0-65e8-45d1-ae2c-a446febb4b0d"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e33dfafe-cf13-43ba-93bc-9b150831123e"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e746af29-8cfb-4f2a-b1d8-593f44e0acd7"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ec97accb-b58d-4677-b6c5-4c87e3441de9"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f0e7a8c5-16e7-4a32-bf1d-3cadafaf7153"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("fb35d1d2-5ff3-4016-86f0-df5d5657c736"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("fdf80856-da90-4190-bf4e-66ed0601a4ba"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("0ed1b055-dcd4-48ee-aeff-7478382f9e96"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4706), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("16fd3123-d971-422c-b2af-e47978c27f35"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("1dc0a8e3-19b1-45f0-aec8-a810722de8f5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4725), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("32234d9d-90f2-4011-ba7f-85ead67a98bd"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4730), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("4e39763c-501a-47ea-9d11-f884de1e7e4e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4721), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("542d93fd-4bc2-48df-9e58-f12c17a96d79"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4750), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("6e18d51e-2964-4f16-a00c-0d4544671816"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4757), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("affeb1d2-7eb3-4410-a7ca-e3b1adc3cc54"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("f660d2b0-0444-4c02-b15a-2ebc871d8f4b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4715), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("fdfdef71-0e39-48f0-8eec-71f5429ed285"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4736), new DateTime(2024, 9, 7, 13, 15, 5, 281, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d30dd394-b2c2-4107-9e1b-b037a202968d", new DateTime(2024, 9, 7, 13, 15, 5, 592, DateTimeKind.Local).AddTicks(4003), "AQAAAAIAAYagAAAAEFRefZ/PAv5ejEaijtqYdqRihUQfassui4hnRi0dSoiGAx1knWcpqS4rpht5Qw2x7w==", "b357184f-03ae-41c6-864f-cbf242abc202", new DateTime(2024, 9, 7, 13, 15, 5, 592, DateTimeKind.Local).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0a69c549-b2f5-4a86-967d-d56ebc24d736", new DateTime(2024, 9, 7, 13, 15, 5, 878, DateTimeKind.Local).AddTicks(6732), "AQAAAAIAAYagAAAAEJTcgyxW2BN9yrLvFpHA4g5+B6HYmNOmrKbDun3mgugBbR6/lYXB7Cbt31Kbe6SW4g==", "f5f62afc-9431-417b-a59a-6374b5499a1b", new DateTime(2024, 9, 7, 13, 15, 5, 878, DateTimeKind.Local).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "33c5ad95-b042-4d6c-a247-5a04ae4ed95a", new DateTime(2024, 9, 7, 13, 15, 5, 373, DateTimeKind.Local).AddTicks(944), "AQAAAAIAAYagAAAAEJfgzI9km1VjT0iEVlKL7wzbBMUiD6gYNhlKgrvegIdc0hKZiNCiX4ZJ/tZ3o0lO3Q==", "a5c8728a-2e88-4c35-8f36-9d8a917f6aa9", new DateTime(2024, 9, 7, 13, 15, 5, 373, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b0845264-68e6-43a9-917b-05ecd63c42fe", new DateTime(2024, 9, 7, 13, 15, 5, 691, DateTimeKind.Local).AddTicks(9136), "AQAAAAIAAYagAAAAED2Zf+EexAqDniH1uFHH7gEchgc//on79eX1V1oCl7bbSKb7FbPwKxW5w8kkIAUHBw==", "514c2c83-4669-4f7d-9ddf-b80cb6e4aea6", new DateTime(2024, 9, 7, 13, 15, 5, 691, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d3ee391b-bae5-4e43-af11-d31f2904e6a4", new DateTime(2024, 9, 7, 13, 15, 5, 787, DateTimeKind.Local).AddTicks(4330), "AQAAAAIAAYagAAAAEC2pG18R4AbIp1JOrrL9FL8LkvMGGZ5q6exOVZ9ee7tgUu/WtTCdVfFFROhcxpOpMw==", "8c04f44c-9f7f-4d97-a454-0443be0f7df2", new DateTime(2024, 9, 7, 13, 15, 5, 787, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "69289fcf-ac66-4561-9921-8e9ccb73a238", new DateTime(2024, 9, 7, 13, 15, 5, 475, DateTimeKind.Local).AddTicks(3529), "AQAAAAIAAYagAAAAEAIuxCZuBgVW+jlyU8b2n59Qs8v5RGSrzUGTUt38DJEw6QFmkwmGYpJoH1f4L3bEAw==", "72fbc2a2-4846-442c-a2b1-93ad1ce15c90", new DateTime(2024, 9, 7, 13, 15, 5, 475, DateTimeKind.Local).AddTicks(3505) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("00ec8fd3-97e4-4c82-aa89-312d4309c589"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("055bd977-c952-4035-b928-3a39026f09e8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("057a1372-7663-41ef-8ffa-e9ec174c4b95"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("07aa159d-0a5b-4003-94aa-9b772a66d4fc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("08ac7803-f139-45c0-92e2-d3e9e20e2867"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0d1cf63f-a200-478f-b6d3-87eeb4d9d823"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0ed3daa1-caf6-4578-8e15-5197c43996b4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("10889c43-989e-4d41-937f-48509d558de1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("183f0573-f048-434f-9597-e3bf6679be9b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("18ea6c2d-f789-46bf-b84b-812a76251fa1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("18f5955c-87e3-4fa6-98c5-714cb64872e1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1c0ea67d-f6da-4ecf-a222-6d68059d0f3c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1c6f73eb-9676-4f03-9a3a-e942ea6fb4bf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1cb3a7f6-ff53-41b0-9f02-bf61a025411b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("22fbc477-6fd7-4eda-beb1-d201b935aa68"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("263bdf4a-4786-48c1-b157-7e049f0bcaa5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2b6f08db-34fe-45c4-9c8c-c571aa71139c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2dbdf096-96c5-4b95-bb6f-8a62ad099e8b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2e6cacb9-cf8b-4407-8a62-a5a58005854b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2f310705-44c3-409b-a62e-2878fb153ec7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2ff68a82-d233-484c-9d0f-5a0204a58b67"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("30b35d5b-1cb1-4fa9-9231-071d57596fb9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("30dac6d4-18f6-42e6-bcaf-335ba64a3e4e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("328e5ba1-a1f1-494f-bf68-931f055a8fc7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("36d3f87b-b567-43e1-a6bb-0117a43659e3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("36db9f20-a5fd-4b75-9cf9-233934b811b7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("375acda4-eb91-47c7-b064-e2413bbd56f3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("375f320b-237e-44cd-8df9-767c31a3d855"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("39aff6de-c350-4156-82f8-6ce7a343ab61"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3a27005f-87a7-4aca-8c93-c2b3afc455c2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3ebcada5-6b52-4e95-adaa-a4af8b49143a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4021c8e1-dd9c-4edb-9d18-a4848dc8bd5d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("40409547-6947-4797-accf-19e92326010b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4b31e1b9-c348-4394-9112-825942c92266"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4bc7afa9-b70e-4975-bc5d-6f6d2d414787"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4edddb33-0a14-4c51-97d9-200bf61bb627"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5865d365-5cb8-44b4-bf26-a30fe330a51b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5881fad7-f478-4519-86e9-74d715ed627c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("59102cd1-6b10-4476-96ec-1e07b17e19c1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5b916f14-90f8-4317-831f-7bf81b2bd7bc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5bad367e-6aa4-41f5-87c7-31c653ca3c45"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5c8e41b5-e2b7-4057-a0a3-c8199cc1a9fc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5cd0f48a-9f68-4aac-8ce2-090172b9483e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("64dbd9fd-670c-4b9c-b420-6eafc90a29f1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("64f3b182-bd65-4f51-8316-17db4e75463f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("655fbb7f-037e-42c5-a3c1-92507c38502d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("65cbeb47-4625-4359-ba71-3ce477690c50"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6959b9dc-dc23-4503-81ed-933c1e031c03"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6ae5d65a-971a-44af-9a74-595ef4b25a76"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6b2f3bb9-af42-4499-b338-385ae6cdf892"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6ccfdc3e-aff8-4158-bf5a-7dcaf2f68410"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6ebe3997-d742-45ea-bac0-f8735d725c40"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6f56709b-663e-4751-bfb1-040af1cb900c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("71abb662-998b-4f01-8414-4b74d4586234"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("758a9068-30e8-4f80-a2bd-748627c87205"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("75d65d7d-5e45-48be-9454-9818178318bf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("79a5cb18-156f-47ae-9ac0-cdfdd4af0647"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7c1242d1-6f81-4f1a-beec-4e0260b52af0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7f40ac59-7b19-4048-852f-ca4897133398"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8247fbfc-c86c-416e-9b48-1b40e4ad7b5e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("83f9dabb-88d1-4966-9005-7bb5a6ea0573"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("85ef4b5e-a83c-4827-b906-a494f14e2d1b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("865f0bdf-74ca-4b2f-bba0-6c4cae1586de"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8881cd3c-4145-4ee5-9785-704a1441ca9b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8a775c23-becf-4106-8ac0-42e41637e816"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8a962ef3-9947-4723-8f1c-e7e1d6b461be"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8adfddd0-85fc-45ff-8475-b2adac745b44"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8db3e296-315b-4a35-a72b-a1c39a63a20b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8f39c694-bf8d-46e2-a172-19363c72a384"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("906cf5f9-5cb5-4047-9910-449f5867ba4e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("91ecf0c7-b67a-43ff-8afc-984afc1bdd43"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9285d949-c02c-4dcd-9374-6bb18ea458e7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("97748245-e72d-4075-9d21-07d2a1742f27"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("997f0043-9429-4c6d-a85c-5b04dbb52581"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("99b7ba70-149c-41c7-9ff2-a34aaa986142"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("99f96be0-b919-4a1d-87ae-1d761ecfc74f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9a5c7c5e-579a-4a2c-a8ee-d91ea8134741"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9b272eb2-82bf-4f18-a3b4-5d5bcb11624e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9d1e4561-2767-4b46-84bc-07baa696ff5c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9ddf3155-13a9-42e6-be07-b9b822339aee"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a110b5b7-b0f5-401b-b24c-af43267729f5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a14d2bb4-9f81-4782-954e-140bfa3202e8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a2669f20-60ae-41fe-9372-7c6e9b957533"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a4f1626c-e934-4a75-abcf-04603ad4e79c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a5b6af74-f3b4-42b7-95d0-90c993f245d6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a73ee156-a511-4986-b59c-d8e4d584cb89"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a7521444-a5b6-4877-82f4-fb75aab487d5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a89c8d6d-de9d-4ccb-8fce-0822be145a82"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("abc9b834-fcd3-4ba9-bebb-8d93b9612edb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ad49c758-f0b9-4d23-aada-4b060e377919"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("adfa28de-e224-42a9-9cb1-c94f14c08256"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ae45eb77-cda4-4aa5-920e-8fb9266be364"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("af79aae4-e924-4200-a5f3-62f369611567"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b14f734b-2967-49cd-82d0-2ce2ee97e08a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b2c89505-f047-423b-a98e-b4a1e45aa59d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b50408fc-c7d0-4e1c-a941-1420bd415f2a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b5c41e9c-4e42-4e11-82cf-571a96836628"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ba2cb5d4-9fb8-4946-8abe-4dc47e54e6df"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("baf054f7-a78c-4d79-804e-edebc019557f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bd9533d1-be9a-43d0-8b74-d33c3bfff129"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("be731081-cb08-418d-82df-fa8af9c6a815"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bf28c684-dc32-4198-b300-841045e21c49"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c0cea25e-33e5-47c2-8f21-9ef25cd30d43"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c11a0141-b630-4ba7-b613-bc6561995044"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c2dd3fbc-8f78-4cfd-a43c-8a829aa39808"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c44a631a-8b73-4ee4-b15f-9c50cb9c5d58"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c8fcc7c3-5376-4f07-9a93-4be3027ddef5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ca782b74-f572-47ce-9e1c-0ab6cbcb1683"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cadb6ae2-2532-45d8-9ebf-6506f44d7175"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cb3bf370-4df4-4e22-8785-13433685274a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cc90a83a-f6d0-48c2-a089-107f86741038"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d2c62392-900f-4db5-b4a1-d9e396206c69"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d314e44a-e018-4a67-b213-d99ac600b310"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d472d395-5526-4e32-8069-711264754af5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d58be081-332f-4635-af6d-34c2fab11639"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d62d5800-d062-4da7-8a1e-57ef1b082194"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d650fdee-9a54-47fc-9c4c-1e0c8c8db429"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d8a0e4d4-6f33-4e7f-856d-59b35a6aa002"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("db28dc87-c990-42bd-9543-4484709f65e0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("df8ad1f3-ccfd-4bd1-b213-a8563df05549"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e123201a-d927-47f1-90cf-18ad9ef88f38"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e1abc905-df8d-430e-9ce7-aa7fcbc53f52"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e44bf399-aca5-40a5-a81c-51633292a55f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e54d4407-c435-4198-bd2e-f9fd64f49011"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e8244036-5bf9-4446-a466-6977fe8e7484"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e982c371-5b7d-4ae1-8a91-eab370b0e572"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("eb59f904-6332-4c05-86f3-82eb9af2bca8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ec327f83-e493-40ee-a8e7-271b84c60490"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ec5f0b71-759f-4a0e-880c-03b08edb2cbe"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ee4283a4-c542-4c82-8008-2eba342ced69"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f2471242-78c8-475b-b07e-ff5cb2ddd02e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f8671110-1086-4482-af16-a81a0db4a3fb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f98a0c6b-f6f0-4832-814d-13efbcaa43dc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fba78d77-93e9-4195-a8df-351f001eb5da"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fdeea9cf-80b4-4955-94ee-adfaf8fc8c8a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ff06241b-2e29-41b1-91c5-f4e8ae776812"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ff9a6a81-9eac-48ae-be1e-0c0e5efd33bd"));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1036), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1044), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1033), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1028), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b802da6e-e178-46f5-9884-442e0f1067dc"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1041), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1039), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c6669c8e-f8a8-443c-8446-83c010b44ec0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1021), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("de716878-747e-4b02-9fce-46d67a13c30f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1031), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "CarFeatureId", "CarId", "FeatureId" },
                values: new object[,]
                {
                    { new Guid("02ec8f94-9674-460f-ab22-435ffc495efc"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("03a4629c-2f41-453f-a9a3-7a839888b619"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("03c9be57-fc41-4666-adbc-40a83d5e84dc"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("054986cc-6b3d-44f1-ae3d-9777d8922cc6"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("07719d43-6f77-4965-985b-daee391b7947"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("092a3211-65ff-4511-b4ab-dd1a894272a7"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("0bdf8f5c-f500-4fad-97ff-a461e13905cf"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("11a209fc-6e6a-4714-9af6-b45727db9caf"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("121ab852-ab27-4fdd-8ab8-04ac50754b7c"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("14160925-92c7-40a8-9164-0f9abb615e18"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("156e2566-73a8-4c3e-a61f-c426b3e09c18"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("162ad3a7-e4f9-4fc0-8d15-2b0f578bdf24"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("1c8c0650-5894-4fa8-80ad-7a11a2342dbb"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("1cb77c72-ce50-4302-a272-546874dda547"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("1e49c3f5-3fca-49bc-8a8b-d727b1b83803"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("1e888e48-26c6-4d81-b6f2-aa06f142f863"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("21272cd8-2878-4e85-9f9a-c8f462fccb52"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("2195bea0-7146-47e2-a4cd-fd053ba24ff4"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("249d86a6-253b-454d-a4c9-6391d28c5750"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("32c151d1-b974-4f57-9e7b-e9b3b50df75d"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("3309b1be-0073-4be4-b69e-ea46de62fd60"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("33c074bd-bdc2-4eac-b4c9-b9cd323b222e"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("3623a80e-5de7-4917-b5f6-c3720a1ff93b"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("38da7ec9-c8ec-4119-825a-91d9a6e8c49e"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("3bf213c8-f4e0-4bb7-806c-78a9217cf47d"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("3d58d6e3-82eb-4581-b81b-19fbb6e4e186"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("3ffe6b0a-e4fd-418c-a7d3-d671ec3a81cd"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("402e0bfa-6d38-47f5-abbe-7ca040d96769"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("40f2e869-8569-4002-a74d-a2e08969571c"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("41e1315d-5556-4a3f-a341-7baf3ef153ff"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("4444d9f2-144f-4949-9846-ac8188c277cf"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("456db785-3afe-4628-970b-1b6a9f988f1c"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("46742a77-6a49-463f-9b63-703135e4032e"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("46b90506-0340-4b21-9d7a-14ea9a69a5b0"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("4786a8ff-03c7-4336-b0f4-3cc020d92edd"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("489da897-7fda-41b5-9c4b-762980c64451"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("4c2cea26-8325-40d9-be73-5e4d367f483e"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("4e2c40d6-71c6-4bac-b41d-8f967e27b3a8"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020") },
                    { new Guid("510983a4-d4c9-4825-9537-cef66d32b63f"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("53e47106-1f3a-428b-b81a-97458862a9dc"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("56185fb0-c5d9-4190-b71d-e298edcfc409"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("56bf72af-f8ef-46c9-89f1-73aba46b476d"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("5918cf8f-e308-4aa4-8aaa-64a6ccf3c5af"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("59d8a3a2-ce1b-412c-9eda-e6f9d8359ce5"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("5b42365e-b82c-4d24-b7eb-e66504d66347"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("5cf968a8-b829-43e2-b15f-75908d1b5f1b"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("5f2846d9-33a3-447a-b13f-4ec587345804"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("5f303da2-f2ca-41e2-94d0-1db8616d37f3"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("61d306f1-2ae1-4771-9c83-5399c622a3af"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("63b2a6ba-5dc0-4de7-9a06-5089a410f9ec"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("63dee7ab-cb46-4462-aaa5-1503606b7c9b"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("668490d0-ea07-44b9-bbb3-befc37afc86b"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("68b300d8-7c57-4ab5-a2db-4ddbdd4bc8b3"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("6c3f0dd8-ad4b-4c84-b57f-615d26bbcce6"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("6d25538e-69cb-4662-9b0f-e19795b3678a"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("6eda9414-0fce-41e3-b4ca-77cb074e771e"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("6f8491a1-3c43-4c5b-9794-71e26793034e"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("71274e99-784e-4330-80bc-2e3761d0c655"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("71c0a686-dcb4-4716-8356-0b0e41cf2d4f"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("71f826ad-f12e-4ba3-b2b8-3661c5a7d4ec"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("7580ef8a-8646-44ee-ab2a-8b2a90c5831c"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("76640fd5-f237-4817-9953-cd7e25acf1ee"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("7829b6d7-5f5e-441a-8b66-998b20043945"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("80a6c05d-4ee9-4c7a-aafd-999f863ac50a"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("811ff6cc-1a23-411a-a17f-d0cd5981d9c5"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("81aae46a-8910-484d-bc01-ce03b6a61a41"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("822940c6-ff7a-4ec9-976d-7226ab0703b3"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("8296df8c-9f5e-483a-a171-df95a5cfd93c"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("82d7c269-6cc2-4b68-a695-115b56d51154"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("84aa9a21-15e2-4c95-bce1-cb5dfe0f17d8"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("85b6fb46-aa37-46bf-8217-f25a43aa378f"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("869102fc-7a25-4274-a3f0-b0c2a88405da"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("8869c890-db10-4e55-b1d2-868314a7221e"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("8875f4aa-ad69-457f-8de4-b43a7379d4e5"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("8a0bfe1f-eb7e-4dc8-b59c-3d9d1ba99bb2"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("8b43838b-c29d-40ed-b93b-fa6d9570d6ef"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("8c2f48c2-58f9-4d0f-bbc7-d3a9ca854ab4"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("8e8a9140-e461-4fd5-871a-b9405cecf60a"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("95252db8-240b-4e35-bddd-6e0d920a13fb"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("9586fd7b-e1ba-48c1-a456-abf4303e6a8d"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("96765117-f858-4d0e-84bd-e644cebc247e"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("973623fa-8e56-4a73-9763-c856c486d249"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("97f70df3-4210-42cf-98b2-0587e7dd166a"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("9843e74f-988a-4b08-bceb-b7c634e04168"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("9e7dbc61-f7e0-4a2a-b862-26d71c643c8e"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("a2babdf5-3d2e-4ffb-a2e2-4a09163b7d75"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("a3c891ef-203c-4abb-a332-a9ccd7a448fb"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("a427b5a1-e511-44ee-a83b-fa7f5bd67edc"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("a77d96e6-04ea-4834-9c01-aa5fa3dd33de"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("a7ac274d-4ed5-4caf-bc33-11fd31728d36"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("a98e1d23-0971-4c19-8386-5b6153521ea2"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("ad105bb0-e75b-463f-a3ed-592d79ab0d41"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("b0d2c18a-f261-4d21-a6a9-b4904bd9def0"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("b39bb450-cc24-40b2-aef0-0b8ae7eb647b"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("b6e82353-a6c3-491a-a9a7-001074fc495f"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("b7aa3c7e-19fb-47bf-baa7-0f13aef05f70"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("badacae6-ff8a-437f-a9b3-355fab013fac"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("be6dc4d5-a1e9-49e8-b942-8eb16ba55a28"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("bf66b192-8348-42da-844e-1407e3fcfacb"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("c1fae8c8-b5bc-46a7-a355-d9e7f6054528"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("c2cd4660-b2bf-4a6f-9d37-1513c1fe9676"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("c44c12cf-4bf1-4ff5-bbfb-2b9d84bf41c1"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("c48a968e-2996-45cc-97bf-9f6f1bd594f8"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("c7527287-a6d2-4eaf-9756-fefe4b09f142"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("c783430e-84c5-4f08-8239-05bd0320ffda"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("c90d20ca-5711-4af2-bf18-f056329f257d"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("cd87aa5a-ceb7-4667-9c18-da7dea2992a5"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("d0f13770-ebeb-4fef-851d-90c8c7b06168"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("d2789d05-e5a3-45fc-95db-be7f2afd46b4"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("d4d9b5c3-e38b-4dc6-8f1b-10537aa75d8a"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("d67bbdfe-7307-46b4-af47-9ecec6e0e626"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("d96480ca-7b0c-411d-b58d-fbfb469d4caf"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("dba2ffc8-fdc3-4238-8239-14c932c75d13"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("dcc41630-97d7-4829-b7f4-0d95dbb26232"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("dd2ddf15-a09b-4e5a-8992-1f235da8f9f3"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("de3a2803-c8d4-44d3-8dca-2109c025a99d"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("decc84d8-241c-43f4-baef-aa81f11ddb20"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("df133e33-a7e4-4df4-9924-9bfbfb4c06f0"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("df97dd1c-db9f-4d00-b1c4-93db2312f334"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("e08107f7-9715-41e2-ad35-5dc64d4da0b2"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("e16e7d9e-506c-4f69-815a-f928a0000567"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("e3c7f9bd-935e-40f9-838e-8c0a534f9679"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("e51534c9-1c3a-4874-9007-f7b4b4c818e5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("e8e09eda-1ebe-498d-924d-5838ec4a8ee2"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("ea90b5d0-af5e-415f-9da3-90bb0d4a09ba"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("eb51347d-5eef-4013-b385-cfb4b6e98bee"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("ec3fc798-3893-43a6-8f19-d67c3fcf1550"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("ed2d815b-6668-4b7e-b400-796f904961ca"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("edefb9e2-c51c-4815-b6cc-88966ecd99a8"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("ee6e9cb6-59bf-47c4-8c29-c4a324253d09"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("ef24e802-61e8-4930-b898-d2037b338418"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("f0e46bd2-eb7e-4d8b-97ea-2f9ecdda7de5"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("f14c4e11-e493-4874-ad9b-4a7cc8cfe2f5"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("f4ed0248-ec39-4458-9939-e0fc6035e7c3"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("f7da3695-bd73-4325-b36e-ecea06cdb34f"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("f8583f6e-05b7-4f45-a977-7495467fbc3c"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("fb088c38-6f28-4317-a03b-202895adaca2"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1401), "peugeot-2008-gt-2022-X5UAC6", new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1386), "hyundai-tucson-premium-2021-NIXL5V", new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1419), "toyota-innova-2020-3YMD75", new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1366), "lexus-rx450h-2010-4URH11", new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("8705f403-06bc-4983-8c81-86310959cc37"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1291), "ford-ecosport-2015-DUZ4BH", new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1268), "mazda-cx5-deluxe-2017-VQ57KP", new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1277), "vinfast-vf6-plus-2024-H7TJXW", new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1284), "peugeot-3008-2022-WLH7HM", new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1410), "mg-zs-standard-2022-K18FHR", new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"),
                columns: new[] { "CreatedAt", "Slug", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1376), "hyundai-creta-2022-WESU5V", new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(916), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("06653486-dec4-4054-ba49-c3a63490453e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(914), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(878), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(890), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(868), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("4481e46d-e85b-4870-a210-cdfea8932641"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(887), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("533a7038-190b-4830-8125-5d2aacb7174e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(864), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(898), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(896), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(842), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(901), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(893), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("be392eff-ef38-4039-94ec-7922f315ea6a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(874), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(871), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(904), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(881), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f761d066-304f-49f7-b988-3aca64536d9b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(920), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(884), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("03071ddf-22c3-4321-9cfc-4c1dd506a9a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0831c830-8ab9-41ee-8abe-aeea4f832715"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("113d7987-dea8-4093-8b09-3ee0de72bb3c"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("119d2e54-a9c0-4b7c-87d6-5cd2f2501da9"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("13aecfda-8e98-4c0e-abc0-e20f1d13e961"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("146a6452-4bc4-4922-bb33-a69d1d0612dd"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("155e7784-a812-4571-bead-f8d7ca2478b5"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("16931f6d-b074-4bd2-9082-3de35b6db9d5"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1df708b5-2560-4664-89d6-6ee1e3b88d26"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2263a83a-5199-4240-9ecb-b19701d1fcf5"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("23fbf12e-52d0-4438-a9fe-f681d12b89fa"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("24971c14-5f2f-41aa-886b-1c114186d3bc"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("27e79248-04e4-4961-a0b1-cf22c2319ae4"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("38e6db85-3e32-4077-804c-f2287d118fd0"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4d4c2964-6453-4522-923e-1688da305391"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("53337daf-c5af-452f-802a-d8b829a9d068"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("589b7e11-94c3-4c5b-b4cb-2b3d215be33b"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5f11ba97-bde5-4400-b6dd-b4e02025a0d7"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("61c40521-3a6f-4a6a-816d-8c2a7f449997"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("63d8419b-ae3c-4867-96e2-2773531291d3"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("643c0c50-b89e-4d60-b339-28254d008738"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6c521908-21ff-4e8d-a8d0-4c05c8a2e5a7"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6ebfaf1c-748f-484a-b8b7-b7ddac7c883d"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("782d4c8e-2605-4a2d-87ba-3d1f2c9eb4d6"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("82428e6a-19f6-4599-aae1-13712934b3f8"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("8dd7c100-ccf9-4e7b-a2e6-aa3525698243"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("8df59a4b-c2fe-4023-8a1e-7f308c8f68b8"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("90fe95a8-3617-4676-abfa-9f86ed314bbb"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("91762bd8-9200-4d45-9ee8-e8f0e983e921"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a870408e-435b-4448-bb23-93bf329e40d5"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("bf8a664f-88fe-4e7c-b91c-427dd10970c2"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("bfbbaa76-998f-4d46-bbfe-664be8c4f6a5"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("bfbf38c4-5645-4392-9020-6c5b992ff46e"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c5de75b4-9631-43c0-8ac6-a9da568a967a"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d539cbdb-a20c-4fd9-ac69-21fcb067249b"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d898f1d5-cf63-4250-a8f7-c8cf25c61a46"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("dad87d5e-c756-4ee5-ae27-c3f84901c9d3"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("de16b5e0-65e8-45d1-ae2c-a446febb4b0d"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e33dfafe-cf13-43ba-93bc-9b150831123e"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e746af29-8cfb-4f2a-b1d8-593f44e0acd7"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ec97accb-b58d-4677-b6c5-4c87e3441de9"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f0e7a8c5-16e7-4a32-bf1d-3cadafaf7153"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("fb35d1d2-5ff3-4016-86f0-df5d5657c736"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("fdf80856-da90-4190-bf4e-66ed0601a4ba"),
                column: "CreatedAt",
                value: new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("0ed1b055-dcd4-48ee-aeff-7478382f9e96"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1141), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("16fd3123-d971-422c-b2af-e47978c27f35"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1163), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("1dc0a8e3-19b1-45f0-aec8-a810722de8f5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1155), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("32234d9d-90f2-4011-ba7f-85ead67a98bd"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1158), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("4e39763c-501a-47ea-9d11-f884de1e7e4e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1153), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("542d93fd-4bc2-48df-9e58-f12c17a96d79"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1168), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("6e18d51e-2964-4f16-a00c-0d4544671816"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1171), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1172) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("affeb1d2-7eb3-4410-a7ca-e3b1adc3cc54"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1166), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("f660d2b0-0444-4c02-b15a-2ebc871d8f4b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1150), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ModelId",
                keyValue: new Guid("fdfdef71-0e39-48f0-8eec-71f5429ed285"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1161), new DateTime(2024, 9, 3, 22, 57, 11, 923, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ffee820e-b63f-403f-b271-6a699eae14a6", new DateTime(2024, 9, 3, 22, 57, 12, 135, DateTimeKind.Local).AddTicks(8168), "AQAAAAIAAYagAAAAEL9jrbb2R9/aF5IUMWZ2ekeqWlCqvtVbQTSWij5dtOjXLKDHy0Y9YD3+gVLAMdxEXQ==", "9e6a5a13-8938-422d-b68a-63aa2d7b8ee7", new DateTime(2024, 9, 3, 22, 57, 12, 135, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "117e114c-f172-4c24-8fc5-211b0bcb0370", new DateTime(2024, 9, 3, 22, 57, 12, 337, DateTimeKind.Local).AddTicks(5221), "AQAAAAIAAYagAAAAEK2nVCcHHVMs+fYhTBo5Yl5xSfyBQ1sPCErqKVTApkw/o5HWsPI1aQxGcG8YrieBLg==", "6f01220f-7f11-4094-be3f-779f342d9358", new DateTime(2024, 9, 3, 22, 57, 12, 337, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d2733cab-f4fb-4439-9b30-bd079f6fe6e3", new DateTime(2024, 9, 3, 22, 57, 11, 987, DateTimeKind.Local).AddTicks(5150), "AQAAAAIAAYagAAAAEBEuBw4b1ao3SBstFqeCFN3zMIXrQ1LqRSM3MOxiuHbRr7mb5EZYiWvFJM9qNb3Ahg==", "199d8c14-ed7c-412c-903e-b53df8b3c1bb", new DateTime(2024, 9, 3, 22, 57, 11, 987, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cf9dcfb5-206e-4251-b662-fc0e3570140c", new DateTime(2024, 9, 3, 22, 57, 12, 202, DateTimeKind.Local).AddTicks(1686), "AQAAAAIAAYagAAAAEICqk8NBV7IgvPBepjVpsiid/CiZIFy8osyYwLIUgikl+2zo1VUYnom/6isaDk+tuQ==", "f08c523b-c7e7-4a1c-b447-f3be6c59ed56", new DateTime(2024, 9, 3, 22, 57, 12, 202, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "61ae964f-8831-4b91-ad50-c3e7c216ff0d", new DateTime(2024, 9, 3, 22, 57, 12, 266, DateTimeKind.Local).AddTicks(6139), "AQAAAAIAAYagAAAAEEFXcgipM7gBqpy985oYGzYUUhaF8z9pvv5Ze8jH85aLs0XUIkGBy0qqViREk27kNQ==", "30cc0237-a336-4d77-bd34-d342e6ea7ffc", new DateTime(2024, 9, 3, 22, 57, 12, 266, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "141dac67-473e-4612-819a-29b5bea28116", new DateTime(2024, 9, 3, 22, 57, 12, 50, DateTimeKind.Local).AddTicks(9324), "AQAAAAIAAYagAAAAEN+Lswg1U3Ilbhl0TLOT4NIjoD155KEAIkqEkpSD/pdn4sM6dX3zHcX1ocrzQRhLWw==", "da974fc5-025d-4ab5-be35-b7110ace694d", new DateTime(2024, 9, 3, 22, 57, 12, 50, DateTimeKind.Local).AddTicks(9300) });
        }
    }
}
