using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateContractTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Rentals_RentalId",
                table: "Contracts");

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("012340a2-b022-4900-b4d6-4533b64e455b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("031100d9-92ed-469c-ac6b-defe6e355654"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0a8849d0-f40d-411f-89ff-60b4789d4323"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0a94de0d-0543-4210-949c-4f6151e98d65"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0add878d-8007-4924-8721-28681a1d7586"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0c4b39c8-8216-47f0-bf9e-3428ad5615ca"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0d508b49-9c4e-4c1c-896b-427b92806c4e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0d5c558b-bb91-4826-9667-225586db70fa"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0d728c97-ebbc-4ce3-91f9-0e6995ef0499"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0e090ea8-afa2-4d87-afa1-2b3f90d7a3f5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("105aa4ef-02fc-49f4-bccc-8644e6616dd7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("107dc7de-710d-4abb-9436-2671bfb8598a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("124bc657-0c1d-4680-bec7-778d2e1d7904"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("125e112b-8247-4a5b-8856-a3ef5992a0ea"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("14a65123-8cc4-4059-b251-7df86982abec"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("15de0ca9-cb1f-4829-a930-03706853ced3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("15f8cec4-f9d5-4f1f-a62c-33d457dfc42a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("179a9857-bb55-4d20-a658-80b80d5ea35e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("17e20750-75e8-4381-848b-f2299f648354"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1825ec47-0535-4350-a69e-375a1e5e421a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("18b7af75-a128-41f8-8e95-e78e53266f31"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1b06041a-4aca-4eb5-9cd4-1cec38934b09"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1d1becb6-0e8a-403c-801a-8104d3b43eee"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1f7ca43c-f58b-44c2-9b2a-696590c09be1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("21a2ef7d-5aa9-4c03-a788-452d3441c056"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("238e7ea5-408c-41d1-b895-7c86e08851f1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2612d94d-335b-44d2-bff9-ea80c738fc1e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("267426d3-1d2b-4fd1-bcbb-b5a53d44bf19"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("278279ea-b43c-4788-8247-89323d7ab8a7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("290bb36b-d0cc-4ce8-b349-125281eefaf5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2a79afd4-660b-4954-940c-345d7708250e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2c31bfe3-24ac-4bd1-90f5-80b917e45bd1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("306f7a45-5a85-41b6-99fe-f02ff2b9457c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("35b4aebd-8a66-49b0-b799-4e92bbaf0a9d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("38a3ecf7-c943-49bb-9b35-8f200270e98b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3d280e22-c40e-458b-9a92-84655d66965f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4323cdde-dc9b-4621-9f16-184e68b488c3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4400bc71-6936-4fca-97f6-fb4773e50431"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("48c0ed23-4cc2-48ff-862c-acc6b381fc0e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("56e44517-e6af-4ad7-85a7-5ceb4b1404aa"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("598a7494-afcf-41c0-9f6d-eeafbe4c7e10"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("59ad3994-08a0-428d-82d5-bfd14943bfc7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5eb18ef4-13c3-4120-959f-80eabbe6eae1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("63d32a40-c264-429a-805e-96191d5d0e91"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("67f4d402-30c7-48c9-a522-81406935257f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("68261740-013b-4045-b16a-e5b4989dcc3c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("696aed47-0963-4a64-8e6b-abcb7bc8b66d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6af81cef-f557-4a19-8921-01c5e958a8c3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6baf4250-44bc-4898-aa91-65d6c9a58b36"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6c8f87dc-856a-4e37-b87d-ba2d312c8930"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6cfbf958-69d0-4be9-a3b6-363c04bdbcd9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6e3a8cec-08c4-4106-841f-f102660965a5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6f8a343d-34b6-47ca-a03a-be6c6011dbdb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("72309fbe-cc86-412f-b2d0-2de746570744"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("752bb9bb-046d-4aa0-8663-62a8152faa9a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("75e86c10-d87e-4c87-ac5e-32df1833fd5e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("76066506-46c7-4b07-b7e5-334ba2c00585"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7680368e-18c9-4525-b8be-3d7b91646d7e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("775fb730-a9f3-40ab-a0ee-f3972a9d4e45"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("79a9cf20-1abe-4100-8dce-789e801c6a27"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7a45c69c-2744-4676-b8e4-6a13876566dc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7aa9f1e3-6b2d-4a6f-8175-6f35d530af6c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7abc42ec-7a7c-467b-b62c-02e9c1df514a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7bb83817-0b16-4305-a9aa-dc5f69827a58"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7c12557d-8bdc-4fa2-b23d-3bd1574e6e55"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7d9e4ef9-95e1-48c8-b695-93bd4e10b303"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7dea957b-fcdf-4c26-adb5-bdb5eca0078b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("817592a0-6c61-49b2-a9db-2925bc47a910"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8216b8e8-62ba-4c26-bc7e-5efc6b379d05"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("828c24bd-9fc3-4376-86ef-27d2985f20d1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8839efb4-fba4-47bb-bc85-713143e99922"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8aea374d-e2f7-4943-9b12-bfd576927593"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8d748cb8-5452-4ae9-9ff9-c6f6aef2e973"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8d8aa155-9c8d-4b32-a178-a4b98313e00a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8e61d901-034f-48e1-99ac-f951d0a30637"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8e641d98-4ef2-43e2-9d94-c07fcd548a67"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9182f708-048d-40b3-b141-e5fc1c3282cb"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("94f86bbf-052f-41f8-9cc5-b4ef8bd6d861"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("972ffb1e-6351-4af4-85b6-90a32000ea83"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9c160b71-d607-42d5-bc69-b101d6bd1092"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a2b98e31-042b-4ba6-ac8a-c779d645be30"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a49c0f59-ec91-4ef6-bdb8-882671e981d2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a7b5ca16-af2b-4290-bec5-08ba95fceef2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("aa0ac6e7-fba3-4fed-80e8-0bb8d5f7e21b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("aa21dba1-c796-47d6-b815-176448503d93"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("aa2929bb-f9bd-48d4-b446-de0037a55cef"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("abfeceb4-a80e-4785-b341-c0ff683e1b46"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ad413ed3-2264-4908-8088-61dbf270fc70"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ad458c6a-062a-4245-85ab-f351140750ef"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("af172fc9-1b7a-4ab2-b2a4-cd1f898b44f6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b0da96f4-2b90-47e0-8c1f-2f067055d085"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b15dbc46-8934-4bc1-977e-4775fb3e13d9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b833b771-b3f1-40d1-82bb-9a12f89d7717"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b872dc9c-0b29-4cae-b5e9-c85904586a4d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b97c1bb7-c800-4dda-9ffd-eca2b0bc1715"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ba4b7432-092d-4da1-a0a6-5d0c16939149"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bab3ce62-6691-4892-b2b3-76c27a910285"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("babd5ec0-7daa-428b-9409-5d3aee44e504"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bc3cf8ae-2d48-4102-8a27-edecdc59d3bf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c2631c03-7f0f-49b0-870f-aded86aa276d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c699ae17-ec79-49bb-8ff5-a26278ecb909"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c776e769-baa3-4f53-92b8-06832942ea22"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cc244a29-60ea-4552-bd33-45b0eae41748"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cee43398-3361-482f-8d22-d8d75072a92e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cf6b0246-9297-48c2-9ba1-40f5e4e20d6f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d1cda5ac-b700-40c2-95c2-d09a6aa8eb60"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d619afe7-afeb-473f-b438-6dff6b45b001"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d9513a73-1558-44c8-adc4-7c5fd55fb976"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("da208f68-68a2-462a-86a6-a44fd93f1d72"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("da3fb926-5f49-4455-80e8-113a27a35e9b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("da7f5933-3ffa-46aa-bc66-42a0cdd25653"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("da91a9af-0676-473d-8964-147d72fc7f1d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("db5e810a-b1c8-4ad2-b5b4-82cf4a667a61"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dc27cd40-97ca-4527-95c7-157cf6746c88"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("de16122b-a499-4b31-96e5-878095147c38"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("df1c3118-05d2-4b79-8160-498f31d28bf3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e0127f04-fb8a-4c31-b9a7-0cce8803ad31"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e055fa2c-88e0-4732-b643-45f2797443ca"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e0bfc09e-85f2-4303-918a-c5f0f03cf62e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e3878780-b062-4b9e-bdfe-1c7d7dced1e8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e648c82a-b9dc-49f7-8521-39dc65b103e8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e83e654c-afe8-4b34-9fad-a0875013aff3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ea086e3a-a2e3-4c9b-b13d-e01f89e83329"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("eaaab36f-009a-4509-bf99-6754425df118"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("eb077bee-680e-4631-b42a-a9baa4c649b4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("eb4c5409-18a2-410a-8fab-7561099c87d1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ee00352e-cc05-4d68-9534-8633539fd5cc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("eee28152-ea2a-41a0-9a38-4e7eefeb87d0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f07ac0d4-c423-4b61-91a2-efbdd2e753ed"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f108f9a9-a469-445f-abde-63ea1adf77bc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f35ee5ea-6dbe-44f4-b15d-ccec03b0a6ea"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f4e188a2-37c9-4de2-97d2-4fd773052f2a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f5a6da6c-c1aa-411a-870d-f72114fa1ea6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fcdc564f-cb12-4cd2-a913-c8e1128f158b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fcf11f49-d504-4478-8c93-486795f7027f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fd2949f8-fb84-40c3-b681-5c9db4e93f26"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fd5366a0-56c7-4b79-a428-a3b160ba7291"));

            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                table: "Contracts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "RentalId",
                table: "Contracts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Contracts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveDate",
                table: "Contracts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ContractTerms",
                table: "Contracts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ContractUrl",
                table: "Contracts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "CarFeatureId", "CarId", "FeatureId" },
                values: new object[,]
                {
                    { new Guid("00b48370-c64e-4877-b83f-9f1ff0779205"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("0383aa76-9e0f-43ab-815a-503740d4ea67"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("067f667a-f837-451a-80be-b656092c46ef"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("07cededd-6eac-4331-a387-bd81ca1e83ec"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("0e3b35b1-d4c3-496b-a481-e9df55f896d5"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020") },
                    { new Guid("0eb65dae-1e6a-4c0a-8475-25b202346e18"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("15af1de8-f681-4025-97cb-88b929b243f5"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("1648bddf-135c-43bb-b8fa-469d1aedbb4f"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("18300fd0-83f9-49ad-89c3-249aeaa14c5b"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("1c1d9ac1-485e-4792-9bc4-4718d4e6bb0f"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("1cf48342-2d00-4399-88b9-2ef00f261bac"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("1e1efa40-c328-4238-99ff-254d4eb6a7e0"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("20814e20-d4b3-4d98-ab2f-45f1fec3ae54"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("20abec5d-d058-4612-bbd7-4064ff58c1df"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("296c54ad-b451-460c-a582-65baa012017e"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("2cc480be-696b-4557-b047-4ad966b39cd1"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("30521942-e87f-4305-b052-87d9df0dd667"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("319a6ea8-7301-44be-94b1-f4a886573b55"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("324bc1dc-7838-4152-b032-1b3717991104"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("32a985b5-b4fd-4f02-a65e-b20c12160ab5"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("332f2713-2644-488e-82f1-f1696195c652"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("37d6681f-2773-4e34-afa4-bc33d72534fa"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("3b0b0210-d655-4097-8015-b8be0c3f559c"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("3b2307c5-ccd5-4665-b5cc-b216283d057a"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("3c1aad26-ae66-4e9f-b283-16b484c4c291"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("3d61af14-4232-4f34-961c-4cb5828252e3"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("4212c042-5e63-4d36-a9c1-8ff983dbc3b8"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("42e4e493-e6d2-46b4-a792-321b638acbe8"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("4365445e-06e6-4bf2-8034-548320a77553"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("458989c4-948a-4d6f-bb77-229454164529"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("491b0f1a-da60-4e00-a8d5-7ef5cf3af264"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("49c0cc8a-2c3b-4732-bb8c-371b2325b44f"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("4c107cf6-f1ca-4c7b-afb7-5bb0360a4ecf"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("4d89b1b0-2550-4136-93df-16e9ae0f06f7"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("5007d6e8-baca-4cad-a3f6-ecfdb088d49b"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("5138eebf-173a-49d9-8ca7-11d7950622ae"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("52239970-405f-4064-ac0a-0c6a4c9da2ef"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("56090c0c-ed0f-40c6-8fec-2b31d8c652d1"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("567fa91e-d7d7-4e3c-80f4-66adab66eb19"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("6129f44b-58ea-495c-a2fc-5006ba257d17"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("63ca3c78-521b-435c-b3e5-32670719518a"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("6454fc57-55c1-452c-afc1-6ac14baa2b10"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("6b488e54-42f9-44e7-bf3a-46814044efbe"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("6e08e318-a31c-49f9-a8b7-5fda8ae3794c"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("6f7c04dc-1d81-4c0b-ab97-cd0ab9b9a750"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("74adf8bd-2c8a-4927-a83e-5aef5e917694"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("759dd2f6-7fc3-4ecf-85ca-dfb8b5754fb8"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("76ab5e31-ba63-46b2-b312-34542a263b53"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("7729471e-f190-4ee9-92a0-d42b07e9cca7"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("777ea0cf-1369-4619-a99e-b5110959b987"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("786d16e9-fc84-4a53-9070-caac0d1fb12a"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("798553b8-c5f4-443b-8722-d710a48af0c9"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("7a93cd66-33a5-4b25-a6e5-e3cd91ae2483"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("7abc20cf-cfe4-420a-9a49-22b9fe1e2294"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("7c314a98-87e3-47a2-aab5-3ca42e0d536a"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("81346623-d891-4472-ad4f-9e98320a464e"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("841c5ca2-aa92-4291-96d7-505b86c1c9bf"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("845037d9-ef1b-47c0-8efe-597c40d0fd0a"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("849a39f3-6dc8-436f-983d-c6d4958ceb26"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("89afbc38-d45c-4335-a040-271237706f57"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("8ae5147b-c92a-4a35-a7a1-dcc3cd681127"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("8d14d468-bc88-4557-86bb-8de8c3dd3d20"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("8ebc0ba3-1ab1-4136-b5bf-efb77afa4919"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("937b233f-9fb6-4ee2-8809-dd0be93bb564"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("960c66d7-40e1-401d-a2ee-4c1ba8bbac1a"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("965360cb-ca87-4b3f-be3a-0b50ca84b972"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("978bc9d7-d63a-487b-9506-d1832abfc1c7"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("9793d5bf-3d21-4f97-bc60-f478bb411a3c"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("9849134a-7a01-4770-a16f-b8fde41ff42f"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("989399fa-9853-4b49-88f9-9dcd08fd9706"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("989a1337-c022-4343-81dd-2f5ba1e1fb7f"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("998f4106-4799-466a-8674-2c1787dfbff7"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("9ac4f19b-5c38-4540-bc34-03c597b1e0f5"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("9accf38f-8446-4a9d-a54e-c80e87cda818"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("9e0e45a0-b8d1-472e-8e29-e980b1026fbe"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("9f0faf43-f58d-4013-94ee-e8ae9331a645"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("a23d0028-94bf-4a5f-91c1-fe2068ba751d"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("a43f9323-a175-48b6-9fe0-238e592a1bec"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("a4675e17-28f7-4f8b-8617-22ec20c196ab"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("a4960b5c-5031-4fdc-9a8d-2a71d76a01ac"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("a61c0d8e-f9f1-48b3-bf11-9150f4869b8c"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("a8b5709f-130c-4bc8-9914-639fa8b096f4"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("a9aaec7e-6a50-4d67-b748-c0f12971be36"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("af5ac078-2fff-4090-86b0-c25d7d83deed"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("afbd832f-ede7-41a9-b4ad-0d215e4c83a7"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("afd7494b-3b0a-4c19-91d8-3cabd26b6f19"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("b2bd9595-f43f-49de-b3a1-bb7fc0e72137"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("b42bd488-29bc-4f6e-9316-42a89ee8ca40"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("b5477e3f-09de-4a51-bcca-e0b3ad9a438f"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("b5f3dddc-6784-4ba3-abba-f012ffb42103"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("b62fd9cf-f1b3-4a65-841b-23f6515f7a80"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("b6b5810d-8af3-4378-b8ca-51a44b17a4ac"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("b8645fb2-0826-4884-82fd-ab546d3bbfc9"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("bacf1384-06c3-4515-9c42-559c886aecfc"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("bbbb6520-f1c4-4163-b8ff-0ca22a7f2800"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("bcbfd934-8fdc-46ff-9a33-690a13613a7f"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("be6942c2-02ca-461b-ae1b-b3374b1393a2"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("bf608cb1-666d-4df6-93a1-a94ba070e01c"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("c00b8130-91fb-43e6-b059-6c2fabd7aef0"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("c201d438-eff3-4b76-97af-721f0b673aa8"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("c840f944-8582-43b1-9ad6-074157d23210"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("c85d57d8-2f54-4874-ae23-78f900ef86ae"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("c88ac067-6e6a-4cd0-a7ce-3bce4a524348"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("c91be899-7615-4dc3-86ff-cedb635c8ce1"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("cafacdcf-f54c-4b43-b16f-a4a7e01a8ca3"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("cd20a912-ddc3-4b5e-aec2-e418005827d5"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("cd6f43f8-9c99-4e4f-895d-3d23a26a62a3"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("ce6b464d-f01d-4668-b9a5-735452ffb71c"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("ce760028-8655-4433-81a6-99978063fc25"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("ceed4692-d63f-4b96-8eb8-de8fbb071031"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("d202f8ba-c31c-4f8d-980b-2611350fa2ef"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("d2896780-dea4-4769-a5ec-17112f3677e6"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("d3d93963-ed65-4247-972b-0afa3667f654"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("d4a86008-2dd2-411b-808d-161af05fa72c"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("d58e3903-cffe-42d4-9658-f705ba3be5b8"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("d6e2508f-8b6e-46b6-98d4-964c42aae2f9"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("d968c829-9710-41c6-ad91-3507226ae23d"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("d989a3dc-c47b-4a3a-b1d6-319be6292b51"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("db177da1-b81c-437a-8819-0aef4ce362e9"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("dc80ed5c-4a44-486a-9dd1-64f32b792707"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("dc8fd8cb-25cd-468f-a741-682880c40156"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("dd298810-8387-4963-bcb3-9c5b5d61c2c5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("dd7ba97c-01f5-450b-ade1-2344439fa7c7"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("e0b9188f-c529-4f17-a3e0-335aa41b871b"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("e36309d0-2a4f-4386-9f29-8cc9999de5df"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("e4b4aab8-4eb8-4055-b3dd-fefb7aec65e6"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("e729d1e0-2ce3-4ba7-858d-892d92040471"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("e7fe58a5-0b48-47e3-a02d-61c170cdcdfe"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("eb6820c4-d294-49e9-8404-bc482afe597a"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("eea57663-ee75-4620-bb43-d8693ed9bada"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("f27cebe6-86be-4d77-ba53-2798d5a61d5a"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("f569f45f-a1c7-47eb-8c0d-e44e348a7222"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("fa3088fa-7f9e-475b-9011-f429f97670e3"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("fa46ba5c-0487-4663-b5d1-b1628ce91179"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("fb608ebb-2455-465a-83d0-e8505f83bcb0"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("fd9000a2-f363-43af-8f48-68a2eadf0d24"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("ffa68482-b05d-4197-a3b5-561e0cb185a7"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "807a55d3-629d-46bb-be21-538d4e239c88", "AQAAAAIAAYagAAAAEHP77Q5hybyVW+453MZsYTke/LwaPpEdEuIvltfLdALT4ZJ5Ese+tk1U4R8eDs9Dtg==", "678a74b6-e8a2-4e80-a4cf-95d4a02c4c0d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8155cf8a-3c0c-4bfe-ad5b-adffc63153bb", "AQAAAAIAAYagAAAAEFaz9OYb4n28RsLy6hMao+Nz6CpBoUXB3SFXipZ3I+XqIp1oRWjojl/lmo1j60uugQ==", "d6c5e8d6-5915-45f0-a69a-c510ac3bd99e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92a32a49-8efe-4efd-b58f-9c73e5fdabd4", "AQAAAAIAAYagAAAAEFIhDBxYRhlitCD4nVLK/UmTL9cSltGA6WpV5rG/PrXqwfNrWexJdZOHpmvRGypLRA==", "4a8167e1-1df3-4c4a-a23b-627d5498f878" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b690a3e-7097-4352-a864-58477fc3e522", "AQAAAAIAAYagAAAAEP0QR8HPKksgbiD8wv8apbTdJoDHWB9dID2bFUPMIlmu8a0c+LFA2ChzFYy5hhXGTw==", "dbbc22f7-f968-4a98-a8e8-93463eddd963" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f102203-8160-4228-8c35-a9265da9562e", "AQAAAAIAAYagAAAAEHTKDW/aTH6rc4v7NNMHfPVA+1LTo/STQQ99z4j5lcHHGLQCNNrHEN1hF+qcMKP0SQ==", "7a16fd14-a847-48c2-9d1d-b7d1476e4f5b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6402dd74-aa67-4034-8312-ed2b9f35b43f", "AQAAAAIAAYagAAAAENMefewt5Qixk5XL3r0RuDW213AIaEFUuZoSmLG2OiWYLNXUUni8sArluIDad+b5vw==", "837c765c-dcab-40a2-a56c-53d1433deaa0" });

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Rentals_RentalId",
                table: "Contracts",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "RentalId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Rentals_RentalId",
                table: "Contracts");

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("00b48370-c64e-4877-b83f-9f1ff0779205"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0383aa76-9e0f-43ab-815a-503740d4ea67"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("067f667a-f837-451a-80be-b656092c46ef"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("07cededd-6eac-4331-a387-bd81ca1e83ec"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0e3b35b1-d4c3-496b-a481-e9df55f896d5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("0eb65dae-1e6a-4c0a-8475-25b202346e18"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("15af1de8-f681-4025-97cb-88b929b243f5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1648bddf-135c-43bb-b8fa-469d1aedbb4f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("18300fd0-83f9-49ad-89c3-249aeaa14c5b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1c1d9ac1-485e-4792-9bc4-4718d4e6bb0f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1cf48342-2d00-4399-88b9-2ef00f261bac"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("1e1efa40-c328-4238-99ff-254d4eb6a7e0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("20814e20-d4b3-4d98-ab2f-45f1fec3ae54"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("20abec5d-d058-4612-bbd7-4064ff58c1df"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("296c54ad-b451-460c-a582-65baa012017e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("2cc480be-696b-4557-b047-4ad966b39cd1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("30521942-e87f-4305-b052-87d9df0dd667"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("319a6ea8-7301-44be-94b1-f4a886573b55"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("324bc1dc-7838-4152-b032-1b3717991104"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("32a985b5-b4fd-4f02-a65e-b20c12160ab5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("332f2713-2644-488e-82f1-f1696195c652"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("37d6681f-2773-4e34-afa4-bc33d72534fa"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3b0b0210-d655-4097-8015-b8be0c3f559c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3b2307c5-ccd5-4665-b5cc-b216283d057a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3c1aad26-ae66-4e9f-b283-16b484c4c291"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("3d61af14-4232-4f34-961c-4cb5828252e3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4212c042-5e63-4d36-a9c1-8ff983dbc3b8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("42e4e493-e6d2-46b4-a792-321b638acbe8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4365445e-06e6-4bf2-8034-548320a77553"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("458989c4-948a-4d6f-bb77-229454164529"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("491b0f1a-da60-4e00-a8d5-7ef5cf3af264"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("49c0cc8a-2c3b-4732-bb8c-371b2325b44f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4c107cf6-f1ca-4c7b-afb7-5bb0360a4ecf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("4d89b1b0-2550-4136-93df-16e9ae0f06f7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5007d6e8-baca-4cad-a3f6-ecfdb088d49b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("5138eebf-173a-49d9-8ca7-11d7950622ae"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("52239970-405f-4064-ac0a-0c6a4c9da2ef"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("56090c0c-ed0f-40c6-8fec-2b31d8c652d1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("567fa91e-d7d7-4e3c-80f4-66adab66eb19"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6129f44b-58ea-495c-a2fc-5006ba257d17"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("63ca3c78-521b-435c-b3e5-32670719518a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6454fc57-55c1-452c-afc1-6ac14baa2b10"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6b488e54-42f9-44e7-bf3a-46814044efbe"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6e08e318-a31c-49f9-a8b7-5fda8ae3794c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("6f7c04dc-1d81-4c0b-ab97-cd0ab9b9a750"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("74adf8bd-2c8a-4927-a83e-5aef5e917694"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("759dd2f6-7fc3-4ecf-85ca-dfb8b5754fb8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("76ab5e31-ba63-46b2-b312-34542a263b53"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7729471e-f190-4ee9-92a0-d42b07e9cca7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("777ea0cf-1369-4619-a99e-b5110959b987"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("786d16e9-fc84-4a53-9070-caac0d1fb12a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("798553b8-c5f4-443b-8722-d710a48af0c9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7a93cd66-33a5-4b25-a6e5-e3cd91ae2483"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7abc20cf-cfe4-420a-9a49-22b9fe1e2294"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("7c314a98-87e3-47a2-aab5-3ca42e0d536a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("81346623-d891-4472-ad4f-9e98320a464e"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("841c5ca2-aa92-4291-96d7-505b86c1c9bf"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("845037d9-ef1b-47c0-8efe-597c40d0fd0a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("849a39f3-6dc8-436f-983d-c6d4958ceb26"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("89afbc38-d45c-4335-a040-271237706f57"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8ae5147b-c92a-4a35-a7a1-dcc3cd681127"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8d14d468-bc88-4557-86bb-8de8c3dd3d20"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("8ebc0ba3-1ab1-4136-b5bf-efb77afa4919"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("937b233f-9fb6-4ee2-8809-dd0be93bb564"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("960c66d7-40e1-401d-a2ee-4c1ba8bbac1a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("965360cb-ca87-4b3f-be3a-0b50ca84b972"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("978bc9d7-d63a-487b-9506-d1832abfc1c7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9793d5bf-3d21-4f97-bc60-f478bb411a3c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9849134a-7a01-4770-a16f-b8fde41ff42f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("989399fa-9853-4b49-88f9-9dcd08fd9706"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("989a1337-c022-4343-81dd-2f5ba1e1fb7f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("998f4106-4799-466a-8674-2c1787dfbff7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9ac4f19b-5c38-4540-bc34-03c597b1e0f5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9accf38f-8446-4a9d-a54e-c80e87cda818"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9e0e45a0-b8d1-472e-8e29-e980b1026fbe"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("9f0faf43-f58d-4013-94ee-e8ae9331a645"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a23d0028-94bf-4a5f-91c1-fe2068ba751d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a43f9323-a175-48b6-9fe0-238e592a1bec"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a4675e17-28f7-4f8b-8617-22ec20c196ab"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a4960b5c-5031-4fdc-9a8d-2a71d76a01ac"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a61c0d8e-f9f1-48b3-bf11-9150f4869b8c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a8b5709f-130c-4bc8-9914-639fa8b096f4"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("a9aaec7e-6a50-4d67-b748-c0f12971be36"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("af5ac078-2fff-4090-86b0-c25d7d83deed"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("afbd832f-ede7-41a9-b4ad-0d215e4c83a7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("afd7494b-3b0a-4c19-91d8-3cabd26b6f19"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b2bd9595-f43f-49de-b3a1-bb7fc0e72137"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b42bd488-29bc-4f6e-9316-42a89ee8ca40"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b5477e3f-09de-4a51-bcca-e0b3ad9a438f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b5f3dddc-6784-4ba3-abba-f012ffb42103"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b62fd9cf-f1b3-4a65-841b-23f6515f7a80"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b6b5810d-8af3-4378-b8ca-51a44b17a4ac"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("b8645fb2-0826-4884-82fd-ab546d3bbfc9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bacf1384-06c3-4515-9c42-559c886aecfc"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bbbb6520-f1c4-4163-b8ff-0ca22a7f2800"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bcbfd934-8fdc-46ff-9a33-690a13613a7f"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("be6942c2-02ca-461b-ae1b-b3374b1393a2"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("bf608cb1-666d-4df6-93a1-a94ba070e01c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c00b8130-91fb-43e6-b059-6c2fabd7aef0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c201d438-eff3-4b76-97af-721f0b673aa8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c840f944-8582-43b1-9ad6-074157d23210"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c85d57d8-2f54-4874-ae23-78f900ef86ae"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c88ac067-6e6a-4cd0-a7ce-3bce4a524348"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("c91be899-7615-4dc3-86ff-cedb635c8ce1"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cafacdcf-f54c-4b43-b16f-a4a7e01a8ca3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cd20a912-ddc3-4b5e-aec2-e418005827d5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("cd6f43f8-9c99-4e4f-895d-3d23a26a62a3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ce6b464d-f01d-4668-b9a5-735452ffb71c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ce760028-8655-4433-81a6-99978063fc25"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ceed4692-d63f-4b96-8eb8-de8fbb071031"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d202f8ba-c31c-4f8d-980b-2611350fa2ef"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d2896780-dea4-4769-a5ec-17112f3677e6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d3d93963-ed65-4247-972b-0afa3667f654"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d4a86008-2dd2-411b-808d-161af05fa72c"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d58e3903-cffe-42d4-9658-f705ba3be5b8"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d6e2508f-8b6e-46b6-98d4-964c42aae2f9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d968c829-9710-41c6-ad91-3507226ae23d"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("d989a3dc-c47b-4a3a-b1d6-319be6292b51"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("db177da1-b81c-437a-8819-0aef4ce362e9"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dc80ed5c-4a44-486a-9dd1-64f32b792707"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dc8fd8cb-25cd-468f-a741-682880c40156"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dd298810-8387-4963-bcb3-9c5b5d61c2c5"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("dd7ba97c-01f5-450b-ade1-2344439fa7c7"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e0b9188f-c529-4f17-a3e0-335aa41b871b"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e36309d0-2a4f-4386-9f29-8cc9999de5df"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e4b4aab8-4eb8-4055-b3dd-fefb7aec65e6"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e729d1e0-2ce3-4ba7-858d-892d92040471"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("e7fe58a5-0b48-47e3-a02d-61c170cdcdfe"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("eb6820c4-d294-49e9-8404-bc482afe597a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("eea57663-ee75-4620-bb43-d8693ed9bada"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f27cebe6-86be-4d77-ba53-2798d5a61d5a"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("f569f45f-a1c7-47eb-8c0d-e44e348a7222"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fa3088fa-7f9e-475b-9011-f429f97670e3"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fa46ba5c-0487-4663-b5d1-b1628ce91179"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fb608ebb-2455-465a-83d0-e8505f83bcb0"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("fd9000a2-f363-43af-8f48-68a2eadf0d24"));

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "CarFeatureId",
                keyValue: new Guid("ffa68482-b05d-4197-a3b5-561e0cb185a7"));

            migrationBuilder.DropColumn(
                name: "ContractUrl",
                table: "Contracts");

            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                table: "Contracts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RentalId",
                table: "Contracts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Contracts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveDate",
                table: "Contracts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContractTerms",
                table: "Contracts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "CarFeatureId", "CarId", "FeatureId" },
                values: new object[,]
                {
                    { new Guid("012340a2-b022-4900-b4d6-4533b64e455b"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("031100d9-92ed-469c-ac6b-defe6e355654"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("0a8849d0-f40d-411f-89ff-60b4789d4323"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("0a94de0d-0543-4210-949c-4f6151e98d65"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("0add878d-8007-4924-8721-28681a1d7586"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("0c4b39c8-8216-47f0-bf9e-3428ad5615ca"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("0d508b49-9c4e-4c1c-896b-427b92806c4e"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("0d5c558b-bb91-4826-9667-225586db70fa"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("0d728c97-ebbc-4ce3-91f9-0e6995ef0499"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("0e090ea8-afa2-4d87-afa1-2b3f90d7a3f5"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("105aa4ef-02fc-49f4-bccc-8644e6616dd7"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("107dc7de-710d-4abb-9436-2671bfb8598a"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("124bc657-0c1d-4680-bec7-778d2e1d7904"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("125e112b-8247-4a5b-8856-a3ef5992a0ea"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("14a65123-8cc4-4059-b251-7df86982abec"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("15de0ca9-cb1f-4829-a930-03706853ced3"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("15f8cec4-f9d5-4f1f-a62c-33d457dfc42a"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("179a9857-bb55-4d20-a658-80b80d5ea35e"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("17e20750-75e8-4381-848b-f2299f648354"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("1825ec47-0535-4350-a69e-375a1e5e421a"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("18b7af75-a128-41f8-8e95-e78e53266f31"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("1b06041a-4aca-4eb5-9cd4-1cec38934b09"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("1d1becb6-0e8a-403c-801a-8104d3b43eee"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("1f7ca43c-f58b-44c2-9b2a-696590c09be1"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("21a2ef7d-5aa9-4c03-a788-452d3441c056"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("238e7ea5-408c-41d1-b895-7c86e08851f1"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("2612d94d-335b-44d2-bff9-ea80c738fc1e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("267426d3-1d2b-4fd1-bcbb-b5a53d44bf19"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("278279ea-b43c-4788-8247-89323d7ab8a7"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("290bb36b-d0cc-4ce8-b349-125281eefaf5"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("2a79afd4-660b-4954-940c-345d7708250e"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("2c31bfe3-24ac-4bd1-90f5-80b917e45bd1"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("306f7a45-5a85-41b6-99fe-f02ff2b9457c"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("35b4aebd-8a66-49b0-b799-4e92bbaf0a9d"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("38a3ecf7-c943-49bb-9b35-8f200270e98b"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("3d280e22-c40e-458b-9a92-84655d66965f"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("4323cdde-dc9b-4621-9f16-184e68b488c3"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("4400bc71-6936-4fca-97f6-fb4773e50431"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("48c0ed23-4cc2-48ff-862c-acc6b381fc0e"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("56e44517-e6af-4ad7-85a7-5ceb4b1404aa"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("598a7494-afcf-41c0-9f6d-eeafbe4c7e10"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("59ad3994-08a0-428d-82d5-bfd14943bfc7"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("5eb18ef4-13c3-4120-959f-80eabbe6eae1"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("63d32a40-c264-429a-805e-96191d5d0e91"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("67f4d402-30c7-48c9-a522-81406935257f"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("68261740-013b-4045-b16a-e5b4989dcc3c"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("696aed47-0963-4a64-8e6b-abcb7bc8b66d"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("6af81cef-f557-4a19-8921-01c5e958a8c3"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("6baf4250-44bc-4898-aa91-65d6c9a58b36"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("6c8f87dc-856a-4e37-b87d-ba2d312c8930"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("6cfbf958-69d0-4be9-a3b6-363c04bdbcd9"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("6e3a8cec-08c4-4106-841f-f102660965a5"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("6f8a343d-34b6-47ca-a03a-be6c6011dbdb"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("72309fbe-cc86-412f-b2d0-2de746570744"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("752bb9bb-046d-4aa0-8663-62a8152faa9a"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("75e86c10-d87e-4c87-ac5e-32df1833fd5e"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("76066506-46c7-4b07-b7e5-334ba2c00585"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("7680368e-18c9-4525-b8be-3d7b91646d7e"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("775fb730-a9f3-40ab-a0ee-f3972a9d4e45"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("79a9cf20-1abe-4100-8dce-789e801c6a27"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("7a45c69c-2744-4676-b8e4-6a13876566dc"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("7aa9f1e3-6b2d-4a6f-8175-6f35d530af6c"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("7abc42ec-7a7c-467b-b62c-02e9c1df514a"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("7bb83817-0b16-4305-a9aa-dc5f69827a58"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("7c12557d-8bdc-4fa2-b23d-3bd1574e6e55"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("7d9e4ef9-95e1-48c8-b695-93bd4e10b303"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("7dea957b-fcdf-4c26-adb5-bdb5eca0078b"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("817592a0-6c61-49b2-a9db-2925bc47a910"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("8216b8e8-62ba-4c26-bc7e-5efc6b379d05"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("828c24bd-9fc3-4376-86ef-27d2985f20d1"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("8839efb4-fba4-47bb-bc85-713143e99922"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("8aea374d-e2f7-4943-9b12-bfd576927593"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("8d748cb8-5452-4ae9-9ff9-c6f6aef2e973"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("8d8aa155-9c8d-4b32-a178-a4b98313e00a"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("8e61d901-034f-48e1-99ac-f951d0a30637"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("8e641d98-4ef2-43e2-9d94-c07fcd548a67"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("9182f708-048d-40b3-b141-e5fc1c3282cb"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("94f86bbf-052f-41f8-9cc5-b4ef8bd6d861"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("972ffb1e-6351-4af4-85b6-90a32000ea83"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("9c160b71-d607-42d5-bc69-b101d6bd1092"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("a2b98e31-042b-4ba6-ac8a-c779d645be30"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("a49c0f59-ec91-4ef6-bdb8-882671e981d2"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("a7b5ca16-af2b-4290-bec5-08ba95fceef2"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("aa0ac6e7-fba3-4fed-80e8-0bb8d5f7e21b"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("aa21dba1-c796-47d6-b815-176448503d93"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("aa2929bb-f9bd-48d4-b446-de0037a55cef"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("abfeceb4-a80e-4785-b341-c0ff683e1b46"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("ad413ed3-2264-4908-8088-61dbf270fc70"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("ad458c6a-062a-4245-85ab-f351140750ef"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("af172fc9-1b7a-4ab2-b2a4-cd1f898b44f6"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("b0da96f4-2b90-47e0-8c1f-2f067055d085"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("b15dbc46-8934-4bc1-977e-4775fb3e13d9"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("b833b771-b3f1-40d1-82bb-9a12f89d7717"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("b872dc9c-0b29-4cae-b5e9-c85904586a4d"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("b97c1bb7-c800-4dda-9ffd-eca2b0bc1715"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("ba4b7432-092d-4da1-a0a6-5d0c16939149"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("bab3ce62-6691-4892-b2b3-76c27a910285"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("babd5ec0-7daa-428b-9409-5d3aee44e504"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("bc3cf8ae-2d48-4102-8a27-edecdc59d3bf"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("c2631c03-7f0f-49b0-870f-aded86aa276d"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("c699ae17-ec79-49bb-8ff5-a26278ecb909"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("c776e769-baa3-4f53-92b8-06832942ea22"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("cc244a29-60ea-4552-bd33-45b0eae41748"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("cee43398-3361-482f-8d22-d8d75072a92e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("cf6b0246-9297-48c2-9ba1-40f5e4e20d6f"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("d1cda5ac-b700-40c2-95c2-d09a6aa8eb60"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("d619afe7-afeb-473f-b438-6dff6b45b001"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("d9513a73-1558-44c8-adc4-7c5fd55fb976"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("da208f68-68a2-462a-86a6-a44fd93f1d72"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("da3fb926-5f49-4455-80e8-113a27a35e9b"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("da7f5933-3ffa-46aa-bc66-42a0cdd25653"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("da91a9af-0676-473d-8964-147d72fc7f1d"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("db5e810a-b1c8-4ad2-b5b4-82cf4a667a61"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("dc27cd40-97ca-4527-95c7-157cf6746c88"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("de16122b-a499-4b31-96e5-878095147c38"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("df1c3118-05d2-4b79-8160-498f31d28bf3"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("e0127f04-fb8a-4c31-b9a7-0cce8803ad31"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("e055fa2c-88e0-4732-b643-45f2797443ca"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("e0bfc09e-85f2-4303-918a-c5f0f03cf62e"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("e3878780-b062-4b9e-bdfe-1c7d7dced1e8"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("e648c82a-b9dc-49f7-8521-39dc65b103e8"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("e83e654c-afe8-4b34-9fad-a0875013aff3"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("ea086e3a-a2e3-4c9b-b13d-e01f89e83329"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("eaaab36f-009a-4509-bf99-6754425df118"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("eb077bee-680e-4631-b42a-a9baa4c649b4"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("eb4c5409-18a2-410a-8fab-7561099c87d1"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("ee00352e-cc05-4d68-9534-8633539fd5cc"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("eee28152-ea2a-41a0-9a38-4e7eefeb87d0"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("f07ac0d4-c423-4b61-91a2-efbdd2e753ed"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("f108f9a9-a469-445f-abde-63ea1adf77bc"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("f35ee5ea-6dbe-44f4-b15d-ccec03b0a6ea"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("f4e188a2-37c9-4de2-97d2-4fd773052f2a"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("f5a6da6c-c1aa-411a-870d-f72114fa1ea6"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("fcdc564f-cb12-4cd2-a913-c8e1128f158b"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020") },
                    { new Guid("fcf11f49-d504-4478-8c93-486795f7027f"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("fd2949f8-fb84-40c3-b681-5c9db4e93f26"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("fd5366a0-56c7-4b79-a428-a3b160ba7291"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cb0fb1e-6ea7-4d93-be9f-2709d9c84257", "AQAAAAIAAYagAAAAEDWrOICcxgLjA8iApnmHa/5ZDlN5Gn1KlOAU5GnPcyyGbVa+/jHgaJy+OgpPv7JQtQ==", "cbbc4a78-a8e0-4e33-8389-58a8138e545d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6d9d8a0-40e8-4180-b03e-abf6feb233c0", "AQAAAAIAAYagAAAAEFgXMz6BRR6E7hSraLzbJXkk5Yhp5EX3V7zyU4K/7OJTcIjn3PgIuUz2/O3EfXOvUQ==", "5fb4e3ef-1db7-4c86-ace1-5b8b22b51497" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a52a3957-105e-48c5-830e-127c33966747", "AQAAAAIAAYagAAAAEPOMmJb1gVi8DdQ1Z/8jaogex1jtib4MJfAZ5jfLz3LCreZEbLdfj+HCMeLGMbPtVw==", "e1bbe5c7-9b56-403d-87ac-8a5be996e1f7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7037f6b6-1432-4eac-8b91-fe4455c240b4", "AQAAAAIAAYagAAAAEF1GjmvArnQ4dbESXeumm9GX7HQqUqOOXv1YwEwKs0acuCb7uGnLUaxJpYeoyItAPQ==", "e1b38432-24df-4bff-91db-551fb8eaf79e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "284dcc83-b608-4d94-9b6b-d09d323c44dc", "AQAAAAIAAYagAAAAEDkl/VkpCQ1YtyYasYFYNy5+fxkTIOWPSifL7HEo3f0XrZ/YFDelnFNt5KUIIbek9g==", "7514c670-4c00-41c8-8d1c-95e7d631fff8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa3505e7-07f0-437e-8c1a-4ede66751ab9", "AQAAAAIAAYagAAAAEBN4LQDDNjdPdTVXvdi3V8didObOqoIGkJcTH28ahITIq0oqfudfljequmvWbms/JQ==", "37023f67-9980-4841-acd6-ca5648050401" });

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Rentals_RentalId",
                table: "Contracts",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "RentalId");
        }
    }
}
