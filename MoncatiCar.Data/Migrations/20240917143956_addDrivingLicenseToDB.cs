using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class addDrivingLicenseToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("011ef3ec-22fa-47b4-8214-d0d25b99d5fc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("023230e1-610f-424b-9f98-1025f4154673"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("029c83ed-f96f-4dd8-a35e-dc548c0794ed"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("05d0bb77-6854-4b9d-9f59-243257fde7c8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0628f93f-e58d-4e60-87b0-57551fa3fecc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("06885624-ecf5-4100-8fc4-f194c82dc8a7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0739a960-0d79-40c3-81ed-428219ae4140"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0780f1ce-528e-4ce1-969c-f271bbf84e5d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("07a840b7-158c-46e5-8461-9ec024e761d9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0dc6e4d9-6ba4-422d-8c5a-f35c78e39ca3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0f4a8ccf-c075-476b-b3ed-00932a442fbf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("11aee8a4-2d7f-4588-a4b3-46a3ad12fed9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("15344463-f75e-45d2-b19a-0acc843b3e2a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("15e2e635-1596-4baa-896a-c3ebe675b627"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("17df5607-0f6a-410a-8582-8cc21bb66670"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("184b983b-4e8f-4e78-9a67-73fde2a479d4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1963b347-09c5-4bfa-8a70-f55295a755fb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("19ccd5fc-9f73-4fa9-b1cc-43c56920279c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1d107645-9c73-4ba2-9a3c-825f8aa74665"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1d9cbde1-2023-4972-892b-6a1407197bab"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1f45101e-385c-4f8e-b7df-8769a3ea0813"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("20901efb-123e-4e61-b810-4b722e5f8244"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("20d778ce-f035-4161-b2a4-e4369d281aca"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("235cdb31-8007-4b70-a603-1d22231cb388"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("23c1bdae-3a82-4eed-9d15-b4afa955f267"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("25431c81-9e02-44a3-b785-9d9f5f360af0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("26f63c1a-eb24-4e75-a9f4-8585ba6eb2ee"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("285677f1-49ca-4331-8a5a-63642c87230a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("28a9a3c1-11c1-4aea-8922-41802420c642"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2c2b4dd5-983c-4363-8735-423a19063e84"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("30246dc2-cd6c-4397-8d62-4be5fec5774e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3125a6a3-30fc-49ac-8263-d8c72c0063b2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("32b5ce20-fe9b-4932-8e02-ee13efe949fd"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("33db0fae-4883-41fc-a214-b219559e415a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("34faaf50-744b-404d-9e71-30f5aede78ff"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("35e78641-9aa4-4816-8ffa-a628827cc0bf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("38559cba-daa9-4f00-bb17-1b4ef2d0242b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("38b03b48-f4ce-427b-80b8-19967d931bc0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("39ffe9ab-bb40-4e66-a063-1fd87da7430a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3a14284e-8baf-4ffd-b7c0-5319ae02bb93"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3af72ce4-5776-418a-b113-48ed92e56cf6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3bc95ac7-efb8-4228-89ca-49cff6e58d96"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3c447de1-19b1-474c-93cb-382598147c01"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3cc77f53-f8da-496c-ade5-a759772fc1a2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3f661ea9-c371-498a-b020-e23c6ec58f74"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4006fc61-64d0-416d-9277-40976290c955"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("42609cf5-6cf2-4a12-9243-6c250eda524f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("439267c9-77f8-4229-84f6-c2cefcfb7a89"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("43d491c4-03bc-4d4a-bca0-9333f45dcaef"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("44725a16-91a9-444e-a5c1-cbe11d771eff"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("46bbad8c-7bbe-42be-9d97-21977bbd7fb7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4a7fc166-5495-4497-9c15-346b9292ccc0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4c7441b9-e061-44c7-9c53-4a0702a841d7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4d3c67a5-acb9-4c4b-b539-eead85193d27"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5030bfda-686c-45c6-9deb-7641d6111cde"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5252ca42-9cd2-4136-8174-895592d8ae47"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5382ee7d-18d5-4048-8a59-004214c74f0f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("54f25da3-bc81-4403-91a6-1dddac8b85e9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("561be53e-ede3-47f3-bab4-4cd36732f0c1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5826695d-4767-4115-824e-695918a296ce"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5938843c-8bd2-405c-b02b-e105ad15ef74"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5c101dab-279f-46f8-9cf4-f1909246b83f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("62daa00d-1460-4ffb-94fb-771895877d8f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6647b8d5-9afa-42c5-8895-551ee478c54f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6830fce9-ebc5-4cba-b0ed-0a9520650b99"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("69786271-087b-4afb-be8b-5f3ec22f42ae"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6cee2291-47fa-4f7c-a76e-488429325161"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("71ac5c40-64e2-4a41-ad93-54650e40698e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("729e3c4c-c810-4753-ac65-5a8536944b1f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("72d7c49a-f0f7-4ba8-876f-e029c082a799"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7481417f-d592-4081-9f47-321ff2bdd6dc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("756e1b89-c904-423f-ba50-263296ee1c70"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("765a2e55-5171-4a85-a5af-b2d1af74b8a7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("77f05577-1fcf-44d7-99cc-93d4c74d10a7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("77f342b9-2b54-4bbd-830c-4631a5f3d5c3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7d97d872-10d8-4ddd-b4ee-a94a44290941"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("88af63ee-8fe9-46f6-beab-26ca7c9aaf4b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8b0990b6-b486-461b-8a7e-17d2f54fb13a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8c3bed28-bb75-490a-9a81-4f5835aa5ca3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8d20af7d-75e3-400c-b2de-ab74de6eda1f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8f0bc0de-ffa2-403c-91c3-1ab03c1b4add"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8f0c2c62-0c9e-4960-ab0a-9e4241f9d19c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("93396dfb-78d1-4cef-b5b5-095ea2809a2b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("93e0325e-12d2-4d39-95c4-efaa40bfc910"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("97bba537-6442-475f-8f34-88a71934d2a6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("98329bdf-093c-43db-bfab-3d49871c87c6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("98724dd9-95bb-42be-a04b-eb3a2208bd30"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9daadcf1-dda0-49aa-8aae-17033bfbc841"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a62afa0c-0b4d-4dc9-9402-2b9b3f6bf367"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a70b8af6-d0d2-4259-8f74-1ed9295ee6b4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("aec372f4-e8fe-4369-ab6e-be842c91cba2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b07d6de0-d6b4-49bc-8eca-07401f3e3e85"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b2153fd8-f187-496f-b47d-364e462abf80"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b21759d1-9cd0-43d1-8c7e-257015035a7b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b3170122-bd52-4cb9-93c6-978e3556b2e5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b4c40b06-e8ec-4188-b918-3bc2f6e0588c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b665138e-7dd1-4702-950c-7d587e1312a1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b68a665d-6f32-417a-b5cb-361a9e3391f1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bb5cb312-0c57-455b-96e0-f26e23c8f415"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bcab0b2c-a30e-4843-affb-db43ea0c8330"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c0934656-5e90-492f-8883-f31e796296df"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c252d3bf-2d42-49e0-86e6-e25fa69fb986"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c32a986c-4882-4111-b8d0-3f08c7c2d276"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c5bdba3c-074c-4b51-b90c-2c66245476b5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c84dbf4d-ce3c-49aa-a66a-4f13f8be1350"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c9eae225-d79c-4944-92cb-638cd737fd16"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cc1e94d0-50e2-4ef6-91e9-7f683a7ff64c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cc5eca45-0e7b-4acc-a231-2b5d5e137d77"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ccc70345-2820-4c60-99f7-c68b8ab216a8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cd541b87-098c-40e4-9787-291ac3a90267"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cdc6acc0-5b8f-4a91-8717-8f235fe60fc9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cf16f327-9b9f-4d4a-9343-74815d6e6f8e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d0110dec-2bbc-4b03-827a-f02da16cb03e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d55923f1-cb40-4216-9f34-abc26568c4a4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d5db8380-5613-41fd-9975-dbb9571b95c1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("da22f0de-d064-4a4e-bf5d-590e94ddcd71"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("da6db152-5b89-44e0-b17a-083c807c89d7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dad907f4-8efd-4f56-96d4-c19920ba110e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dbe8baa6-5b56-4e30-aab7-2871ab717d8f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dff03732-aea7-476c-b55c-4643de09a30a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e2068718-55ce-4173-b8df-48f7c5d59361"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e302c325-fb15-45e2-8c7c-dda2ff669688"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e5246c8a-7feb-451f-a6fb-41aa5d5a81db"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ea4c189c-56ad-4b4e-b518-1e8dc4abae3f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ed3bfba5-5b51-4f93-b6d3-be3b1d7a2c87"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ed9f989f-c9dc-48c8-9aca-07ef210de0dd"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ef47a919-af35-42ca-a5f7-d35723605c20"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ef73dc79-4fd6-4c75-8c3d-e5f5bcf54e98"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f0190cee-d12f-448b-b9b8-aff5a109e6b2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f09af2a0-a329-4eea-abdf-813cbeaa1686"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f1597291-6c7b-4de6-b130-83d50977fdd8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f1fe435a-0177-41cf-b014-b9cb7cdcb51f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f31ed2a1-1245-4437-8fef-1f7ec34847c1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f3a1fc57-88ea-4430-a423-c5d238400fc5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f3c77957-f39e-443d-ac5f-1376133c176a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f4bb5fc0-a30b-4129-b850-e7254dd867fe"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f6bdb9d2-b935-4901-bf3a-2c22d0447d8e"));

            migrationBuilder.CreateTable(
                name: "DrivingLicenses",
                columns: table => new
                {
                    DrivingLicenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrivingLicenses", x => x.DrivingLicenseId);
                    table.ForeignKey(
                        name: "FK_DrivingLicenses_Users_UserId",
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
                    { new Guid("0784073d-ef62-4a12-a38a-14dae8d9c807"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("0958cedc-1ad1-4a95-9bc0-b8e0db9e4886"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("0a07274f-594f-449c-a792-7e00509bea8d"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("0bb434c5-22b9-4250-a622-d920c029920a"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("0d282fdd-338d-4bee-8e5f-8c85c10f00e6"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("0ef5f22f-3df2-4c13-a43b-fd615c5982d6"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("0f278325-72e1-4b3b-88d8-c5369d7b0c96"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("0f6651d3-02c5-4a53-8441-3e1bd4bbb64a"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("11041202-871f-40be-a9b3-7b4b4cb4f2e3"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("14bb00dd-10df-4fa3-bef2-99a227398a64"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("1676faff-d4a7-4378-bee1-0ddf41c23a5a"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("17449251-ce35-4e35-9aaa-a7cdb50b75c9"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("18d47dbc-50fa-4ae4-8ce8-11989c2ee317"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("19c45617-3bec-4217-9bad-aa09ad6c7ce2"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("1ab77a6c-a88e-4070-81de-be271a5120d8"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("1b845f4c-d8bc-4eef-b0a6-18b810212844"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("1bbc5643-5615-454b-9030-82cbc7976fce"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("1c7eac5f-d631-454b-a4d0-cc53ce277f32"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("1ee0bcd7-ff5d-4791-ae11-8fed972dc485"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("2078376e-aaa5-4b6a-88a8-a3a6ee59cf06"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("24174ec0-6e86-499a-85d9-e246c04cf50f"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("27d6e035-82dd-459e-bd7a-5188dac94687"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("2878857d-31ef-437a-927a-384d7b926377"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("297a2675-303a-4689-888c-0188e836a01e"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("2da7022a-48d0-4081-aee9-217c4fca2978"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("2e054250-1b89-4d2c-9c7f-dac80ee7db80"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("300c8d23-6a14-41f8-bd92-8b7646946d98"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020") },
                    { new Guid("3664b12f-9966-44ba-a612-39e783eeb555"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("36837897-6c7a-426c-91d2-24e203e73d53"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("38325337-677a-41ee-8eda-f7701af591d1"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("3895ec62-f374-46a3-9225-1c231e1719ee"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("395ff057-3b4d-4a26-8030-b9aebde6b6b9"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("39cebcbd-216b-4021-a9d3-53a44f35ef35"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("3ccb834a-5b4f-4fbb-b1db-b60b46dfbeac"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("3f408cda-e385-4011-8907-85e6eca15b64"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("3f88db06-a687-4b64-9ab4-b694f791ef36"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("3f909fe5-a8f9-48be-85c0-f810eff6c022"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("40e2f3e3-bb43-477d-b3cb-12c243c97e7f"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("439ab4d4-c75e-47bd-a59d-b6cc26052447"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("4bb89d39-8fdf-4050-8941-9708fc96845c"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("4ea95505-9661-4155-90ba-4468b747f8ab"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("51030b95-262c-48f8-81ff-35710369eb7b"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("51ad89c9-5336-4681-bbee-ea8c98f6558f"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("51e6a3ff-6d40-4248-8f91-6239554f13c8"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("52d5611e-8ad8-4b81-a74e-2209973aa185"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("555aa785-3b1e-4528-b839-a041721426d9"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("5a3a3508-f4cb-4aee-aafd-0883dfc52aa6"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("5c24046d-ea7c-45ce-a33b-9c304f3776f8"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("5f80a1f3-9593-4290-bd31-a738df97e0a7"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("6088011e-5367-4a57-8fa8-71c03dca5947"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("65e7dd73-eb2b-4023-b9b4-f04d5df003ba"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("67239266-a189-4ec2-899a-41f12b492993"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("68081db8-2c02-4901-9bfa-16d9366f5a2b"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("69259a53-dab5-42c3-b4b5-93b842d47249"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("6994d8f2-7375-4430-be0b-de4d4111449d"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("6b2b94f0-bc1b-4e92-bf1e-9669050827c4"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("6b7671eb-5608-4ed0-a485-429618549fb4"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("71bf1c61-1841-49ad-87cd-612752fcaabf"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("78f50703-bd42-435f-a81b-cf6b3e5a9ec2"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("7ba31673-ece4-44a2-be6b-90fa9307d6b8"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("7c21f183-ef50-4a5d-a1aa-551b6cdfbf93"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("7e85f9bb-7b2e-47d5-9549-2b40c3326974"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("7e9f8ed3-006c-4776-b955-e9897070f6eb"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("804a8b0e-619f-4955-a08a-c851e825bb31"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("80c2fe64-e9ac-423d-a371-3f65ab758a7b"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("86ca3c42-5b4a-4b3c-900f-d0f3e312d2b9"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("86d89c23-beb8-458e-a0f0-705ba55ebda5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("88e54531-59b5-4afc-9a2c-818e59b72783"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("8d6e4e75-c102-4d81-b85c-efcb569d35a0"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("8e78f15d-87a8-48b1-8b72-16f80aff5342"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("8ed735c2-cdfa-4386-8a48-5091c53172a0"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("90a9d274-18f4-43c6-b573-b2d3324ce5bf"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("94628aab-2673-400c-ba94-1123a771ce35"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("94850892-4e64-422b-b158-635276d83d39"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("96013921-d9e3-4f12-9314-fd09c72aac36"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("97170188-8fa5-4f9f-bd1e-d2376d1559c7"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("97ba9bd1-a588-4a91-80f3-60d49429bb80"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("981b4073-ebc7-48c7-ac88-c49445e44731"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("9b143abd-12c4-4055-b888-abe9a4047d12"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("9bed7391-bf60-45b3-aca0-085956f4f038"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("9c554dc7-8353-48f9-b216-8f81290096b5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("9d59e19d-9df3-4bca-a771-838479652fc4"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("a194d128-a810-4648-b71f-928b2ca8cc70"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("a1adcd7e-b814-4fb7-b9fd-75b983c4760c"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("a1dcd821-3084-43fc-beeb-58bbd9f045dc"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("a4b10a61-3416-4f83-82b2-7a0a55deca1a"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("a4d2572d-12e5-4afa-adf7-5c9595fb27cb"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("a6b34d7c-2bfa-4bcf-b56b-580b539749f7"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("a76d3ab6-cb21-42c9-940b-39c2a14cf9a1"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("a848917c-1827-4f49-bfb0-0700015efd99"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("ab8926ba-8d2c-49e8-93e7-2c61b5dcc65d"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("ac7d58cb-2e60-43c2-bad1-720597de15aa"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("ad98827e-8992-46e8-898e-ba9064e94c18"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("b049f2b4-cfcf-4ee6-b5a5-b8c26cc917ac"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("b40bb801-cd82-4a9f-a329-167a2bd49cce"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("b493d3b8-9c7a-4978-9c7f-b856d23b1082"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("b7f58b4d-aa06-427b-b63b-4264fd1e5cb8"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("b83be62e-e002-4405-8085-643a00f40ca1"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("b88f4630-5f65-47a5-99d8-1de870bae0ad"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("b9fc7b85-015f-4c65-9fb7-bd392b0a4960"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("ba6a3e9c-bfc5-4b50-beaa-70e86715d485"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("ba99935b-fa1a-461a-b8cb-7651166b31b6"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("baa92cc1-8433-46bb-8543-d95f2527d4e8"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("bb61a73a-7fb7-4f58-87f9-4f31f1956eb4"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("bd434d71-f998-42e0-a252-b12356169c5b"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("beba16d0-e9df-4134-a24c-9040db4246fe"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("c04b87a1-3568-4f0e-95b1-2bd40ebfe8a7"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("c3c4d4c5-96e2-427f-a8a8-5b9deaec0a6e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("cb0e9581-62ba-4fd1-90c4-794e60217f44"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("ccdeead0-f099-4643-b146-e70f6eee7a62"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("cd36a2ea-fd9b-44ca-b549-17d5ed3e0254"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("ce200150-867e-4002-9843-1ddc65bda37b"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("cedc6d7c-b2f5-4fa6-a264-ca7c11127cf8"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("d12702a4-bec9-4171-bf9b-5ee72a33b207"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("d355025f-81b9-40c4-b52a-25e43db65979"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("d39c7d5d-9852-4e8a-a8ba-ce0f98c07fb9"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("da6af2af-c871-4e4f-9cdd-4af592cfd8b7"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("dbe5a8f8-5000-442e-a620-72e55e2adef6"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("dc2841ff-a8a9-4e44-a280-872f1651da30"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("e081d78f-56d8-4fed-9b03-9c4b1b5ce208"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("e2c4b52f-1e29-4e5d-b868-f8616db2cc88"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("e3aa3c92-230f-4150-addb-0e2f5135d6b1"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("e59effd7-a157-448f-8d90-3db9704694df"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("e7e913be-f098-419c-831a-8bffd44862ab"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("e8f5a3ca-2576-49c3-85f4-17a3535ca04c"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("e9203ec0-54e6-45b9-9a21-0ff8583032b3"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("ee522de6-fe91-46ce-8dea-7f8fea31396e"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("f350dd4e-d9fc-4430-aa64-0d45759a7ae6"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("f388f008-a07b-4965-bb9d-8dfd65be8e1d"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("f4671f0b-2a05-44b8-976e-611612708607"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("f4bb1f16-ed55-450d-b181-0ddbe649b625"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("f5309da0-be34-4176-a483-718d18044799"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("f5979fd7-5e5a-467a-9a52-d02a138295b8"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("f5ee49ae-bcb8-4f05-91df-4cf71ea9b1d8"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("f72668cc-4e24-4b88-8a96-1ff212235cdc"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("f99b671c-1429-4dd1-92c9-f51b3948988d"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("fca49620-14c1-4180-aab8-b6cba87dfc00"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17d7f9d3-5051-45da-9ee5-0371965b0883", "AQAAAAIAAYagAAAAEOWSUWja4FULa/LxU/JtzwmO6PfUN5sexysE9Qy4HlUB9217oYZs1ccBjf2U72+aOw==", "18932a6b-c73c-4588-b995-7b1944b44679" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c4c69f9-9ecc-49e0-95fe-9a6bd0ee4c3d", "AQAAAAIAAYagAAAAELXvqA/cbMeXLbcuKt44ILcmwpSYqCSxkMGnXffBS/nYERoEgI1N9Y/suHPqE0caLQ==", "af62e704-3268-481e-a7ef-1966d9e487a1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c4ddeff-318a-4665-989b-c0a12ae19ce7", "AQAAAAIAAYagAAAAEOtVq5bIkU6hwxqesQjBRqgYfzvH0afmE4Tygb0zvXYQReDImPL7UL1KbUAppA+TsQ==", "bca6e1ba-99d6-4bfa-9a0b-6a29535bf26f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e9fa6cf-d622-463c-b314-a42fb4ea8a38", "AQAAAAIAAYagAAAAEG7VeoV42cUq+wFLutOYJ+7VwmCgtaoTGVhZ82SMVAVAHnj/x/QaV/RpmtE4fmnk7Q==", "7396e2d1-e5ac-439a-a372-701d083460d5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5f3997a-aa26-423b-b6bd-e3de7ea5b509", "AQAAAAIAAYagAAAAENqIF0uAPzDSBztQISGrmsUZtxmV/DNod2YDUXnsUmY3QhLKe/XbITF9rRPnkcmstQ==", "18b2055a-72ed-4076-a001-f68fab2765ef" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0013b3c-6491-4fab-89af-3c7b439f2348", "AQAAAAIAAYagAAAAEISmFItAMW42uWG2YslvUQ/5rbvyXaOS1QloKUIQpYxmCAw/kGaFZynFHxt/Fyrk5A==", "f8364421-0c13-454b-8cb6-7771b0cd599c" });

            migrationBuilder.CreateIndex(
                name: "IX_DrivingLicenses_UserId",
                table: "DrivingLicenses",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrivingLicenses");

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0784073d-ef62-4a12-a38a-14dae8d9c807"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0958cedc-1ad1-4a95-9bc0-b8e0db9e4886"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0a07274f-594f-449c-a792-7e00509bea8d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0bb434c5-22b9-4250-a622-d920c029920a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0d282fdd-338d-4bee-8e5f-8c85c10f00e6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0ef5f22f-3df2-4c13-a43b-fd615c5982d6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0f278325-72e1-4b3b-88d8-c5369d7b0c96"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0f6651d3-02c5-4a53-8441-3e1bd4bbb64a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("11041202-871f-40be-a9b3-7b4b4cb4f2e3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("14bb00dd-10df-4fa3-bef2-99a227398a64"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1676faff-d4a7-4378-bee1-0ddf41c23a5a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("17449251-ce35-4e35-9aaa-a7cdb50b75c9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("18d47dbc-50fa-4ae4-8ce8-11989c2ee317"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("19c45617-3bec-4217-9bad-aa09ad6c7ce2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1ab77a6c-a88e-4070-81de-be271a5120d8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1b845f4c-d8bc-4eef-b0a6-18b810212844"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1bbc5643-5615-454b-9030-82cbc7976fce"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1c7eac5f-d631-454b-a4d0-cc53ce277f32"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1ee0bcd7-ff5d-4791-ae11-8fed972dc485"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2078376e-aaa5-4b6a-88a8-a3a6ee59cf06"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("24174ec0-6e86-499a-85d9-e246c04cf50f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("27d6e035-82dd-459e-bd7a-5188dac94687"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2878857d-31ef-437a-927a-384d7b926377"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("297a2675-303a-4689-888c-0188e836a01e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2da7022a-48d0-4081-aee9-217c4fca2978"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2e054250-1b89-4d2c-9c7f-dac80ee7db80"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("300c8d23-6a14-41f8-bd92-8b7646946d98"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3664b12f-9966-44ba-a612-39e783eeb555"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("36837897-6c7a-426c-91d2-24e203e73d53"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("38325337-677a-41ee-8eda-f7701af591d1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3895ec62-f374-46a3-9225-1c231e1719ee"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("395ff057-3b4d-4a26-8030-b9aebde6b6b9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("39cebcbd-216b-4021-a9d3-53a44f35ef35"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3ccb834a-5b4f-4fbb-b1db-b60b46dfbeac"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3f408cda-e385-4011-8907-85e6eca15b64"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3f88db06-a687-4b64-9ab4-b694f791ef36"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3f909fe5-a8f9-48be-85c0-f810eff6c022"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("40e2f3e3-bb43-477d-b3cb-12c243c97e7f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("439ab4d4-c75e-47bd-a59d-b6cc26052447"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4bb89d39-8fdf-4050-8941-9708fc96845c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4ea95505-9661-4155-90ba-4468b747f8ab"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("51030b95-262c-48f8-81ff-35710369eb7b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("51ad89c9-5336-4681-bbee-ea8c98f6558f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("51e6a3ff-6d40-4248-8f91-6239554f13c8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("52d5611e-8ad8-4b81-a74e-2209973aa185"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("555aa785-3b1e-4528-b839-a041721426d9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5a3a3508-f4cb-4aee-aafd-0883dfc52aa6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5c24046d-ea7c-45ce-a33b-9c304f3776f8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5f80a1f3-9593-4290-bd31-a738df97e0a7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6088011e-5367-4a57-8fa8-71c03dca5947"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("65e7dd73-eb2b-4023-b9b4-f04d5df003ba"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("67239266-a189-4ec2-899a-41f12b492993"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("68081db8-2c02-4901-9bfa-16d9366f5a2b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("69259a53-dab5-42c3-b4b5-93b842d47249"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6994d8f2-7375-4430-be0b-de4d4111449d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6b2b94f0-bc1b-4e92-bf1e-9669050827c4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6b7671eb-5608-4ed0-a485-429618549fb4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("71bf1c61-1841-49ad-87cd-612752fcaabf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("78f50703-bd42-435f-a81b-cf6b3e5a9ec2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7ba31673-ece4-44a2-be6b-90fa9307d6b8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7c21f183-ef50-4a5d-a1aa-551b6cdfbf93"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7e85f9bb-7b2e-47d5-9549-2b40c3326974"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7e9f8ed3-006c-4776-b955-e9897070f6eb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("804a8b0e-619f-4955-a08a-c851e825bb31"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("80c2fe64-e9ac-423d-a371-3f65ab758a7b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("86ca3c42-5b4a-4b3c-900f-d0f3e312d2b9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("86d89c23-beb8-458e-a0f0-705ba55ebda5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("88e54531-59b5-4afc-9a2c-818e59b72783"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8d6e4e75-c102-4d81-b85c-efcb569d35a0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8e78f15d-87a8-48b1-8b72-16f80aff5342"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8ed735c2-cdfa-4386-8a48-5091c53172a0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("90a9d274-18f4-43c6-b573-b2d3324ce5bf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("94628aab-2673-400c-ba94-1123a771ce35"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("94850892-4e64-422b-b158-635276d83d39"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("96013921-d9e3-4f12-9314-fd09c72aac36"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("97170188-8fa5-4f9f-bd1e-d2376d1559c7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("97ba9bd1-a588-4a91-80f3-60d49429bb80"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("981b4073-ebc7-48c7-ac88-c49445e44731"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9b143abd-12c4-4055-b888-abe9a4047d12"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9bed7391-bf60-45b3-aca0-085956f4f038"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9c554dc7-8353-48f9-b216-8f81290096b5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9d59e19d-9df3-4bca-a771-838479652fc4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a194d128-a810-4648-b71f-928b2ca8cc70"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a1adcd7e-b814-4fb7-b9fd-75b983c4760c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a1dcd821-3084-43fc-beeb-58bbd9f045dc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a4b10a61-3416-4f83-82b2-7a0a55deca1a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a4d2572d-12e5-4afa-adf7-5c9595fb27cb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a6b34d7c-2bfa-4bcf-b56b-580b539749f7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a76d3ab6-cb21-42c9-940b-39c2a14cf9a1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a848917c-1827-4f49-bfb0-0700015efd99"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ab8926ba-8d2c-49e8-93e7-2c61b5dcc65d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ac7d58cb-2e60-43c2-bad1-720597de15aa"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ad98827e-8992-46e8-898e-ba9064e94c18"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b049f2b4-cfcf-4ee6-b5a5-b8c26cc917ac"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b40bb801-cd82-4a9f-a329-167a2bd49cce"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b493d3b8-9c7a-4978-9c7f-b856d23b1082"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b7f58b4d-aa06-427b-b63b-4264fd1e5cb8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b83be62e-e002-4405-8085-643a00f40ca1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b88f4630-5f65-47a5-99d8-1de870bae0ad"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b9fc7b85-015f-4c65-9fb7-bd392b0a4960"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ba6a3e9c-bfc5-4b50-beaa-70e86715d485"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ba99935b-fa1a-461a-b8cb-7651166b31b6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("baa92cc1-8433-46bb-8543-d95f2527d4e8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bb61a73a-7fb7-4f58-87f9-4f31f1956eb4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bd434d71-f998-42e0-a252-b12356169c5b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("beba16d0-e9df-4134-a24c-9040db4246fe"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c04b87a1-3568-4f0e-95b1-2bd40ebfe8a7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c3c4d4c5-96e2-427f-a8a8-5b9deaec0a6e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cb0e9581-62ba-4fd1-90c4-794e60217f44"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ccdeead0-f099-4643-b146-e70f6eee7a62"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cd36a2ea-fd9b-44ca-b549-17d5ed3e0254"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ce200150-867e-4002-9843-1ddc65bda37b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cedc6d7c-b2f5-4fa6-a264-ca7c11127cf8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d12702a4-bec9-4171-bf9b-5ee72a33b207"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d355025f-81b9-40c4-b52a-25e43db65979"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d39c7d5d-9852-4e8a-a8ba-ce0f98c07fb9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("da6af2af-c871-4e4f-9cdd-4af592cfd8b7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dbe5a8f8-5000-442e-a620-72e55e2adef6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dc2841ff-a8a9-4e44-a280-872f1651da30"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e081d78f-56d8-4fed-9b03-9c4b1b5ce208"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e2c4b52f-1e29-4e5d-b868-f8616db2cc88"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e3aa3c92-230f-4150-addb-0e2f5135d6b1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e59effd7-a157-448f-8d90-3db9704694df"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e7e913be-f098-419c-831a-8bffd44862ab"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e8f5a3ca-2576-49c3-85f4-17a3535ca04c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e9203ec0-54e6-45b9-9a21-0ff8583032b3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ee522de6-fe91-46ce-8dea-7f8fea31396e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f350dd4e-d9fc-4430-aa64-0d45759a7ae6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f388f008-a07b-4965-bb9d-8dfd65be8e1d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f4671f0b-2a05-44b8-976e-611612708607"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f4bb1f16-ed55-450d-b181-0ddbe649b625"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f5309da0-be34-4176-a483-718d18044799"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f5979fd7-5e5a-467a-9a52-d02a138295b8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f5ee49ae-bcb8-4f05-91df-4cf71ea9b1d8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f72668cc-4e24-4b88-8a96-1ff212235cdc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f99b671c-1429-4dd1-92c9-f51b3948988d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fca49620-14c1-4180-aab8-b6cba87dfc00"));

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "CarFeatureId", "CarId", "FeatureId" },
                values: new object[,]
                {
                    { new Guid("011ef3ec-22fa-47b4-8214-d0d25b99d5fc"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("023230e1-610f-424b-9f98-1025f4154673"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("029c83ed-f96f-4dd8-a35e-dc548c0794ed"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("05d0bb77-6854-4b9d-9f59-243257fde7c8"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("0628f93f-e58d-4e60-87b0-57551fa3fecc"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("06885624-ecf5-4100-8fc4-f194c82dc8a7"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("0739a960-0d79-40c3-81ed-428219ae4140"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("0780f1ce-528e-4ce1-969c-f271bbf84e5d"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("07a840b7-158c-46e5-8461-9ec024e761d9"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("0dc6e4d9-6ba4-422d-8c5a-f35c78e39ca3"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("0f4a8ccf-c075-476b-b3ed-00932a442fbf"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("11aee8a4-2d7f-4588-a4b3-46a3ad12fed9"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("15344463-f75e-45d2-b19a-0acc843b3e2a"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("15e2e635-1596-4baa-896a-c3ebe675b627"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("17df5607-0f6a-410a-8582-8cc21bb66670"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("184b983b-4e8f-4e78-9a67-73fde2a479d4"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("1963b347-09c5-4bfa-8a70-f55295a755fb"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("19ccd5fc-9f73-4fa9-b1cc-43c56920279c"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("1d107645-9c73-4ba2-9a3c-825f8aa74665"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("1d9cbde1-2023-4972-892b-6a1407197bab"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("1f45101e-385c-4f8e-b7df-8769a3ea0813"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("20901efb-123e-4e61-b810-4b722e5f8244"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("20d778ce-f035-4161-b2a4-e4369d281aca"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("235cdb31-8007-4b70-a603-1d22231cb388"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("23c1bdae-3a82-4eed-9d15-b4afa955f267"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("25431c81-9e02-44a3-b785-9d9f5f360af0"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("26f63c1a-eb24-4e75-a9f4-8585ba6eb2ee"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("285677f1-49ca-4331-8a5a-63642c87230a"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("28a9a3c1-11c1-4aea-8922-41802420c642"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("2c2b4dd5-983c-4363-8735-423a19063e84"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("30246dc2-cd6c-4397-8d62-4be5fec5774e"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("3125a6a3-30fc-49ac-8263-d8c72c0063b2"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("32b5ce20-fe9b-4932-8e02-ee13efe949fd"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("33db0fae-4883-41fc-a214-b219559e415a"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("34faaf50-744b-404d-9e71-30f5aede78ff"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("35e78641-9aa4-4816-8ffa-a628827cc0bf"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("38559cba-daa9-4f00-bb17-1b4ef2d0242b"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("38b03b48-f4ce-427b-80b8-19967d931bc0"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("39ffe9ab-bb40-4e66-a063-1fd87da7430a"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("3a14284e-8baf-4ffd-b7c0-5319ae02bb93"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("3af72ce4-5776-418a-b113-48ed92e56cf6"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("3bc95ac7-efb8-4228-89ca-49cff6e58d96"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("3c447de1-19b1-474c-93cb-382598147c01"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("3cc77f53-f8da-496c-ade5-a759772fc1a2"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("3f661ea9-c371-498a-b020-e23c6ec58f74"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("4006fc61-64d0-416d-9277-40976290c955"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("42609cf5-6cf2-4a12-9243-6c250eda524f"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("439267c9-77f8-4229-84f6-c2cefcfb7a89"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("43d491c4-03bc-4d4a-bca0-9333f45dcaef"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("44725a16-91a9-444e-a5c1-cbe11d771eff"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("46bbad8c-7bbe-42be-9d97-21977bbd7fb7"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("4a7fc166-5495-4497-9c15-346b9292ccc0"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("4c7441b9-e061-44c7-9c53-4a0702a841d7"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("4d3c67a5-acb9-4c4b-b539-eead85193d27"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("5030bfda-686c-45c6-9deb-7641d6111cde"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("5252ca42-9cd2-4136-8174-895592d8ae47"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("5382ee7d-18d5-4048-8a59-004214c74f0f"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("54f25da3-bc81-4403-91a6-1dddac8b85e9"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("561be53e-ede3-47f3-bab4-4cd36732f0c1"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("5826695d-4767-4115-824e-695918a296ce"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("5938843c-8bd2-405c-b02b-e105ad15ef74"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("5c101dab-279f-46f8-9cf4-f1909246b83f"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("62daa00d-1460-4ffb-94fb-771895877d8f"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("6647b8d5-9afa-42c5-8895-551ee478c54f"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("6830fce9-ebc5-4cba-b0ed-0a9520650b99"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("69786271-087b-4afb-be8b-5f3ec22f42ae"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("6cee2291-47fa-4f7c-a76e-488429325161"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("71ac5c40-64e2-4a41-ad93-54650e40698e"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("729e3c4c-c810-4753-ac65-5a8536944b1f"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("72d7c49a-f0f7-4ba8-876f-e029c082a799"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("7481417f-d592-4081-9f47-321ff2bdd6dc"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("756e1b89-c904-423f-ba50-263296ee1c70"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("765a2e55-5171-4a85-a5af-b2d1af74b8a7"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("77f05577-1fcf-44d7-99cc-93d4c74d10a7"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("77f342b9-2b54-4bbd-830c-4631a5f3d5c3"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("7d97d872-10d8-4ddd-b4ee-a94a44290941"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("88af63ee-8fe9-46f6-beab-26ca7c9aaf4b"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("8b0990b6-b486-461b-8a7e-17d2f54fb13a"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("8c3bed28-bb75-490a-9a81-4f5835aa5ca3"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("8d20af7d-75e3-400c-b2de-ab74de6eda1f"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("8f0bc0de-ffa2-403c-91c3-1ab03c1b4add"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("8f0c2c62-0c9e-4960-ab0a-9e4241f9d19c"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("93396dfb-78d1-4cef-b5b5-095ea2809a2b"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("93e0325e-12d2-4d39-95c4-efaa40bfc910"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("97bba537-6442-475f-8f34-88a71934d2a6"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("98329bdf-093c-43db-bfab-3d49871c87c6"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("98724dd9-95bb-42be-a04b-eb3a2208bd30"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("9daadcf1-dda0-49aa-8aae-17033bfbc841"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("a62afa0c-0b4d-4dc9-9402-2b9b3f6bf367"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("a70b8af6-d0d2-4259-8f74-1ed9295ee6b4"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("aec372f4-e8fe-4369-ab6e-be842c91cba2"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("b07d6de0-d6b4-49bc-8eca-07401f3e3e85"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("b2153fd8-f187-496f-b47d-364e462abf80"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("b21759d1-9cd0-43d1-8c7e-257015035a7b"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("b3170122-bd52-4cb9-93c6-978e3556b2e5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("b4c40b06-e8ec-4188-b918-3bc2f6e0588c"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("b665138e-7dd1-4702-950c-7d587e1312a1"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("b68a665d-6f32-417a-b5cb-361a9e3391f1"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("bb5cb312-0c57-455b-96e0-f26e23c8f415"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("bcab0b2c-a30e-4843-affb-db43ea0c8330"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("c0934656-5e90-492f-8883-f31e796296df"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("c252d3bf-2d42-49e0-86e6-e25fa69fb986"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("c32a986c-4882-4111-b8d0-3f08c7c2d276"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("c5bdba3c-074c-4b51-b90c-2c66245476b5"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("c84dbf4d-ce3c-49aa-a66a-4f13f8be1350"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("c9eae225-d79c-4944-92cb-638cd737fd16"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("cc1e94d0-50e2-4ef6-91e9-7f683a7ff64c"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("cc5eca45-0e7b-4acc-a231-2b5d5e137d77"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("ccc70345-2820-4c60-99f7-c68b8ab216a8"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("cd541b87-098c-40e4-9787-291ac3a90267"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("cdc6acc0-5b8f-4a91-8717-8f235fe60fc9"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("cf16f327-9b9f-4d4a-9343-74815d6e6f8e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("d0110dec-2bbc-4b03-827a-f02da16cb03e"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("d55923f1-cb40-4216-9f34-abc26568c4a4"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("d5db8380-5613-41fd-9975-dbb9571b95c1"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("da22f0de-d064-4a4e-bf5d-590e94ddcd71"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("da6db152-5b89-44e0-b17a-083c807c89d7"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("dad907f4-8efd-4f56-96d4-c19920ba110e"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("dbe8baa6-5b56-4e30-aab7-2871ab717d8f"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("dff03732-aea7-476c-b55c-4643de09a30a"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("e2068718-55ce-4173-b8df-48f7c5d59361"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("e302c325-fb15-45e2-8c7c-dda2ff669688"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("e5246c8a-7feb-451f-a6fb-41aa5d5a81db"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("ea4c189c-56ad-4b4e-b518-1e8dc4abae3f"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("ed3bfba5-5b51-4f93-b6d3-be3b1d7a2c87"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("ed9f989f-c9dc-48c8-9aca-07ef210de0dd"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("ef47a919-af35-42ca-a5f7-d35723605c20"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("ef73dc79-4fd6-4c75-8c3d-e5f5bcf54e98"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("f0190cee-d12f-448b-b9b8-aff5a109e6b2"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("f09af2a0-a329-4eea-abdf-813cbeaa1686"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("f1597291-6c7b-4de6-b130-83d50977fdd8"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020") },
                    { new Guid("f1fe435a-0177-41cf-b014-b9cb7cdcb51f"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("f31ed2a1-1245-4437-8fef-1f7ec34847c1"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("f3a1fc57-88ea-4430-a423-c5d238400fc5"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("f3c77957-f39e-443d-ac5f-1376133c176a"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("f4bb5fc0-a30b-4129-b850-e7254dd867fe"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("f6bdb9d2-b935-4901-bf3a-2c22d0447d8e"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a1dca08-c0b8-4706-b020-6c64770f54ef", "AQAAAAIAAYagAAAAENdB+0N/XGn5eKseB5qtrbwzptSb6qBlkPN6JXIqZAjUKWeiMssi9Xxnav38rjnMgw==", "c5b17bdb-2457-4cc6-adbf-fe29a9d8a852" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc67fa20-0990-42eb-b8ee-82146ac5b29b", "AQAAAAIAAYagAAAAEIb3aEXXXEjYdEfqSuFDrDii7CawEJzXJdC3MPt8AdgkNyCpqtv4+drPL98eGbhS7A==", "6e68a110-2aaa-4b75-8d8a-e00e3a35dba0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2722723-be4e-4a0f-8b48-64d22b1c5f65", "AQAAAAIAAYagAAAAEA/C8Yd9EUwNN726CNCS/q76fmDY9ETUD/CAVdHsOjxD7TfxFjPcZUhWnuUQ+0dZlA==", "aa30369c-b146-4f98-9710-2b70fa64aa3a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79d659d5-91c6-4d0c-ab12-3f15de5a60e6", "AQAAAAIAAYagAAAAENhT6war22sgZKtuVBeK19lZ8gDrHELJvvzt62d3n/tSw1wghUyabuaGW1dT96gryw==", "bf420710-ffa6-4858-ba3c-8271b58d606c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92d5f34d-5c82-49be-8562-8f5196a371d2", "AQAAAAIAAYagAAAAEE4CBr6X9kNOmVBtivRDcM0cUl8nsaafYtffPgTobK5t1bmT9cz+Rh9RKzj7Yi3gRg==", "b5862bbb-7ce9-4aa7-8e48-e1f920640af2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52117b61-e9b2-46f8-8022-b311591100ec", "AQAAAAIAAYagAAAAELygl+QFbUGaW5NnADVzk8LDbIoDbsdvU3QQemlgQF0QpeJn6CTmBBmqTZhPJai40g==", "e6ffd6ec-72cf-44a6-80c0-c5f7d3c23259" });
        }
    }
}
