using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCitizendIDTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("001a77a1-68c3-40e1-ae40-6843f2ef5c13"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("006d49ad-8b25-4fda-8337-a1ee3a26c4f6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("02366382-b0e7-4df9-99d5-ef405a9f2da6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("024fa323-70dd-48d2-9226-e43e95ab281c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("03200848-b79e-47c6-865e-5034a3f83629"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("041a5430-0ab1-4029-95bf-0a948e76afe3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("04231212-0b39-40af-b875-a331c5af4e15"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("07937bfa-5b71-4c71-bcc5-01bc31d3c3e4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0b1c0d83-0850-4689-866c-4ef2aafdb489"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0b490a54-0229-4d2e-882f-1e2ee985c2de"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1106baff-beda-4188-ae8c-0dc69dc34c8b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("12c3a376-6b41-4f8e-8acc-1fb8b118bdec"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1d6122ec-f8ac-44d0-a905-75cbfd1d59fe"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1f92ef78-db34-4687-baca-8b17f498234f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("209ff72b-a039-4fe6-a09c-bb7105f5716e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("277dfd02-6417-4740-889e-002f86f96768"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("28464ba5-0bce-4006-8f21-a32ef2d57df6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2941e3da-e3b2-476a-ba3d-9126681dacdc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("29f7a6c1-0e5d-4e08-90ee-b5cf8bb6387f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2b8d386b-d677-4a24-a00f-c036973fc742"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2d95ef02-cfec-470d-940a-9b2610cb3914"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2e9331a3-4d6c-4c15-a382-e157390b4bdc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2f5bad5e-9b35-4ff6-90e4-fb4e111d3e55"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("30705150-48d4-4dbf-9e98-95677f272ffc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("32b15407-7717-4820-be72-4901b18d5639"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("330cdc34-4696-43c0-be51-913965ec24b6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("35695d00-9860-4c95-9f68-630f824c1d44"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("35754045-5960-4f87-931c-0401099a3f34"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("362ffbf1-cc73-4303-9391-9c5523b0e084"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3675cb0a-acac-431a-9b69-c6415b6e0d76"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("38f76431-2978-423b-bb0f-9df36483a26c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("39058134-8c30-4658-a8dc-eed23363c400"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3a4be102-7711-4f96-a4b8-a0025a882512"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3b58ed28-b4d5-4546-8d7c-dee38011fa0d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3bd9785c-86f0-459d-bc99-5ee0e8b4e0e7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4309742e-0097-4589-9847-4d1057043ccf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("43a9f8c5-283a-4e91-b6bb-2b63575f9289"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("44193320-c40c-4625-a7b5-1f098852eb9b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("48913691-9f79-4122-9182-06a22492bacc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("48c7fe25-5b91-4c0f-8d75-bef731b6f6a8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("48e115d2-314c-48df-83df-ad4a479b9816"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4a822cea-085e-41b2-95dd-edf97785008c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4e8e3231-0e95-4c3b-aeb6-ba78ce65d647"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("506606bc-f9c3-475b-9d47-9511200a3e4d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("52f246dc-2b0d-4e06-a11a-c3ceccc3c847"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("554d4832-543b-4397-8b55-0e4063837f76"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5581d4d4-5faa-49ef-92d7-925e5a1822b9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("570312d4-c642-4f39-922b-677295120212"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5d649b25-9b24-4017-bdcb-11d451a675e3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("60b528ba-25c0-4b68-8861-c1854164881f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("60ef0b7b-ac78-4d5e-846d-25c63b08ed71"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("66ffe4b4-9497-4348-a7cf-c8215e75e168"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6e112be1-ae63-4005-93cc-a0268d08e147"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6e5e7bb0-0f91-4c5c-b41a-e2e5711a3772"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("70a4940f-7b9f-4ddc-86d6-bbfcee3e33ae"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("742bb51a-e5c1-4fae-aa81-11ab03760f65"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("750328fc-10a7-4db2-bdd1-0d27c3c98dbd"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("75514162-2405-4a0c-acb3-ec26572d1ffe"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7551551a-3dfb-4786-af52-dbd1ca764c23"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("759536f6-60fd-4b99-ac72-739c9f6a9f46"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("75bb62d1-3ba0-4147-8beb-769881239291"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("78dbd2fd-3d5a-4d3c-a973-fe9eb0c243be"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7bca4c3f-3ae6-4463-8f6e-5ee998b1a563"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7cfaee2b-5218-47ee-92dc-683880437578"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7dcf2668-4fa8-4d0a-965c-ade7b96403fe"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("813fe3ea-bf2d-4918-a3a3-af7276811794"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("81e85fca-9323-4326-9376-4c59e5dfe13a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("83e8bf8a-e7d5-4f49-8d35-924828fa8638"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8417d3b5-8689-4904-a996-619c70281529"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("85ba2db2-2cc6-44e8-ac32-bf845fb419b4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("872f4642-8ac7-4994-b348-bb6186f54d60"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("882a09fa-967e-45e9-b605-232d7039f649"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8c60b5ec-b32a-490c-9077-466f35338feb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8cbc1836-e13e-4127-80f5-9b810de44e3b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8d7152d9-80bb-48c0-b0ec-39f791c433f2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8ef89c81-ca67-42cf-a6aa-5070c1f916ef"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("909ba2b6-0fda-46c5-9385-89b2ba9cca4b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9308aefd-bb13-421b-b365-00ff63f84a51"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("94e7924d-d184-4171-a51f-7ec7b5adfe51"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("955defc7-8778-422e-bd03-f325f41a823e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("97acf358-8dfd-407a-9457-596056bd1110"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("97cba00b-8413-4e20-8cf3-1a6c3fb7c7b5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9af918ec-b56f-45a9-a4ad-172092962035"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9d71a53b-cc2f-44fd-8ef1-58b159c10f41"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9d98891d-25c3-42c9-a16e-51572a0b0ca8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9f321621-f97b-4cf5-95d5-e06effe6b99c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9ff2535b-aa0d-4ed0-90cc-367a659e7813"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a4aff71f-56af-4334-886a-c5a06f8f3df9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a547774d-44ac-42ae-aa06-13ff1afdf348"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a6fc689a-f889-4315-ac26-5171c257cb85"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a8d6e5d4-1142-444f-85fd-af0d2200f298"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b1200146-f389-4fda-8075-93b08b724cc2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b2652037-df61-4848-a1dd-54ed21ef1820"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b4033fb8-5eaa-49e9-8dc7-b3233093d8f9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b5dc5d53-053c-46d6-a012-4a35550ecd00"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b85ce19b-d968-4af9-9fcb-115d889e777c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b8eb8540-9dda-49ee-ba96-9ed0cbe41d51"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b8f87523-86bf-4f50-863d-846fba6c4cc4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b90acbec-533d-4021-882f-a9e35976aa75"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bdf3dd85-5f98-4b06-890d-d8eae9ca4c2d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bf88c96a-cbbd-4189-b602-82935989e91f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c0458cf5-d042-43a0-af4f-3acdd35a51e8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c245df00-c68e-4042-a48c-c165ab2d5faf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c99b4ae2-7645-4f12-afd7-3ccb60d3f5f8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c9c53606-256a-41be-bf63-d83d4ac53bc5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cc98239a-dddb-4b2b-888c-20c13c36d99d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cdb064e3-c3fd-4aa9-bab3-37fc336d8db8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ce8d0f22-d625-47d1-bb00-7b4d61b90561"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cf3c29f9-93e8-423c-958b-055c23a624b4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d13a7534-97ee-4abe-8196-836096101089"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d2e44974-fceb-4d60-9306-fe5fe6034332"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d355d71a-3c5c-484b-ae08-0fbe950c47c2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d61290ed-2b02-4a15-8092-b94309a99fef"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d6962826-a592-464c-8193-07a6c2e70d95"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d7af285c-6643-4497-896f-3a7eed110912"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d97af138-a2ff-4401-a189-d76766e5dd5b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("db257891-c70c-4cf8-b296-bcd02eb97476"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("db6f5b03-9e08-4f25-a436-67c722b49665"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dc9d3bea-7f9e-4943-a0d9-0b66b18b102d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dd4c78e0-3e43-43f4-912d-2e3bdd068ee1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ddc631ec-4b14-4541-9736-3095b5a09b06"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ddfb34da-c99a-4b5a-9697-ef444c332337"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dfab6077-171d-4b37-aad3-74628dd8c8e3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e02707bd-8b59-45f0-8f70-8a24b00a70a3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e34c3965-c81e-45cb-b6d3-c62c76f7e90e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e4ce2ef8-8d45-4fcf-b80f-eac67ac3f277"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e82673da-79ab-4b3e-b031-d601c4a9c235"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e8bff9fc-20a5-4a55-9119-875c6cd33281"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f02a6ddc-4f8e-43aa-8869-d70a3df961b3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f067ef6d-08ef-4f08-adda-363867557a20"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f22010fb-debb-4622-9792-3b542f2c7dc5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f2c3a906-a5aa-4fde-a4e3-4e53da6a831f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f442e4ed-92d2-45cc-acac-973a9a800da2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f50bc9b6-34ef-4f95-84eb-fe8745ffdab1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f66fcf9e-2aef-4d79-9900-cf9f03f6bb33"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fb57367b-0879-43a4-9ae5-80e3731a60f9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ff1cf2c7-c436-4c5b-a75a-7e1c3c42f8d9"));

            migrationBuilder.CreateTable(
                name: "CitizenId",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNumber = table.Column<long>(type: "bigint", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IssuingAuthority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitizenId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CitizenId_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "CarFeatureId", "CarId", "FeatureId" },
                values: new object[,]
                {
                    { new Guid("02d1c5d8-3bca-446a-8b29-b71cec66c997"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("0717788d-ad9f-4da1-ac90-f086033632a7"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("071f67b6-b05b-40df-8d8b-27cb67511c6e"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("088f724a-5c41-4b5f-bb6e-e95d7fdc8cdb"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("094c7af1-2a21-475c-84f8-63bcc41104d4"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("0b546986-a9dc-43fe-91a7-213fd7662e96"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("0b854157-84bb-4860-a4ee-8c1daf602e81"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("0b9d3b94-507e-49a2-8938-f21ed3dab3b6"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("0c5f76c7-918d-4e35-a949-ae1679868f04"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("0d5cd585-5e53-46e7-a2ae-fc8ec8e5847d"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("11b9d952-e30f-420a-973c-f17e70af2939"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("152b9b03-2cbe-41f4-8871-c3e7801aa52a"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("15c9590a-29aa-4d6c-b1aa-becf84ad4e32"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("1794eeac-b89e-41c2-8980-ceb62cc6d232"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("1c3f18d8-2c53-4534-b6b1-703f8846f343"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("1d2be8d5-55a2-4773-8127-6d6af880760e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("1d7bff76-f716-4f73-860c-7c20c0ffd303"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("1e39ac6a-5e44-41c3-9228-c1bcc3e1854b"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("2087eeb2-12ec-48e9-bcfc-3dc83b8c1094"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("21b20f9e-0b1d-497a-88e3-1a1336762966"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("22526126-e52f-407d-ac7f-c195cb740b17"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("2620c897-61de-4af8-b5f6-1511797de8f9"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("2bd4b9ce-b1e4-4b12-b867-1d829646e008"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("2c85af3d-eb79-47a6-b928-21d02a0ffe3e"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("2ce8d972-89fe-405d-ab0a-ad72bebf8de3"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("2d7075cf-cf6a-49d3-a187-6cbd5baa8a92"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("2d904e44-5211-4eb2-bce6-eda35db6775f"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("2e2fd542-3edd-468f-8067-d3a24f5d7154"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("302e5015-ad17-4c03-8a4c-22df30250e61"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("3adb27c3-d2fb-4365-a01e-3146dc31fb25"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("3b458b5a-5ff6-4930-af6c-7c3bbf3cfd94"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("3c05dadc-3a86-4e64-b09b-301392362787"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("42347c16-d043-456a-a963-a6f0b9aaaea8"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("4460c866-52db-4df0-a408-705413f5e0f7"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("4630c437-6b04-4b84-85ae-56a461542f5d"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("4654dceb-9647-49d0-92b6-c80f2bd777cf"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("4a14c972-0638-4fc4-ad8b-3ac66df134ea"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("4c6fb5e7-eba5-4263-98c8-2fc7a6274ff1"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("525458d8-4a53-4619-8329-5fc5e95483a4"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("5397c146-d077-4158-a20f-63f219440409"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("55a4ad47-c263-488f-96df-3df2d445f64c"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("57722619-5a7b-45dd-80a7-7bf72697e99b"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("595a145b-a9d5-42bb-a241-f0af90783419"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("5c824dc0-99f9-48e1-ad6a-1ec8faea5e35"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("5cf8b509-8e1c-415f-b449-349c264daeb3"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("5d9f746b-6296-4fc6-be52-6d5b23927450"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("5e8e6775-cd2a-48e8-96f4-dce405d236d2"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("625e79a8-5f47-4cad-8216-4aa485180c21"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("62f1fe12-61ad-44c7-b5a5-f28653360c47"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("63817a95-2fbd-4612-9d21-a86436920a10"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("64bfc4f1-859f-4b3e-9f84-e08a1591f234"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("6605cdac-697c-4f99-87ce-c505b6a458e7"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("687e4380-a2a4-427c-bfa4-e36e56443047"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("690520ed-7a42-4de6-a8bf-84a48b1b30f4"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("6c43ec7c-6928-491e-ad21-45507fc398aa"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("70ca8ee4-2f8e-4d2d-b4a7-b4fbdaf81e1e"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("71042ccf-7454-4b71-9690-87a5f292a89e"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("711af8de-4560-43c8-b53f-505bb847f5e5"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("715b1d37-0fdf-4a7b-aa4b-9de22eeeff96"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("71d71cd9-78c2-4fe8-8a97-04c54b9985fa"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("71ff0b7e-0b8b-4085-bfde-cdb7a0f1bfc9"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("72feb75c-6aae-46bf-9dd1-54ca87f5a51a"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("758d2ac3-e4e9-4cce-aece-8982eecf1e7e"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("7625d792-b058-4666-9672-4a1c77a06605"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("7749b8c5-4de0-42bb-aec4-a68dfffa6d68"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("77a90f57-07c2-448c-8a29-765eb60cbb06"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("77c07cf1-913d-4ed8-9cf5-eb0d383d4756"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("7d41db48-4da3-4d95-ac9e-ca9b474a29a5"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("81cd5906-fb51-494e-8d80-cdab4510cf50"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("834534a1-7990-4de9-b38f-a14abc47b0c5"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("836709e3-06c1-4ef4-aee3-4b2c65df0c7c"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("83775450-7b30-4be8-85b2-8cef17f5d218"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("8692e14d-dc4d-418d-92e5-20d7dac813d1"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("86b12180-e922-4b60-96ae-5c053ced18a3"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("87f6b7ed-69fa-4721-a6fc-5c76f90a7510"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("8cc8b78d-fc2e-4522-8cb4-90ff1d2751af"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("8e82eecc-4557-4534-b890-118cd2193637"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("8f989c05-588d-42f0-aeb7-69abaf57fa39"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("92bccc97-411a-4c45-8d68-5299e418b9bf"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("93fd7f1f-3692-4a35-af36-7229c031f45f"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("952e47b3-3613-4f40-85a7-10b0cc914af6"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("9630e87e-1c06-43ad-b3ac-13e41a21be6a"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("979ba928-43ab-47b2-9738-4c18d12482d8"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("988494ad-21d0-4826-8592-279116afa67c"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("997d7eee-1ced-4d70-b769-37611a7de255"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("9a150a20-529a-45b3-bb2b-b9ab81f9ec76"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("9bcb0a54-82c4-4e03-9eb9-65d5706bc4a8"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("9c8a3994-fe8b-4d70-99d6-14f88f344e0c"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("9f00a654-b63b-4ba2-81dc-bb7dbe575d4a"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("9fb805b4-517f-404a-b4fd-438f75b20b81"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("a2bad196-eb95-4655-9e4e-d917053310c9"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("a592cda3-15bd-4662-8b77-c8f825b73614"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("aeb08adb-805a-4f4b-b672-dbd12e64f413"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("b0ce87c0-d66c-4ca3-ab60-864c7d96af5d"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("b1a81373-59ad-411a-a5f6-67078c593ad3"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("b22bb99b-178c-4b7c-8531-30ef06ad8ec3"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("b57022d7-4605-450a-b489-ba6373bce6d3"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("b5801cb2-6cdf-4780-b298-bbf58b2d0623"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("b5fec08d-d3ec-4524-8d5d-e3619f0962d1"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("b8a0e081-2e4d-47db-ba5a-80d2818b6a73"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020") },
                    { new Guid("baecc64a-7014-40aa-86f0-72db7bb25dd5"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("bcda52e1-eedd-4cb6-a2d8-7ff91a7350fa"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("bf914ae5-dc05-465b-8899-6d97a8ea8fc9"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("c3523167-dde8-40a7-9ee3-2a4bb3c71ce2"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("c652d8b7-e500-4645-a4c5-03377b2c1d3b"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("c88599ab-f9d7-4009-88af-73dd6b5af74b"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("c8dd1904-fb43-4d9a-96b6-78d301fd45db"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("c910d901-6f48-493b-b20b-e75ee4199a7d"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("cc4ea278-fcbf-43d7-8a27-777cd02de0f9"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("ce1cd354-00cd-4a6a-8c40-9f191988b88c"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("cf17f908-ad2f-4c97-9e1d-eaf9202d01ce"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("cf355ff4-bc6a-4a1d-a51b-b7292e9d2f25"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("d5257a58-7d3a-4877-827e-6869a1aeaf8f"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("d75ef6ac-e7f2-4618-985b-a618fbe6bff7"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("d7656a62-d334-456f-bba9-c9d2ef150d6b"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("d97a21d5-2e39-46d9-9f78-8f3fb790b27a"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("d98a1988-d5e9-4f34-8fa1-aba288d26771"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("d9b15bcb-6b76-4804-9774-7897c85ebe6d"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("db9635a4-5092-49e2-b451-c1a1213bb3cd"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("dbb1981d-5738-4dff-806e-1fd7bcdf7f1e"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("e1659e61-ed2f-4e0e-8a3b-fc1e56a13a1e"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("e16e9291-940c-4142-a45a-85e52ba3e805"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("e31c866f-38c8-4888-a290-f05a98dc9f63"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("e499cdbe-ecae-4630-9864-ebca267e7b52"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("e5a9b3ff-b0bd-4621-af05-c129fd70e533"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("e62d2362-ae3e-4e0d-8ee7-3247e75e1dbd"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("e64935a0-4915-4b00-b7fc-e8f1d8d763a5"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("ea982adb-17e1-401b-a2d6-0f11a0fbf956"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("eda66b00-910a-4daa-83a0-6c238690d2b7"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("ef8c486f-eddc-4cc7-bc04-b752f65f5e26"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("f3870056-8b5d-4c2c-8a4a-fb35490c2dd1"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("f6a575f7-e644-4b22-afbe-6a0be512a69f"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("fac11aa7-25e2-4059-9938-e16460485b64"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("fb758390-3f9d-4077-a5ff-e56748896bc1"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("fbaa7dc7-acb7-4e01-a681-a794dbd867b1"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("fc14a7b6-7fbd-44d0-9a80-a28c6aba5c21"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("ffcbb970-f9fb-4066-9471-aa997c84e5fd"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c30f17dd-7194-41e5-9c5a-b9c08a06f2bd", "AQAAAAIAAYagAAAAEFmLXA5uMy4IkgU5iAcjzZvUq+hUijb7AWEfWNkFhNMr4kSZ3C3gIrB/TjFZBFzrwQ==", "59d2e7f1-c3ca-430b-be42-ddc80b96c5cb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eeb216f4-8866-4a45-901e-19813f8105d0", "AQAAAAIAAYagAAAAECqyn6nRv4byW8c4E3KZqF7467aJoPfsvMwQlwwHFSMiouwqJqfj99PKoGFmYVeggw==", "263ef959-6ae6-4c28-ae96-a062181e596f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "772aa7f0-be25-406f-b98c-4cbce8748130", "AQAAAAIAAYagAAAAEGCMU6/LspQ3uy1cNPskCZDav5vMgL8mX31JBSMFy81OI5Aot5hOA3kk8o+jcFdQjA==", "d0c0390d-69d0-4d27-8c88-a80ed329587f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a60fe299-8d51-48a6-a5ca-fdd626e90e32", "AQAAAAIAAYagAAAAEPpgTm1IY0C4IVZgalRHJL8dXAOxWwjPLFaAqgeNuVqevqAUdEZluvfQBAWbrCwZQA==", "3d1a093e-61f1-4349-ac06-06358c73d888" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16e97c4d-5b63-40f7-8e69-2f7981082a34", "AQAAAAIAAYagAAAAEL2NRFjJDB9akEV05smQUCEe4e+7SQC/ZmZj7uKujGZ+WA6SJ+88zKw3csgxne0jcw==", "48788e23-ca07-472c-89a7-c4279b10cfb5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35baf616-5cde-4959-906a-aee29c2dec14", "AQAAAAIAAYagAAAAEPgGQW4EhYcgLWCQ8mOY7mJI8577IshJ/lWp6al9wXk7Gas/NBy5Rn6MDJcUQtvmww==", "a29ba478-0302-4b94-934a-d3902b1420ad" });

            migrationBuilder.CreateIndex(
                name: "IX_CitizenId_UserId",
                table: "CitizenId",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitizenId");

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("02d1c5d8-3bca-446a-8b29-b71cec66c997"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0717788d-ad9f-4da1-ac90-f086033632a7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("071f67b6-b05b-40df-8d8b-27cb67511c6e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("088f724a-5c41-4b5f-bb6e-e95d7fdc8cdb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("094c7af1-2a21-475c-84f8-63bcc41104d4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0b546986-a9dc-43fe-91a7-213fd7662e96"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0b854157-84bb-4860-a4ee-8c1daf602e81"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0b9d3b94-507e-49a2-8938-f21ed3dab3b6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0c5f76c7-918d-4e35-a949-ae1679868f04"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0d5cd585-5e53-46e7-a2ae-fc8ec8e5847d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("11b9d952-e30f-420a-973c-f17e70af2939"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("152b9b03-2cbe-41f4-8871-c3e7801aa52a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("15c9590a-29aa-4d6c-b1aa-becf84ad4e32"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1794eeac-b89e-41c2-8980-ceb62cc6d232"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1c3f18d8-2c53-4534-b6b1-703f8846f343"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1d2be8d5-55a2-4773-8127-6d6af880760e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1d7bff76-f716-4f73-860c-7c20c0ffd303"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1e39ac6a-5e44-41c3-9228-c1bcc3e1854b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2087eeb2-12ec-48e9-bcfc-3dc83b8c1094"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("21b20f9e-0b1d-497a-88e3-1a1336762966"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("22526126-e52f-407d-ac7f-c195cb740b17"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2620c897-61de-4af8-b5f6-1511797de8f9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2bd4b9ce-b1e4-4b12-b867-1d829646e008"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2c85af3d-eb79-47a6-b928-21d02a0ffe3e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2ce8d972-89fe-405d-ab0a-ad72bebf8de3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2d7075cf-cf6a-49d3-a187-6cbd5baa8a92"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2d904e44-5211-4eb2-bce6-eda35db6775f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2e2fd542-3edd-468f-8067-d3a24f5d7154"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("302e5015-ad17-4c03-8a4c-22df30250e61"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3adb27c3-d2fb-4365-a01e-3146dc31fb25"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3b458b5a-5ff6-4930-af6c-7c3bbf3cfd94"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3c05dadc-3a86-4e64-b09b-301392362787"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("42347c16-d043-456a-a963-a6f0b9aaaea8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4460c866-52db-4df0-a408-705413f5e0f7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4630c437-6b04-4b84-85ae-56a461542f5d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4654dceb-9647-49d0-92b6-c80f2bd777cf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4a14c972-0638-4fc4-ad8b-3ac66df134ea"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4c6fb5e7-eba5-4263-98c8-2fc7a6274ff1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("525458d8-4a53-4619-8329-5fc5e95483a4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5397c146-d077-4158-a20f-63f219440409"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("55a4ad47-c263-488f-96df-3df2d445f64c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("57722619-5a7b-45dd-80a7-7bf72697e99b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("595a145b-a9d5-42bb-a241-f0af90783419"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5c824dc0-99f9-48e1-ad6a-1ec8faea5e35"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5cf8b509-8e1c-415f-b449-349c264daeb3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5d9f746b-6296-4fc6-be52-6d5b23927450"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5e8e6775-cd2a-48e8-96f4-dce405d236d2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("625e79a8-5f47-4cad-8216-4aa485180c21"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("62f1fe12-61ad-44c7-b5a5-f28653360c47"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("63817a95-2fbd-4612-9d21-a86436920a10"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("64bfc4f1-859f-4b3e-9f84-e08a1591f234"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6605cdac-697c-4f99-87ce-c505b6a458e7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("687e4380-a2a4-427c-bfa4-e36e56443047"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("690520ed-7a42-4de6-a8bf-84a48b1b30f4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6c43ec7c-6928-491e-ad21-45507fc398aa"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("70ca8ee4-2f8e-4d2d-b4a7-b4fbdaf81e1e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("71042ccf-7454-4b71-9690-87a5f292a89e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("711af8de-4560-43c8-b53f-505bb847f5e5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("715b1d37-0fdf-4a7b-aa4b-9de22eeeff96"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("71d71cd9-78c2-4fe8-8a97-04c54b9985fa"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("71ff0b7e-0b8b-4085-bfde-cdb7a0f1bfc9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("72feb75c-6aae-46bf-9dd1-54ca87f5a51a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("758d2ac3-e4e9-4cce-aece-8982eecf1e7e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7625d792-b058-4666-9672-4a1c77a06605"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7749b8c5-4de0-42bb-aec4-a68dfffa6d68"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("77a90f57-07c2-448c-8a29-765eb60cbb06"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("77c07cf1-913d-4ed8-9cf5-eb0d383d4756"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7d41db48-4da3-4d95-ac9e-ca9b474a29a5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("81cd5906-fb51-494e-8d80-cdab4510cf50"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("834534a1-7990-4de9-b38f-a14abc47b0c5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("836709e3-06c1-4ef4-aee3-4b2c65df0c7c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("83775450-7b30-4be8-85b2-8cef17f5d218"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8692e14d-dc4d-418d-92e5-20d7dac813d1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("86b12180-e922-4b60-96ae-5c053ced18a3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("87f6b7ed-69fa-4721-a6fc-5c76f90a7510"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8cc8b78d-fc2e-4522-8cb4-90ff1d2751af"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8e82eecc-4557-4534-b890-118cd2193637"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8f989c05-588d-42f0-aeb7-69abaf57fa39"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("92bccc97-411a-4c45-8d68-5299e418b9bf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("93fd7f1f-3692-4a35-af36-7229c031f45f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("952e47b3-3613-4f40-85a7-10b0cc914af6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9630e87e-1c06-43ad-b3ac-13e41a21be6a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("979ba928-43ab-47b2-9738-4c18d12482d8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("988494ad-21d0-4826-8592-279116afa67c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("997d7eee-1ced-4d70-b769-37611a7de255"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9a150a20-529a-45b3-bb2b-b9ab81f9ec76"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9bcb0a54-82c4-4e03-9eb9-65d5706bc4a8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9c8a3994-fe8b-4d70-99d6-14f88f344e0c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9f00a654-b63b-4ba2-81dc-bb7dbe575d4a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9fb805b4-517f-404a-b4fd-438f75b20b81"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a2bad196-eb95-4655-9e4e-d917053310c9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a592cda3-15bd-4662-8b77-c8f825b73614"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("aeb08adb-805a-4f4b-b672-dbd12e64f413"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b0ce87c0-d66c-4ca3-ab60-864c7d96af5d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b1a81373-59ad-411a-a5f6-67078c593ad3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b22bb99b-178c-4b7c-8531-30ef06ad8ec3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b57022d7-4605-450a-b489-ba6373bce6d3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b5801cb2-6cdf-4780-b298-bbf58b2d0623"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b5fec08d-d3ec-4524-8d5d-e3619f0962d1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b8a0e081-2e4d-47db-ba5a-80d2818b6a73"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("baecc64a-7014-40aa-86f0-72db7bb25dd5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bcda52e1-eedd-4cb6-a2d8-7ff91a7350fa"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bf914ae5-dc05-465b-8899-6d97a8ea8fc9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c3523167-dde8-40a7-9ee3-2a4bb3c71ce2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c652d8b7-e500-4645-a4c5-03377b2c1d3b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c88599ab-f9d7-4009-88af-73dd6b5af74b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c8dd1904-fb43-4d9a-96b6-78d301fd45db"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c910d901-6f48-493b-b20b-e75ee4199a7d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cc4ea278-fcbf-43d7-8a27-777cd02de0f9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ce1cd354-00cd-4a6a-8c40-9f191988b88c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cf17f908-ad2f-4c97-9e1d-eaf9202d01ce"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cf355ff4-bc6a-4a1d-a51b-b7292e9d2f25"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d5257a58-7d3a-4877-827e-6869a1aeaf8f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d75ef6ac-e7f2-4618-985b-a618fbe6bff7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d7656a62-d334-456f-bba9-c9d2ef150d6b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d97a21d5-2e39-46d9-9f78-8f3fb790b27a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d98a1988-d5e9-4f34-8fa1-aba288d26771"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d9b15bcb-6b76-4804-9774-7897c85ebe6d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("db9635a4-5092-49e2-b451-c1a1213bb3cd"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dbb1981d-5738-4dff-806e-1fd7bcdf7f1e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e1659e61-ed2f-4e0e-8a3b-fc1e56a13a1e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e16e9291-940c-4142-a45a-85e52ba3e805"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e31c866f-38c8-4888-a290-f05a98dc9f63"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e499cdbe-ecae-4630-9864-ebca267e7b52"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e5a9b3ff-b0bd-4621-af05-c129fd70e533"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e62d2362-ae3e-4e0d-8ee7-3247e75e1dbd"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e64935a0-4915-4b00-b7fc-e8f1d8d763a5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ea982adb-17e1-401b-a2d6-0f11a0fbf956"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("eda66b00-910a-4daa-83a0-6c238690d2b7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ef8c486f-eddc-4cc7-bc04-b752f65f5e26"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f3870056-8b5d-4c2c-8a4a-fb35490c2dd1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f6a575f7-e644-4b22-afbe-6a0be512a69f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fac11aa7-25e2-4059-9938-e16460485b64"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fb758390-3f9d-4077-a5ff-e56748896bc1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fbaa7dc7-acb7-4e01-a681-a794dbd867b1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fc14a7b6-7fbd-44d0-9a80-a28c6aba5c21"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ffcbb970-f9fb-4066-9471-aa997c84e5fd"));

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "CarFeatureId", "CarId", "FeatureId" },
                values: new object[,]
                {
                    { new Guid("001a77a1-68c3-40e1-ae40-6843f2ef5c13"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("006d49ad-8b25-4fda-8337-a1ee3a26c4f6"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("02366382-b0e7-4df9-99d5-ef405a9f2da6"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("024fa323-70dd-48d2-9226-e43e95ab281c"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("03200848-b79e-47c6-865e-5034a3f83629"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("041a5430-0ab1-4029-95bf-0a948e76afe3"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("04231212-0b39-40af-b875-a331c5af4e15"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("07937bfa-5b71-4c71-bcc5-01bc31d3c3e4"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("0b1c0d83-0850-4689-866c-4ef2aafdb489"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("0b490a54-0229-4d2e-882f-1e2ee985c2de"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("1106baff-beda-4188-ae8c-0dc69dc34c8b"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("12c3a376-6b41-4f8e-8acc-1fb8b118bdec"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("1d6122ec-f8ac-44d0-a905-75cbfd1d59fe"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("1f92ef78-db34-4687-baca-8b17f498234f"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("209ff72b-a039-4fe6-a09c-bb7105f5716e"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("277dfd02-6417-4740-889e-002f86f96768"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("28464ba5-0bce-4006-8f21-a32ef2d57df6"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("2941e3da-e3b2-476a-ba3d-9126681dacdc"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("29f7a6c1-0e5d-4e08-90ee-b5cf8bb6387f"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("2b8d386b-d677-4a24-a00f-c036973fc742"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("2d95ef02-cfec-470d-940a-9b2610cb3914"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("2e9331a3-4d6c-4c15-a382-e157390b4bdc"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("2f5bad5e-9b35-4ff6-90e4-fb4e111d3e55"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("30705150-48d4-4dbf-9e98-95677f272ffc"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("32b15407-7717-4820-be72-4901b18d5639"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("330cdc34-4696-43c0-be51-913965ec24b6"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("35695d00-9860-4c95-9f68-630f824c1d44"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("35754045-5960-4f87-931c-0401099a3f34"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("362ffbf1-cc73-4303-9391-9c5523b0e084"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("3675cb0a-acac-431a-9b69-c6415b6e0d76"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("38f76431-2978-423b-bb0f-9df36483a26c"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("39058134-8c30-4658-a8dc-eed23363c400"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("3a4be102-7711-4f96-a4b8-a0025a882512"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("3b58ed28-b4d5-4546-8d7c-dee38011fa0d"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("3bd9785c-86f0-459d-bc99-5ee0e8b4e0e7"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("4309742e-0097-4589-9847-4d1057043ccf"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("43a9f8c5-283a-4e91-b6bb-2b63575f9289"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("44193320-c40c-4625-a7b5-1f098852eb9b"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("48913691-9f79-4122-9182-06a22492bacc"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("48c7fe25-5b91-4c0f-8d75-bef731b6f6a8"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("48e115d2-314c-48df-83df-ad4a479b9816"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("4a822cea-085e-41b2-95dd-edf97785008c"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("4e8e3231-0e95-4c3b-aeb6-ba78ce65d647"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("506606bc-f9c3-475b-9d47-9511200a3e4d"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("52f246dc-2b0d-4e06-a11a-c3ceccc3c847"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("554d4832-543b-4397-8b55-0e4063837f76"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("5581d4d4-5faa-49ef-92d7-925e5a1822b9"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("570312d4-c642-4f39-922b-677295120212"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("5d649b25-9b24-4017-bdcb-11d451a675e3"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("60b528ba-25c0-4b68-8861-c1854164881f"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("60ef0b7b-ac78-4d5e-846d-25c63b08ed71"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("66ffe4b4-9497-4348-a7cf-c8215e75e168"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("6e112be1-ae63-4005-93cc-a0268d08e147"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("6e5e7bb0-0f91-4c5c-b41a-e2e5711a3772"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("70a4940f-7b9f-4ddc-86d6-bbfcee3e33ae"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("742bb51a-e5c1-4fae-aa81-11ab03760f65"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("750328fc-10a7-4db2-bdd1-0d27c3c98dbd"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("75514162-2405-4a0c-acb3-ec26572d1ffe"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("7551551a-3dfb-4786-af52-dbd1ca764c23"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("759536f6-60fd-4b99-ac72-739c9f6a9f46"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("75bb62d1-3ba0-4147-8beb-769881239291"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020") },
                    { new Guid("78dbd2fd-3d5a-4d3c-a973-fe9eb0c243be"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("7bca4c3f-3ae6-4463-8f6e-5ee998b1a563"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("7cfaee2b-5218-47ee-92dc-683880437578"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("7dcf2668-4fa8-4d0a-965c-ade7b96403fe"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("813fe3ea-bf2d-4918-a3a3-af7276811794"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("81e85fca-9323-4326-9376-4c59e5dfe13a"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("83e8bf8a-e7d5-4f49-8d35-924828fa8638"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("8417d3b5-8689-4904-a996-619c70281529"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("85ba2db2-2cc6-44e8-ac32-bf845fb419b4"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("872f4642-8ac7-4994-b348-bb6186f54d60"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("882a09fa-967e-45e9-b605-232d7039f649"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("8c60b5ec-b32a-490c-9077-466f35338feb"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("8cbc1836-e13e-4127-80f5-9b810de44e3b"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("8d7152d9-80bb-48c0-b0ec-39f791c433f2"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("8ef89c81-ca67-42cf-a6aa-5070c1f916ef"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("909ba2b6-0fda-46c5-9385-89b2ba9cca4b"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("9308aefd-bb13-421b-b365-00ff63f84a51"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("94e7924d-d184-4171-a51f-7ec7b5adfe51"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("955defc7-8778-422e-bd03-f325f41a823e"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("97acf358-8dfd-407a-9457-596056bd1110"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("97cba00b-8413-4e20-8cf3-1a6c3fb7c7b5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("9af918ec-b56f-45a9-a4ad-172092962035"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("9d71a53b-cc2f-44fd-8ef1-58b159c10f41"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("9d98891d-25c3-42c9-a16e-51572a0b0ca8"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("9f321621-f97b-4cf5-95d5-e06effe6b99c"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("9ff2535b-aa0d-4ed0-90cc-367a659e7813"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("a4aff71f-56af-4334-886a-c5a06f8f3df9"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("a547774d-44ac-42ae-aa06-13ff1afdf348"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("a6fc689a-f889-4315-ac26-5171c257cb85"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("a8d6e5d4-1142-444f-85fd-af0d2200f298"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("b1200146-f389-4fda-8075-93b08b724cc2"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("b2652037-df61-4848-a1dd-54ed21ef1820"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("b4033fb8-5eaa-49e9-8dc7-b3233093d8f9"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("b5dc5d53-053c-46d6-a012-4a35550ecd00"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("b85ce19b-d968-4af9-9fcb-115d889e777c"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("b8eb8540-9dda-49ee-ba96-9ed0cbe41d51"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("b8f87523-86bf-4f50-863d-846fba6c4cc4"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("b90acbec-533d-4021-882f-a9e35976aa75"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("bdf3dd85-5f98-4b06-890d-d8eae9ca4c2d"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("bf88c96a-cbbd-4189-b602-82935989e91f"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("c0458cf5-d042-43a0-af4f-3acdd35a51e8"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("c245df00-c68e-4042-a48c-c165ab2d5faf"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("c99b4ae2-7645-4f12-afd7-3ccb60d3f5f8"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("c9c53606-256a-41be-bf63-d83d4ac53bc5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("cc98239a-dddb-4b2b-888c-20c13c36d99d"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("cdb064e3-c3fd-4aa9-bab3-37fc336d8db8"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("ce8d0f22-d625-47d1-bb00-7b4d61b90561"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("cf3c29f9-93e8-423c-958b-055c23a624b4"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("d13a7534-97ee-4abe-8196-836096101089"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("d2e44974-fceb-4d60-9306-fe5fe6034332"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("d355d71a-3c5c-484b-ae08-0fbe950c47c2"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("d61290ed-2b02-4a15-8092-b94309a99fef"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("d6962826-a592-464c-8193-07a6c2e70d95"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("d7af285c-6643-4497-896f-3a7eed110912"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("d97af138-a2ff-4401-a189-d76766e5dd5b"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("db257891-c70c-4cf8-b296-bcd02eb97476"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("db6f5b03-9e08-4f25-a436-67c722b49665"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("dc9d3bea-7f9e-4943-a0d9-0b66b18b102d"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("dd4c78e0-3e43-43f4-912d-2e3bdd068ee1"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("ddc631ec-4b14-4541-9736-3095b5a09b06"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("ddfb34da-c99a-4b5a-9697-ef444c332337"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("dfab6077-171d-4b37-aad3-74628dd8c8e3"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("e02707bd-8b59-45f0-8f70-8a24b00a70a3"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("e34c3965-c81e-45cb-b6d3-c62c76f7e90e"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("e4ce2ef8-8d45-4fcf-b80f-eac67ac3f277"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("e82673da-79ab-4b3e-b031-d601c4a9c235"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("e8bff9fc-20a5-4a55-9119-875c6cd33281"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("f02a6ddc-4f8e-43aa-8869-d70a3df961b3"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("f067ef6d-08ef-4f08-adda-363867557a20"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("f22010fb-debb-4622-9792-3b542f2c7dc5"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("f2c3a906-a5aa-4fde-a4e3-4e53da6a831f"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("f442e4ed-92d2-45cc-acac-973a9a800da2"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("f50bc9b6-34ef-4f95-84eb-fe8745ffdab1"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("f66fcf9e-2aef-4d79-9900-cf9f03f6bb33"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("fb57367b-0879-43a4-9ae5-80e3731a60f9"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("ff1cf2c7-c436-4c5b-a75a-7e1c3c42f8d9"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0aa522b0-03e0-448e-bc8d-c6f99b3b149c", "AQAAAAIAAYagAAAAECB/jDzdsnaDl/xbWzTBtnX261IMvUTnipeJv21qfY9bA+bMCUJ+uBiZ0jXnhK82/g==", "9645f1ec-ddf6-42ba-960f-c0d0e7a030f6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1099de9-0d5c-412e-9c02-1bc2bbc469c5", "AQAAAAIAAYagAAAAEFyOfG9sGC14xO/d7UK6nAze7gShMegkQBgwoy1z+/f6/BnOnVP4b+/kf2BpRFkzaw==", "f205ec0a-3b1b-4149-9af2-388289c7ff2a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f722db3d-78f8-4832-b1b5-b218a29f4352", "AQAAAAIAAYagAAAAEJBeP2hqW36gvXycE4VahUjwNdJdZHy9ShL88R+LDsJtCo5N+UxR43Jf0+PJ7OyJLg==", "cca4adf1-d322-4ce4-bf53-8e02dcd40f84" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "706b5938-560f-4429-a4cf-e2535b23d569", "AQAAAAIAAYagAAAAEMyG+8zstOxxE9jHFoNGNhTgDpxCDZJ+c1zOlM8butz8EfJ8v0X0GSe4iRsymdqzww==", "757f0993-a76d-4b5c-8cce-ccd9418d23e5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29e075eb-ae87-44c2-a8be-dc36ddb71843", "AQAAAAIAAYagAAAAEAj/TD80RO35N3fCq+lnhCUaqw/Ygk/qoE/BBrrodb/WTPRKLNGTiXW96Z8UrFHY6g==", "a52912fb-f21d-4ceb-8db5-29109241a646" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7dbea50-8398-4e3a-a346-b76817995a50", "AQAAAAIAAYagAAAAEHd5aDrZj2E4iz8tpkqbkoA58HQp2DWxkFgqwUDm8VD0VK2Q9YhZ03Mm7lP1GMQ6SA==", "e0fd8533-274c-4441-9dd3-9438de7b55ac" });
        }
    }
}
