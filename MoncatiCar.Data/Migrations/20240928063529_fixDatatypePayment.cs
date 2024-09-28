using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixDatatypePayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0013b730-5906-445e-9336-5c0c692b6b63"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("008adafc-32f3-4e2f-9efa-779aba503d65"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("031cb08f-3b00-4939-9f83-aaee436ac899"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("06e25b63-8b35-4518-b821-0e0c458dd264"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("08211877-3799-43fb-b628-711388a2c964"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0a732f17-09d8-4d5b-9256-5267cc6108a9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0debc081-5525-4bcd-83de-00fe9c4532d9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1118aa6e-498a-4fd5-8ba5-3cc28d96442a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("126e23df-b94c-4a29-ac37-10791f65b1bb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("13b61734-d2de-4ca4-8962-dd8f9863c4f2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("16ccc515-14ac-4f39-9989-66eccb86dd55"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("17fb2002-0640-474f-86f0-2d572c559d17"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1a47526b-d398-42fd-942b-7f1bdd69f27e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1a708b24-a6f1-4daf-88f0-a3e393e316f6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1a926c3d-f642-4a34-8a82-0ba872ea4361"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1aa57dc7-7263-47da-8412-6cefc31d06d1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1b05d6da-f6be-46c4-a43f-cf53f850ec54"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1de39b14-eb72-422e-bd4a-3d3f052d275d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("20c72af5-9f84-44c3-b1d9-b93e8ba82a67"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("231925b9-8269-4e94-8dc6-d8464bde5c59"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2396327d-bff6-4959-86cf-1879b4a9cb33"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("24ac69e6-684e-4bfc-989b-993b22bd9208"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2749a3bd-4182-421e-8992-f887dbb593f0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("27ccb8ee-4728-4d68-9c8b-d09d2ae55be5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2b5ac5c0-50bb-41bc-840a-e756e35eaf22"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2c41778c-789c-4faa-8a9c-4659e6489b4c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2cc22b56-f130-4752-a092-7b98e426e37d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2da7d643-fec9-46b8-9b3f-4ea4c7e50b17"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2dfe6577-85f3-487b-84d2-3d32eb781f23"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("318cb6cb-e220-4d75-a113-6569501eac48"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("32082dcd-7818-459a-9224-7280a8c0f062"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("35c9b5a6-c57f-4a36-adaa-21eaf9014ba7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3bfe8be0-1053-4602-b239-5522f22a385d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("407af8d8-15fd-4c9e-b6eb-849cd7c40e55"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4092bcaa-6345-4c0d-bce9-79cca6e65aed"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("40a887e0-155d-4ebb-a8b1-668712535b81"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("42776e30-893b-4c95-a9f7-56132032a3f7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4326c9a5-3ffe-497b-bcdf-691fe0519b3c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("437e1674-0257-4272-b881-85ec99c09f0e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("45a30d58-10f9-448a-bb91-4b4f2d3b2874"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("45ba1d12-6998-4075-8f22-7f975ba3bc9d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("48108e3d-cf61-47d3-9468-2b55aa0bf613"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4fa048f4-4226-46e2-9e4c-477a88240431"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("52a6d410-f588-413e-b8f2-2d66fee6b418"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("52f9e1e5-dbd9-4e8f-8f1e-9172179f6916"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("540ed9c5-338c-47d1-9d0d-933d232f4d99"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("559063ad-16ff-482a-a92e-e975d9f3391d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("55e4e16b-3b82-4f26-8545-7586c476c4f2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5c2c08c8-087a-497e-81cd-7d5b217412e1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("600b1072-2c04-4cb1-865a-b9dee0d42fe9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("62dba91e-d871-47c1-8559-d249ec3f0258"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("65fc2f80-b9b6-44c2-83d7-e8c0a35e3f96"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("67dcbcd7-0351-48ba-8c98-f620a16e03cf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6d580559-ccb7-401b-90e2-65b1779ee0f1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6eff74b6-919a-45c7-8e8c-fd87e9dccfb3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("71453acd-1a4e-4e00-b91b-3b903bde9515"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("732f3abb-69b0-4f84-b4f9-69d747102fe4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("74938205-a9c7-49d4-9231-bac997f2bc09"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("75204c98-768d-4ddf-8b46-c865280ea537"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("758e8d8f-2407-4084-8b6a-c8f69963cce0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("76b7efd1-ce57-46ae-ae5a-a2dcfda1ecdf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("77adff89-397f-4de1-a6b6-e9a343c47511"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("787d8bd0-683e-45ea-81ad-071b237a7403"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("796c02dd-9e74-4ac4-aca5-8fb99ce5ecc3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7cbad71a-9a5a-4378-819b-dc47d1f671af"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7cd720dc-586e-4009-9c34-be7ffab84898"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7cd7cdb0-39ec-40ba-8235-9ecd232ec121"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7f92fdfc-0a0b-4454-932e-b1d0fd891551"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8224c600-8227-4439-92fc-6aa9f5d790cb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("82cbbe43-c1d1-4275-bb13-0b105eecbbc7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8634b880-6065-4958-b47c-665637187a50"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("876706c5-1e45-43c5-88d0-7e2bc30ea2c7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8d71b628-456f-4c92-91d1-a21c4d1ea5c1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("90576818-fbd9-47e7-afb6-79b3c82daf78"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("92015012-6f85-451a-a68f-6854a456aa63"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("948c96e2-997e-4c43-85d5-495229105290"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("95d94047-c654-4028-8e88-ce1b1db475cb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("989e9404-6ac1-416a-8be8-ad830635002f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9aa68555-1b53-4af7-80e3-fcbe48da5ab3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9b42df51-14d7-442f-a4fb-cffd1f7fa413"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9bc45055-c443-4565-8c2f-07ada925fc9c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9e7fa954-d774-4506-93c0-427903bcdd89"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9f47d9dc-695f-4ba5-b9c4-502d98d7b2c0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9f7ce449-50db-4c0e-bdb0-3ef51a454b70"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a4d5268b-2e2e-488b-ac97-29a21281799f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a5b2e8e4-0092-4d7e-92ac-5db963bc54e8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a63a023a-12a9-4006-bbed-1622a9877937"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a6e58bcc-875e-4604-aa7b-75ae800d0db6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("aa4cd134-2504-45ad-aeeb-f191a7bd876a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("abad8270-f275-4b19-bf82-483d0d118ba0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ad0908fc-04d4-477d-aced-2d4f6d98adbe"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b1fa6e25-6a1e-4478-95a7-34a0cc2d2ee8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b5f48e46-f724-4720-b0a1-4690114f6da2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b6be7ff2-f62e-481a-9523-ba366ca0bcec"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b73158c5-d1b0-482f-ba89-d87f0f3c6f4e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b88c4958-622d-46cc-8575-7183949f4099"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bb817893-2a07-419c-abe4-35f801d7b7fc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bc81f91a-2d60-499d-80a6-df8a31a87877"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bd88ec4c-ba23-4e4a-b162-62ad2374eaf8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bdecbb71-4065-4cc8-8dd8-0c521d78dfe2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("be35035d-61aa-47dc-8273-fe4ba3aee3a9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bec48cf6-7432-42f1-b203-9dbe5f0fcb29"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c061896c-fad8-4781-8493-8ec7f024391c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c0ad37bc-3386-4dee-b3a6-0d48f64e5d29"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c2a9cb39-d6bd-4018-a247-05dbdb016ec9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c2b0d65d-8485-4abe-9b03-9466d1a64945"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c474c443-c7f7-438b-89a3-0aa699da4e3b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c4838033-c49a-4806-91a0-2081dd507a9f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c58844a9-c21e-4e19-8592-fe753c876fd0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c9a966ca-91cf-439f-9edf-e66733341ccf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ca2015ca-17cb-40eb-a62b-d42fbcb5242b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cab6b2ce-ed1c-4b6c-b3b7-64152a8b24df"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("caf48dba-8f6b-4e24-bdb4-70053367b52f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cb7029ce-d813-4708-9cc8-697b12b88f74"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ccd11857-4c49-40ec-b90a-42e141124e5c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ccee10b9-4868-418e-a6e3-f717277a2f0d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cd3da23b-08ed-45f4-ae39-1c00417f5b51"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d31ab33e-1aaf-4add-a224-6359200f8295"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d3581b5e-e509-4861-af7c-d747fce0463e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d5160027-350e-4a5b-ad85-2ae77c4e6751"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d53c36a0-e37a-497d-81d3-711bb327550d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d8eb1c60-8d61-4355-9140-2bace4b408e5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d9123b5c-b0aa-4fab-bc11-e3b3b475e18a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dc906269-7dcd-414a-a612-448c7de11dcb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e496b38f-5f0a-445d-8786-90b1d291c8a4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e5892be4-8045-4096-b6b3-2c5624e4b84e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e7f72f12-3f23-4915-a6ba-2db7b84ac300"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e8e46216-568d-4e1b-86c4-b37459f62436"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ea357dbf-025c-405c-9202-200ad2314c6b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ed83a79e-4a49-4dde-9d31-53d59aa40512"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f0f2df36-abb1-498a-a6eb-35b819777cad"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f273059f-5c7d-4544-8783-e31664391a82"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f5b5bc0a-342d-4b3a-8e5e-366d012cddb4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f639eb9d-7f07-4b7e-a3ec-ea8583da8082"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f7e3b3b2-7535-4546-bf44-8a0b70b56a54"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f85a4058-ed24-4cbe-a394-145499a2b016"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fac56561-a078-4d6c-b680-6263cd080079"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Payments",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "CarFeatureId", "CarId", "FeatureId" },
                values: new object[,]
                {
                    { new Guid("00bfd4ce-56d5-4e38-bc90-100fbeaab09e"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("0375de02-5e00-4534-a116-2ffb0f66b8a7"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("037a2fac-5121-467e-a1fa-02b90afc9249"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("07825236-e5e3-4e5f-88c1-c8bf17a85b7b"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("07cc12ad-e1bc-448b-9554-143337884b77"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("0efedc5f-97a0-4f88-97c1-954cbf16db52"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("10a45682-0147-4b81-82ad-06fda74133c7"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("10dd3efc-763f-406c-a4ac-cd61198dd1bb"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("11e62e0c-ed3f-419a-bfc8-29c3849cb0bd"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("1421a615-d9d3-4fde-9ff7-995bc7befc35"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("14dadd03-682b-45bf-8091-67bce40a8a35"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("173ae4a2-52a7-44a5-a740-fe4968819b13"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("17ad3c3f-f2ea-4ebf-a836-ebd00e4f0bdc"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("1909039e-e88f-43c9-9a4b-aaf379e13e7d"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("1a6c9cbb-1773-4d77-923f-87edde1bfb2d"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("1e9ba009-4947-4282-ab33-043f076cffe5"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("1eec48f3-87f2-4975-b312-600ce2855360"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("2745fb64-2ae3-4571-ac3a-c87c48818993"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("28a80e83-b133-476a-bf9f-15ef6fc5fdbd"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("2a2ab091-03b8-45d0-8af9-009c5947f057"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("2c2ea5ca-1fb6-4267-963d-668490e66e78"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("2c92c83d-6e46-48d8-9113-32c6a55028b7"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("2d847ea6-27e0-4f1e-bf8b-062e2cc2dfb5"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("3a3c563e-2118-4fa2-80a4-f4b621435c58"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("3abed12a-3b44-43d9-9266-80c8bdb5ea84"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("3bac04e5-881c-4d07-8376-fa6c1c768228"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("3e60f32f-0686-435b-8087-16d4ba94b135"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("4529be96-97d1-4242-a203-b1abe89a8508"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("4600bdb4-e5d4-4bd0-bbd6-841c5a627caf"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("46f0871d-faba-49ad-9df0-749030804888"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("48715e55-e57c-4bb0-bf32-024293fb7542"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("49239e13-1230-4985-8160-92a1d2404e9c"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("493a42e3-1068-4066-ac6f-73d10e87fdf9"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("4a16ab71-12c9-46f4-8bea-a01f84784d22"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("4a44330d-18d8-4e9d-b11c-d67d828bd861"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("4c3d6e56-63a1-45da-9dbc-b59fca54bebd"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("4c7024f5-56d4-427a-a650-78c9ad8b5688"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("4d2886ae-88be-46a9-9e70-3724afec100f"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("4d411038-f929-4aab-ac17-7904db8b058c"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("530e0864-8e85-4cbc-b19e-3a0919193426"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("578b4ca9-6a57-4dcf-ac9c-aa24ba18cfea"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("5ded85e3-f368-49cd-a7db-dd53d0e0a7e8"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("5ed7c33b-ddf7-48e5-a39a-4b1430f50d13"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("5fdb1919-c5ed-41e3-8308-3546d2f09787"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("61ce7761-453f-4e4d-9aea-7566f147780e"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("63937f76-af03-460a-be68-bc01c9291874"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("642b0095-04dc-4429-8eb3-2a2f4208ff90"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("65324fc0-ac81-4505-bc6a-545671aae6a7"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("685f286d-ca93-43a1-868b-c31b4fa09946"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("69ff8ef0-8a87-46f3-b61d-9c0294919067"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("6b36b52a-3e8c-491a-9067-2d9bdd2cd43d"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("6d809fc7-ac3d-4959-b182-07f08983ed0d"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("6e6474c4-2ed7-4c02-aaa7-724ae7506a2e"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("73c5fd3a-fa3c-48e6-bd9b-5d1bb198892a"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("758fa33a-8b4e-4944-9eda-5bbe644bb946"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("77d73930-777e-44d1-8df7-2b2576336072"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("78ed62f1-5967-40ea-9758-0d343e7207a3"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("79260d94-6174-43b3-8ccf-973e720582aa"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("7ee19ae4-0944-4682-8778-31179c32389d"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("80c979d8-4e82-4cef-b94b-2fb1ec1de851"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("81352242-eed0-44b8-a88f-e3da8cb59af4"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("82c42e0a-63ca-4041-9ebd-2eca1380beee"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("8466d70a-bdaf-45cd-9e29-cc53514209c5"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("85ed278b-32a8-424b-97e2-2b2e6c40e63f"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("86680a7a-5139-4b47-bdac-21a35d4bb298"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("86bbcf1c-32bc-4f4a-99f8-b32adde6bb3b"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("88aaff30-9bd4-4047-bb4f-e3ab72a7f17e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("895aef36-9f37-4432-b47e-006675d38f06"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("897845b4-c6ea-481e-99e4-e3bddceccac1"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("8a4ed417-ec6e-406f-a8b5-140b23582fa8"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("8baf6f7e-7935-44e9-98df-9c9bee87e355"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("8ca0a7f9-8be3-475d-b6bc-f0c37823a97f"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("8e3f9550-9e3d-4c57-974e-482d650c4397"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("90f4e34a-a0d8-4f40-97ed-faabf409def7"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("9211c634-4632-40af-81e7-152351319661"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("9295e3ce-e16f-480d-99c9-3b7bd817687f"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("9335bcc4-3c17-48d5-a610-9538ed2d2546"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("94080a0c-8f90-4274-b615-5c89964d8b05"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("947e20f2-cc14-45f2-8fc8-c18a5bfa7966"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("9621d30b-0cd6-40d1-ab6c-3969d03b13d6"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("96a670e0-f928-4c7c-9e3b-b0bc60a48746"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("982b11bc-1795-4216-8c72-64a9f5b97d1f"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("9a1f7bd9-3c86-4b37-8c11-5028f28e39ee"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("9c3cec46-143c-4e09-be62-695859a7cf8e"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("9d4d05e9-ab1f-4979-9eac-ceba5cb5babb"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("9e20cfdc-8ccc-4223-aafc-806cb5d3f619"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("9eb2027f-befc-4ee6-aa75-fc92f35f3f62"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("9f221094-16fb-403d-a45f-10f70248159e"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("a30c32fe-42ae-4310-b7ca-ecf5ac354c22"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("a5055a60-c25d-414f-ab49-7f81333192a2"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("a72d1bb1-b0df-4727-8efc-5f7b56e4c08f"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("a7619f17-3954-4a6b-abec-451b2b054601"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("a81a3447-5fe0-46f5-9511-4e4ef2823f16"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("ab6c0e48-6de8-4ff1-a678-9d6a9aa05b7d"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("aee9011f-60a0-4718-ae5c-d05756c6751f"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("b46bc2ad-f988-4de6-a5ff-28e136492427"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("b9d3589b-af3a-4b9a-9970-635b5a071656"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("bad8421b-5179-4ac9-a923-dcb11cda3b9e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("bb91e328-fc05-4da1-8d5c-ee1150273aff"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("bf1e2880-1e68-44fa-ab6a-6958f5c68713"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("c1f93b42-ba8c-44e4-943c-e037bda9179e"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("c23f5649-e7f8-457e-a51a-de896a3e3a7f"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("c37db57a-d503-4142-995a-bfc8c6666adc"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("c83a4aa7-255f-414b-9d29-2db0cc866763"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("cc2e267a-21e7-4036-913a-a641280ce063"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("cd3adc1b-01e4-4f36-ad9f-96dcd124ee78"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("ce39de1c-2355-4ebd-8919-eccc9276d6d7"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("ce83eebd-f9f2-44a9-90cd-c1362b03cee6"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("d02f8804-55e6-4214-8f05-d6c9f8c9ad1c"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("d2b49abc-09b3-4872-b256-d1bf83a2f880"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("d950bb97-fdaa-44c3-b6d7-d527198f65fb"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("d9c328d6-5c3c-43d4-a2fe-321a17883096"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("db91af25-fb52-470d-aa94-42abc3d41392"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("dbb1771f-76a7-4f9f-b13b-d393a0dd0358"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("dc8dc45e-12ec-4666-a890-2ea1fe0f1fc7"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("dc962659-a26c-4bdc-bdc3-dd8957c4eaee"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("dcec3e15-4fa6-4685-b391-9ce10d56373c"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("de1ac89e-8890-4ee4-9b61-2e9f7f061a93"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("e1b995e3-aed4-4bfe-8c8d-2ad002b05696"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("e1fbc7a8-c3b7-4451-a717-1dbb4fa676ba"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("e30e98a6-08bf-4325-a002-fd41fb265815"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("e47ce4d8-bbd1-4e23-8a0f-af70dd56c443"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("e7816fe6-cd70-4bb7-90ba-047d297e9c68"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020") },
                    { new Guid("ebeb7749-af1f-483b-8e72-5a53c3e4fdd8"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("f1f9d7fe-90d2-400d-9966-45fd9ca3efdb"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("f3e61402-0def-46b7-aa6c-06e324593af7"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("f5436fc8-13f9-465a-b956-7ac3e29805ac"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("f64c7f41-e573-45b0-8041-1eaabe42cd09"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("f69ee884-e04e-4cc8-adc0-a3bce68ce064"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("f9160f78-2699-4791-a0ba-91151bc8c276"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("f929e88e-f0df-4c16-b6e2-0b69628fcb94"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("f9a9100c-f320-4e23-ab33-2ae0af2ed22d"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("fa481edd-ddff-4c9f-91bc-a7b117406fb5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("fe069034-6078-4d16-9aa7-b534ee43b8cc"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("ff2ea4c3-06a4-4fb4-a474-abc7f48fadb8"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("ff33fcec-278e-4376-af9a-e86f1b0affa1"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("ffa269e0-e21c-4b51-89d3-5c1685f475a0"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38e74c05-c342-418f-a858-9e8323bea4d4", "AQAAAAIAAYagAAAAEGHcpP6dSYNamHHnV3bOQ2x+AVxFg6FYxHK4wIAf51mwu8eqO2/aAJU2CTC4rYdePw==", "2f7fa440-b9f1-4a48-8e0d-9ed302a7fa88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27096111-2bf0-4986-a746-c1c832079da6", "AQAAAAIAAYagAAAAELWBTycQ8zLZo3bUs04YIZ3teEAx9ON+DWPsv/YaYAWUA4RjVoamYiz2064XbymRgg==", "e6c8c85d-3eb4-49bd-b06c-87a99c845a01" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5eabeb3f-7e91-4acf-b59f-d9e6889c9e93", "AQAAAAIAAYagAAAAELK+bN6KqBQy9Ny7UOI/iSbdx3VWtMNCB9df+KFsiefKZaGvOPGCFSJVU26sFP2KpQ==", "8068a3a4-e75f-4c66-8aec-d4c5f5213a70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "818ee663-ee47-42f0-9067-ec6254716900", "AQAAAAIAAYagAAAAECVxBEAbvO/5xbbN9tOm0x4GUJ2ellrTr3UtBbwIEU07DKNdye4uo8Ji3MnNYhwdXA==", "ea5d1934-ae5d-4f79-9845-5128ae8bd197" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c2a3ab2-878b-4946-be36-f941e4d6b205", "AQAAAAIAAYagAAAAEEZnSk666oMQhMichSna1UAsmYCpzz9c73DmKfkolyHNul4xp/jTojbfWSgkP6ioog==", "75260db9-7aa3-47c9-b24e-8bced187ea14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df70a801-0f39-4829-90b9-ad4f3768a6ea", "AQAAAAIAAYagAAAAEEXNJq4GyG3P2GYA/wrHwSP5nMDhi8idKSv1E1gyypr8gow2l48rma4/jE2fHoYszQ==", "5e57ee52-1fe9-4d5d-b209-cabb6029457f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("00bfd4ce-56d5-4e38-bc90-100fbeaab09e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0375de02-5e00-4534-a116-2ffb0f66b8a7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("037a2fac-5121-467e-a1fa-02b90afc9249"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("07825236-e5e3-4e5f-88c1-c8bf17a85b7b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("07cc12ad-e1bc-448b-9554-143337884b77"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0efedc5f-97a0-4f88-97c1-954cbf16db52"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("10a45682-0147-4b81-82ad-06fda74133c7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("10dd3efc-763f-406c-a4ac-cd61198dd1bb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("11e62e0c-ed3f-419a-bfc8-29c3849cb0bd"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1421a615-d9d3-4fde-9ff7-995bc7befc35"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("14dadd03-682b-45bf-8091-67bce40a8a35"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("173ae4a2-52a7-44a5-a740-fe4968819b13"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("17ad3c3f-f2ea-4ebf-a836-ebd00e4f0bdc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1909039e-e88f-43c9-9a4b-aaf379e13e7d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1a6c9cbb-1773-4d77-923f-87edde1bfb2d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1e9ba009-4947-4282-ab33-043f076cffe5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1eec48f3-87f2-4975-b312-600ce2855360"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2745fb64-2ae3-4571-ac3a-c87c48818993"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("28a80e83-b133-476a-bf9f-15ef6fc5fdbd"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2a2ab091-03b8-45d0-8af9-009c5947f057"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2c2ea5ca-1fb6-4267-963d-668490e66e78"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2c92c83d-6e46-48d8-9113-32c6a55028b7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2d847ea6-27e0-4f1e-bf8b-062e2cc2dfb5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3a3c563e-2118-4fa2-80a4-f4b621435c58"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3abed12a-3b44-43d9-9266-80c8bdb5ea84"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3bac04e5-881c-4d07-8376-fa6c1c768228"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3e60f32f-0686-435b-8087-16d4ba94b135"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4529be96-97d1-4242-a203-b1abe89a8508"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4600bdb4-e5d4-4bd0-bbd6-841c5a627caf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("46f0871d-faba-49ad-9df0-749030804888"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("48715e55-e57c-4bb0-bf32-024293fb7542"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("49239e13-1230-4985-8160-92a1d2404e9c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("493a42e3-1068-4066-ac6f-73d10e87fdf9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4a16ab71-12c9-46f4-8bea-a01f84784d22"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4a44330d-18d8-4e9d-b11c-d67d828bd861"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4c3d6e56-63a1-45da-9dbc-b59fca54bebd"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4c7024f5-56d4-427a-a650-78c9ad8b5688"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4d2886ae-88be-46a9-9e70-3724afec100f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4d411038-f929-4aab-ac17-7904db8b058c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("530e0864-8e85-4cbc-b19e-3a0919193426"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("578b4ca9-6a57-4dcf-ac9c-aa24ba18cfea"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5ded85e3-f368-49cd-a7db-dd53d0e0a7e8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5ed7c33b-ddf7-48e5-a39a-4b1430f50d13"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5fdb1919-c5ed-41e3-8308-3546d2f09787"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("61ce7761-453f-4e4d-9aea-7566f147780e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("63937f76-af03-460a-be68-bc01c9291874"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("642b0095-04dc-4429-8eb3-2a2f4208ff90"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("65324fc0-ac81-4505-bc6a-545671aae6a7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("685f286d-ca93-43a1-868b-c31b4fa09946"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("69ff8ef0-8a87-46f3-b61d-9c0294919067"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6b36b52a-3e8c-491a-9067-2d9bdd2cd43d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6d809fc7-ac3d-4959-b182-07f08983ed0d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6e6474c4-2ed7-4c02-aaa7-724ae7506a2e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("73c5fd3a-fa3c-48e6-bd9b-5d1bb198892a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("758fa33a-8b4e-4944-9eda-5bbe644bb946"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("77d73930-777e-44d1-8df7-2b2576336072"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("78ed62f1-5967-40ea-9758-0d343e7207a3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("79260d94-6174-43b3-8ccf-973e720582aa"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7ee19ae4-0944-4682-8778-31179c32389d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("80c979d8-4e82-4cef-b94b-2fb1ec1de851"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("81352242-eed0-44b8-a88f-e3da8cb59af4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("82c42e0a-63ca-4041-9ebd-2eca1380beee"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8466d70a-bdaf-45cd-9e29-cc53514209c5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("85ed278b-32a8-424b-97e2-2b2e6c40e63f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("86680a7a-5139-4b47-bdac-21a35d4bb298"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("86bbcf1c-32bc-4f4a-99f8-b32adde6bb3b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("88aaff30-9bd4-4047-bb4f-e3ab72a7f17e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("895aef36-9f37-4432-b47e-006675d38f06"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("897845b4-c6ea-481e-99e4-e3bddceccac1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8a4ed417-ec6e-406f-a8b5-140b23582fa8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8baf6f7e-7935-44e9-98df-9c9bee87e355"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8ca0a7f9-8be3-475d-b6bc-f0c37823a97f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8e3f9550-9e3d-4c57-974e-482d650c4397"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("90f4e34a-a0d8-4f40-97ed-faabf409def7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9211c634-4632-40af-81e7-152351319661"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9295e3ce-e16f-480d-99c9-3b7bd817687f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9335bcc4-3c17-48d5-a610-9538ed2d2546"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("94080a0c-8f90-4274-b615-5c89964d8b05"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("947e20f2-cc14-45f2-8fc8-c18a5bfa7966"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9621d30b-0cd6-40d1-ab6c-3969d03b13d6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("96a670e0-f928-4c7c-9e3b-b0bc60a48746"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("982b11bc-1795-4216-8c72-64a9f5b97d1f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9a1f7bd9-3c86-4b37-8c11-5028f28e39ee"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9c3cec46-143c-4e09-be62-695859a7cf8e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9d4d05e9-ab1f-4979-9eac-ceba5cb5babb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9e20cfdc-8ccc-4223-aafc-806cb5d3f619"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9eb2027f-befc-4ee6-aa75-fc92f35f3f62"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9f221094-16fb-403d-a45f-10f70248159e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a30c32fe-42ae-4310-b7ca-ecf5ac354c22"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a5055a60-c25d-414f-ab49-7f81333192a2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a72d1bb1-b0df-4727-8efc-5f7b56e4c08f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a7619f17-3954-4a6b-abec-451b2b054601"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a81a3447-5fe0-46f5-9511-4e4ef2823f16"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ab6c0e48-6de8-4ff1-a678-9d6a9aa05b7d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("aee9011f-60a0-4718-ae5c-d05756c6751f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b46bc2ad-f988-4de6-a5ff-28e136492427"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b9d3589b-af3a-4b9a-9970-635b5a071656"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bad8421b-5179-4ac9-a923-dcb11cda3b9e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bb91e328-fc05-4da1-8d5c-ee1150273aff"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bf1e2880-1e68-44fa-ab6a-6958f5c68713"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c1f93b42-ba8c-44e4-943c-e037bda9179e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c23f5649-e7f8-457e-a51a-de896a3e3a7f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c37db57a-d503-4142-995a-bfc8c6666adc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c83a4aa7-255f-414b-9d29-2db0cc866763"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cc2e267a-21e7-4036-913a-a641280ce063"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cd3adc1b-01e4-4f36-ad9f-96dcd124ee78"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ce39de1c-2355-4ebd-8919-eccc9276d6d7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ce83eebd-f9f2-44a9-90cd-c1362b03cee6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d02f8804-55e6-4214-8f05-d6c9f8c9ad1c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d2b49abc-09b3-4872-b256-d1bf83a2f880"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d950bb97-fdaa-44c3-b6d7-d527198f65fb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d9c328d6-5c3c-43d4-a2fe-321a17883096"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("db91af25-fb52-470d-aa94-42abc3d41392"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dbb1771f-76a7-4f9f-b13b-d393a0dd0358"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dc8dc45e-12ec-4666-a890-2ea1fe0f1fc7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dc962659-a26c-4bdc-bdc3-dd8957c4eaee"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dcec3e15-4fa6-4685-b391-9ce10d56373c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("de1ac89e-8890-4ee4-9b61-2e9f7f061a93"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e1b995e3-aed4-4bfe-8c8d-2ad002b05696"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e1fbc7a8-c3b7-4451-a717-1dbb4fa676ba"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e30e98a6-08bf-4325-a002-fd41fb265815"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e47ce4d8-bbd1-4e23-8a0f-af70dd56c443"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e7816fe6-cd70-4bb7-90ba-047d297e9c68"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ebeb7749-af1f-483b-8e72-5a53c3e4fdd8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f1f9d7fe-90d2-400d-9966-45fd9ca3efdb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f3e61402-0def-46b7-aa6c-06e324593af7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f5436fc8-13f9-465a-b956-7ac3e29805ac"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f64c7f41-e573-45b0-8041-1eaabe42cd09"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f69ee884-e04e-4cc8-adc0-a3bce68ce064"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f9160f78-2699-4791-a0ba-91151bc8c276"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f929e88e-f0df-4c16-b6e2-0b69628fcb94"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f9a9100c-f320-4e23-ab33-2ae0af2ed22d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fa481edd-ddff-4c9f-91bc-a7b117406fb5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fe069034-6078-4d16-9aa7-b534ee43b8cc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ff2ea4c3-06a4-4fb4-a474-abc7f48fadb8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ff33fcec-278e-4376-af9a-e86f1b0affa1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ffa269e0-e21c-4b51-89d3-5c1685f475a0"));

            migrationBuilder.AlterColumn<string>(
                name: "Amount",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "CarFeatureId", "CarId", "FeatureId" },
                values: new object[,]
                {
                    { new Guid("0013b730-5906-445e-9336-5c0c692b6b63"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("008adafc-32f3-4e2f-9efa-779aba503d65"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("031cb08f-3b00-4939-9f83-aaee436ac899"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("06e25b63-8b35-4518-b821-0e0c458dd264"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("08211877-3799-43fb-b628-711388a2c964"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("0a732f17-09d8-4d5b-9256-5267cc6108a9"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("0debc081-5525-4bcd-83de-00fe9c4532d9"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("1118aa6e-498a-4fd5-8ba5-3cc28d96442a"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("126e23df-b94c-4a29-ac37-10791f65b1bb"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("13b61734-d2de-4ca4-8962-dd8f9863c4f2"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("16ccc515-14ac-4f39-9989-66eccb86dd55"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("17fb2002-0640-474f-86f0-2d572c559d17"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("1a47526b-d398-42fd-942b-7f1bdd69f27e"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020") },
                    { new Guid("1a708b24-a6f1-4daf-88f0-a3e393e316f6"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("1a926c3d-f642-4a34-8a82-0ba872ea4361"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("1aa57dc7-7263-47da-8412-6cefc31d06d1"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("1b05d6da-f6be-46c4-a43f-cf53f850ec54"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("1de39b14-eb72-422e-bd4a-3d3f052d275d"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("20c72af5-9f84-44c3-b1d9-b93e8ba82a67"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("231925b9-8269-4e94-8dc6-d8464bde5c59"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("2396327d-bff6-4959-86cf-1879b4a9cb33"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("24ac69e6-684e-4bfc-989b-993b22bd9208"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("2749a3bd-4182-421e-8992-f887dbb593f0"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("27ccb8ee-4728-4d68-9c8b-d09d2ae55be5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("2b5ac5c0-50bb-41bc-840a-e756e35eaf22"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("2c41778c-789c-4faa-8a9c-4659e6489b4c"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("2cc22b56-f130-4752-a092-7b98e426e37d"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("2da7d643-fec9-46b8-9b3f-4ea4c7e50b17"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("2dfe6577-85f3-487b-84d2-3d32eb781f23"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("318cb6cb-e220-4d75-a113-6569501eac48"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("32082dcd-7818-459a-9224-7280a8c0f062"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("35c9b5a6-c57f-4a36-adaa-21eaf9014ba7"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("3bfe8be0-1053-4602-b239-5522f22a385d"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("407af8d8-15fd-4c9e-b6eb-849cd7c40e55"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("4092bcaa-6345-4c0d-bce9-79cca6e65aed"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("40a887e0-155d-4ebb-a8b1-668712535b81"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("42776e30-893b-4c95-a9f7-56132032a3f7"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("4326c9a5-3ffe-497b-bcdf-691fe0519b3c"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("437e1674-0257-4272-b881-85ec99c09f0e"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("45a30d58-10f9-448a-bb91-4b4f2d3b2874"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("45ba1d12-6998-4075-8f22-7f975ba3bc9d"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("48108e3d-cf61-47d3-9468-2b55aa0bf613"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("4fa048f4-4226-46e2-9e4c-477a88240431"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("52a6d410-f588-413e-b8f2-2d66fee6b418"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("52f9e1e5-dbd9-4e8f-8f1e-9172179f6916"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("540ed9c5-338c-47d1-9d0d-933d232f4d99"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("559063ad-16ff-482a-a92e-e975d9f3391d"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("55e4e16b-3b82-4f26-8545-7586c476c4f2"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("5c2c08c8-087a-497e-81cd-7d5b217412e1"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("600b1072-2c04-4cb1-865a-b9dee0d42fe9"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("62dba91e-d871-47c1-8559-d249ec3f0258"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("65fc2f80-b9b6-44c2-83d7-e8c0a35e3f96"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("67dcbcd7-0351-48ba-8c98-f620a16e03cf"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("6d580559-ccb7-401b-90e2-65b1779ee0f1"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("6eff74b6-919a-45c7-8e8c-fd87e9dccfb3"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("71453acd-1a4e-4e00-b91b-3b903bde9515"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("732f3abb-69b0-4f84-b4f9-69d747102fe4"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("74938205-a9c7-49d4-9231-bac997f2bc09"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("75204c98-768d-4ddf-8b46-c865280ea537"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("758e8d8f-2407-4084-8b6a-c8f69963cce0"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("76b7efd1-ce57-46ae-ae5a-a2dcfda1ecdf"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("77adff89-397f-4de1-a6b6-e9a343c47511"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("787d8bd0-683e-45ea-81ad-071b237a7403"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("796c02dd-9e74-4ac4-aca5-8fb99ce5ecc3"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("7cbad71a-9a5a-4378-819b-dc47d1f671af"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("7cd720dc-586e-4009-9c34-be7ffab84898"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("7cd7cdb0-39ec-40ba-8235-9ecd232ec121"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("7f92fdfc-0a0b-4454-932e-b1d0fd891551"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("8224c600-8227-4439-92fc-6aa9f5d790cb"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("82cbbe43-c1d1-4275-bb13-0b105eecbbc7"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("8634b880-6065-4958-b47c-665637187a50"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("876706c5-1e45-43c5-88d0-7e2bc30ea2c7"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("8d71b628-456f-4c92-91d1-a21c4d1ea5c1"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("90576818-fbd9-47e7-afb6-79b3c82daf78"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("92015012-6f85-451a-a68f-6854a456aa63"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("948c96e2-997e-4c43-85d5-495229105290"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("95d94047-c654-4028-8e88-ce1b1db475cb"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("989e9404-6ac1-416a-8be8-ad830635002f"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("9aa68555-1b53-4af7-80e3-fcbe48da5ab3"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("9b42df51-14d7-442f-a4fb-cffd1f7fa413"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("9bc45055-c443-4565-8c2f-07ada925fc9c"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("9e7fa954-d774-4506-93c0-427903bcdd89"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("9f47d9dc-695f-4ba5-b9c4-502d98d7b2c0"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("9f7ce449-50db-4c0e-bdb0-3ef51a454b70"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("a4d5268b-2e2e-488b-ac97-29a21281799f"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("a5b2e8e4-0092-4d7e-92ac-5db963bc54e8"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("a63a023a-12a9-4006-bbed-1622a9877937"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("a6e58bcc-875e-4604-aa7b-75ae800d0db6"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("aa4cd134-2504-45ad-aeeb-f191a7bd876a"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("abad8270-f275-4b19-bf82-483d0d118ba0"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("ad0908fc-04d4-477d-aced-2d4f6d98adbe"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("b1fa6e25-6a1e-4478-95a7-34a0cc2d2ee8"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("b5f48e46-f724-4720-b0a1-4690114f6da2"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("b6be7ff2-f62e-481a-9523-ba366ca0bcec"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("b73158c5-d1b0-482f-ba89-d87f0f3c6f4e"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("b88c4958-622d-46cc-8575-7183949f4099"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("bb817893-2a07-419c-abe4-35f801d7b7fc"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("bc81f91a-2d60-499d-80a6-df8a31a87877"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("bd88ec4c-ba23-4e4a-b162-62ad2374eaf8"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("bdecbb71-4065-4cc8-8dd8-0c521d78dfe2"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("be35035d-61aa-47dc-8273-fe4ba3aee3a9"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("bec48cf6-7432-42f1-b203-9dbe5f0fcb29"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("c061896c-fad8-4781-8493-8ec7f024391c"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("c0ad37bc-3386-4dee-b3a6-0d48f64e5d29"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("c2a9cb39-d6bd-4018-a247-05dbdb016ec9"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("c2b0d65d-8485-4abe-9b03-9466d1a64945"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("c474c443-c7f7-438b-89a3-0aa699da4e3b"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("c4838033-c49a-4806-91a0-2081dd507a9f"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("c58844a9-c21e-4e19-8592-fe753c876fd0"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("c9a966ca-91cf-439f-9edf-e66733341ccf"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("ca2015ca-17cb-40eb-a62b-d42fbcb5242b"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("cab6b2ce-ed1c-4b6c-b3b7-64152a8b24df"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("caf48dba-8f6b-4e24-bdb4-70053367b52f"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("cb7029ce-d813-4708-9cc8-697b12b88f74"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("ccd11857-4c49-40ec-b90a-42e141124e5c"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("ccee10b9-4868-418e-a6e3-f717277a2f0d"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("cd3da23b-08ed-45f4-ae39-1c00417f5b51"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("d31ab33e-1aaf-4add-a224-6359200f8295"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("d3581b5e-e509-4861-af7c-d747fce0463e"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("d5160027-350e-4a5b-ad85-2ae77c4e6751"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("d53c36a0-e37a-497d-81d3-711bb327550d"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("d8eb1c60-8d61-4355-9140-2bace4b408e5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("d9123b5c-b0aa-4fab-bc11-e3b3b475e18a"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("dc906269-7dcd-414a-a612-448c7de11dcb"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("e496b38f-5f0a-445d-8786-90b1d291c8a4"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("e5892be4-8045-4096-b6b3-2c5624e4b84e"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("e7f72f12-3f23-4915-a6ba-2db7b84ac300"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("e8e46216-568d-4e1b-86c4-b37459f62436"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("ea357dbf-025c-405c-9202-200ad2314c6b"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("ed83a79e-4a49-4dde-9d31-53d59aa40512"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("f0f2df36-abb1-498a-a6eb-35b819777cad"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("f273059f-5c7d-4544-8783-e31664391a82"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("f5b5bc0a-342d-4b3a-8e5e-366d012cddb4"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("f639eb9d-7f07-4b7e-a3ec-ea8583da8082"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("f7e3b3b2-7535-4546-bf44-8a0b70b56a54"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("f85a4058-ed24-4cbe-a394-145499a2b016"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("fac56561-a078-4d6c-b680-6263cd080079"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ace17060-0bef-4416-b348-804b931f27f5", "AQAAAAIAAYagAAAAEOpRymlMyoCMqEKIqM5czOneha3yYr0L+cANVPDzWHefAM0cBCSukbKHBdHtxfpY6Q==", "d5907230-9230-406f-9c87-d44f39415155" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1a955f7-9f57-455f-a70c-0867f7c8c32c", "AQAAAAIAAYagAAAAEIMf4j4mPt2zn1MxRgXApOQvcQtteggFpTxRyP27I5S/5hXNbkVKP5/eFT1kAIinPQ==", "6bd5b6cb-059d-4427-963d-748dc072670f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ad4f10d-f62f-4273-a6b5-fa4c98f11b52", "AQAAAAIAAYagAAAAELSkrCpBoGRCcf35TZ4OUAplGZ+icMXZpteGHEHvj/a+Afhg/EEP4d+2rj6H3P/4aA==", "2f741cf6-b4d2-4c4a-ad95-37a99595096e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0ca82db-22b2-4620-a369-6fe0c3eef8ab", "AQAAAAIAAYagAAAAEKoaCcZtSlsGbDlyTDx4C/7mW6tC0DishpYGSTXnqsmMzJuDacvVFo0zchOoJdLg7Q==", "c2088a1f-5693-443c-9685-c973ac16f9b7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d64aa761-841a-4330-850f-27e96b152e47", "AQAAAAIAAYagAAAAEBvUjPeTtwgHGBl/p17hgv1KmHDuVdSpnvpH7STsw7PPKXFwGQPSTRv5BNXt0lTTew==", "78ef2008-b7d6-49ee-848e-1b14c6c60d4b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99aae613-82ce-4b25-afae-86059084006a", "AQAAAAIAAYagAAAAEMwq8gl/hDmWi3U2UpwGIonquyzuliEqdyodbiPQozA4sez8SiSPa7f5QtRHgsTLGw==", "ac018f55-76bd-4c8e-8272-3a9217d6579b" });
        }
    }
}
