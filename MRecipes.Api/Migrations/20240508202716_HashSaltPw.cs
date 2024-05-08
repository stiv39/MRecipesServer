using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MRecipes.Api.Migrations
{
    /// <inheritdoc />
    public partial class HashSaltPw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleComments",
                keyColumn: "Id",
                keyValue: new Guid("10fc697f-bf54-424a-95ac-39222134e86e"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("0876e03a-035e-4072-b2f5-c9439d0b1c39"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("09dfc3b0-4f11-41d5-9671-9c8aa8d534ed"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("1795c653-6428-404b-b4a4-c0c66b64b16d"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("17cb6e38-c01d-4c3f-8549-2b4bcc2af302"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("1948a652-f5f2-41b7-af74-c329b248019b"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("2573f26c-6e6a-4c44-b456-e9df38972792"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("2a95defa-90fc-440c-b42c-8c7d8e16312c"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("3f82ecab-79f4-4798-8c46-a5a1bf44b251"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("46104c9e-bc3d-4cae-a0c9-8128ebb1a0d7"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("4c30d0d9-e194-4e07-9315-921efa725f79"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("5c135a01-e2fb-4554-9117-1ca26dfda6df"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("5f8ee199-8c09-47f1-9251-4b9418be1500"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("66db1dc9-bc79-42e9-98b5-135e95947507"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("732d4a22-fc49-45cc-8c0d-a4fae74e1d67"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("91c80069-0bbf-43d0-abb4-be0fc743c5d2"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("aea952dd-64dc-4e87-848c-07285b405992"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("b351109a-2e45-4295-9b26-20cb513b49af"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("bef3d572-16b2-43cb-8d17-c481c46d107d"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("d5055ef5-d0b7-4233-bb04-f16283663c8b"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("d7302f55-66ad-40ba-93fa-f7eb1e6f8f7f"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("26172a51-e541-40f2-8b7a-4fc1ed6090f4"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("2f30ded7-39f7-4390-9c64-d91f491f0298"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("2f8b125e-7507-4545-a0d9-0d2de15c02c0"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("3d99bc5e-2904-452b-842b-fdcbd6f6db2d"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("4507734c-c3d7-493f-ab23-b289e61153b9"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("49ff44a4-d03c-4872-bae4-71554cb0d653"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("4f3bfa91-0c0d-4779-829e-d6e9b4409863"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("53022b16-3192-4220-91cd-ee2c3ad3a2ce"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("59e594de-ced4-4cbd-a73d-3d126ed5c04c"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("5d1b5655-c9bf-4848-93cf-b394acc6da7b"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("5f7804e3-91c9-42a9-9e99-29e09242667a"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("6bfef51d-3533-4db4-9990-880f349949ac"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("726651a2-4537-4483-9961-b71f4198bc14"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("791a9472-20b6-4700-acbc-dcf992236b35"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("854b5ac1-7ce1-435b-9012-7c90c0afbcaf"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("863ac28e-5398-4876-acc8-68280bdbb6d6"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("86c8cfff-ac8c-4dc6-b335-7168ac4ddef5"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("90ed20d1-84fc-4322-8c9c-ff8357e7c7db"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("9350253f-fcb2-4bf9-a1f5-5af123233df1"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("9b892ffe-51ce-4299-99cd-cb0e91a49657"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("9da697e4-5752-4c60-a275-75176ccf1406"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("b59e2366-6f66-4a6a-a3a1-512503dce3f3"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("bb5b89d7-5834-4c44-92c7-c03b6a926842"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("bc630790-23bd-4a22-bf7c-6a1858678d7a"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("bed2cd0e-0d3f-40e7-a420-fb4511a7ad22"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("bf81614e-19d9-4334-a92b-c2eb22a1e5c6"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("cbec752d-0c77-4cf4-b6e3-527d82407a8e"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("cc8a01bb-ffb3-4822-b0b1-0815796e5cb0"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("e11c3dd2-ed4f-4714-a9b6-4890f6cf963a"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("e8f4df34-75c0-4ba9-8947-acb02a9f608a"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("ec7fc74a-cecd-4efb-ae50-6f220751b04d"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("0d847b0d-1e4c-45c8-adb2-22224def78f1"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("3fad7a2e-5fca-46b2-8139-0f808e3735fe"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("53705a07-feeb-4ecf-ac40-0afd0f23326b"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("943fdffb-a2b1-4a97-9823-12f37759d908"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("9d3b8994-9270-4e29-95ac-fdbc61fe8c97"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("a091f670-738b-4595-a201-73689dbe9da6"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("c34151f9-1f9d-49f8-a060-faf7901312f1"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("df1aaa9b-ae31-44ce-9b41-53010b8651b8"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("e97740eb-8fca-44fa-b303-bc976bb8c285"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c754691-fff0-4738-82dc-f9c4daffeadd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6105e9f8-da03-400b-a703-28dbafd9a95d"));

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "PasswordSalt");

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 22, 27, 16, 241, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 7, 22, 27, 16, 241, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 28, 22, 27, 16, 241, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 1, 22, 27, 16, 241, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 21, 22, 27, 16, 241, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 8, 22, 27, 16, 241, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 24, 22, 27, 16, 241, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 5, 22, 27, 16, 241, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 24, 22, 27, 16, 241, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 13, 22, 27, 16, 241, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.InsertData(
                table: "ArticleComments",
                columns: new[] { "Id", "ArticleId", "DateAdded", "Description", "Name" },
                values: new object[] { new Guid("5122af55-bafe-4732-b90e-a5c499e7df4b"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new DateTime(2024, 5, 6, 22, 27, 16, 241, DateTimeKind.Local).AddTicks(914), "mnam do pyska", "jozka" });

            migrationBuilder.InsertData(
                table: "ArticleTag",
                columns: new[] { "Id", "ArticleId", "TagId" },
                values: new object[,]
                {
                    { new Guid("0bb9a5d2-1d14-407f-8094-fab3ac34297b"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("b1eac43b-9a2a-4e37-94d2-0a59a493c7d3") },
                    { new Guid("17d08354-c0a8-40ce-87ba-c5e2d1cf04a7"), new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("c1d698f0-1f87-4c30-9a31-c26e75d99c4f") },
                    { new Guid("1b81005c-79d0-44f9-8027-44308d717570"), new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("2f5e4a6b-d1bf-495d-a7de-8c5639d26034"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("38b57f79-26ee-4fe5-adcb-01a079cf871f"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") },
                    { new Guid("3a7e1f64-e9d4-45c8-8aaf-0974e478d45f"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") },
                    { new Guid("4884e6e4-f306-4933-a600-12dd8399afa5"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("5845bfb1-e7f5-4fe0-ad08-a29c927299e6"), new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") },
                    { new Guid("7d919f15-d559-43cc-84cd-e0e624938a7e"), new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("7eb09ff0-0d8c-49d9-b0c8-3438973c00cc"), new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("862adb06-6141-4af3-a78f-922904a0c0b8"), new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("97b1f5ba-7590-4fd1-b936-f4b63ebee06e"), new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("9eeb8f4b-3d2c-487e-951d-1f222bf91330"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("af52eff0-d126-4cb1-b69b-a187e9258767"), new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("b390c4e1-baf5-464f-bac8-52b2d982e67e"), new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") },
                    { new Guid("c71bcfc4-c04c-4d3f-90ff-cb6d4954d65f"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },
                    { new Guid("debb446f-1bbf-4dc5-9d29-81527527e473"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("e9f38c7d-5b9d-4376-9acf-dce4b1b33aef"), new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },
                    { new Guid("fa933aae-1da6-4551-9298-4447183d0e25"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("ffdc4e37-2b55-4a95-aee4-6da1ad70a14d"), new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") }
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { new Guid("06533be1-7c0b-4657-b7f2-5b49d7b47e6a"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "bazalkové pesto" },
                    { new Guid("0742c703-8c42-4e34-b6e6-6dd01df48774"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "soľ a čierne korenie" },
                    { new Guid("098aae72-87fa-43f4-9f4a-dae261c406b3"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "hrsť čerstvej bazalky" },
                    { new Guid("2373b6b5-afeb-4ab7-9ada-be7f466a09b8"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1 PL panenského olivového oleja" },
                    { new Guid("31e28653-c92c-4403-a6c4-9213cc9589c5"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "3 plátky masla" },
                    { new Guid("394eef94-6343-4ac6-9f18-25a519d690bb"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "300 g ryže arborio" },
                    { new Guid("3951046c-2d71-4fcf-b5ff-e070d6b11636"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "40 g nakrájaných olív Kalamata (ja som použila olivy Kalamata K-Favourites, ktoré nájdete v Kauflande)" },
                    { new Guid("39ab9159-abe3-4792-b31c-fbace56a855e"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1/2 ČL rímskej rasce" },
                    { new Guid("39bed748-79a6-4c61-8d56-f3ebc4ace01c"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "200 ml bieleho suchého vína" },
                    { new Guid("42dbfac8-30b2-4021-a65a-277e1d8c690c"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "mozzarella" },
                    { new Guid("43df8e97-f94e-4280-8146-1e1daaab51dc"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "4 strúčiky cesnaku" },
                    { new Guid("5a8583fd-4930-4118-a89b-bf2e08274962"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "hrsť lístkov bazalky" },
                    { new Guid("5e62e578-8abb-43ac-b993-c16f750e4860"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "panenský olivový olej" },
                    { new Guid("68e0d2dd-56f1-4c38-98d0-02d5b0570f9d"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1 - 2 strúčiky cesnaku" },
                    { new Guid("7c5eea18-a915-402b-9308-aa9e980f58f6"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "sušená bazalka" },
                    { new Guid("7e75b035-c3c1-4021-ba02-97540f6d871d"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "700 ml vývaru/vody" },
                    { new Guid("8288271b-5d1a-46fe-a000-9a32a59b2fec"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "250 g predvareného cíceru" },
                    { new Guid("867e72b4-461d-46c9-a13c-e519a261bd45"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "7 PL panenského olivového oleja" },
                    { new Guid("893e2fe5-f098-46e9-91e0-857d2471d1f8"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "2 PL studenej vody'" },
                    { new Guid("89a106c3-bf3b-45dd-bc14-854aacb6316d"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "soľ a čierne korenie" },
                    { new Guid("89b3f6eb-5ee6-4e0d-b9b9-6111dad9940c"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "1 cibuľa" },
                    { new Guid("96e7758f-9a3b-4393-bbf8-721d47d66a39"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "25 ml šťavy z citróna" },
                    { new Guid("97280559-e326-4cfc-8977-f23dd618feeb"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "100 g parmezánu" },
                    { new Guid("a78a2471-3330-4914-a17a-1ad003655129"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "500 g cherry paradajok" },
                    { new Guid("b1d44cad-0583-4c01-9946-3bf0b219112c"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "300 ml paradajkového pretlaku/passaty" },
                    { new Guid("b3de39ff-0c53-4d67-8671-2d2f7cbf78e4"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "soľ a čierne korenie" },
                    { new Guid("b712f41b-91d1-4780-9ca6-4cce444ac34d"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "3 strúčiky cesnaku" },
                    { new Guid("cf7370a5-0d63-479a-9a27-998a71c44b82"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "60 g sezamovej pasty" },
                    { new Guid("d151d926-347c-472f-a2c9-14868fade684"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "500 g cherry paradajok" },
                    { new Guid("d783930d-939e-49e7-958b-20f1c348622a"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "1 bageta alebo iné pečivo (pre verziu bez lepku odporúčam použiť 1 balenie bezlepkových svetlých žemlí K-free, ktoré nájdete v Kauflande)" },
                    { new Guid("d88a768b-087f-4fb4-8962-c39be818624e"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "sušené oregano" }
                });

            migrationBuilder.InsertData(
                table: "Step",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { new Guid("1911c3f6-31a5-4bb9-873e-1b84a2ef99d9"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Prilejeme paradajkový pretlak/passatu a dobre premiešame. Znížime teplotu na stredný plameň, pridáme naberačku teplého vývaru alebo osolenej vody a pravidelne miešame, kým sa voda nevstrebe. Pokračujeme v postupnom pridávaní vody a zakaždým premiešavame, kým sa voda nevstrebe a ryža sa neuvarí al dente. Ryža je hotová vtedy, keď je obklopená krémovou tekutinou a po ochutnaní je jemne chrumkavá. Celý proces varenia trvá cca 25 minút." },
                    { new Guid("1e844085-08c4-48e1-bf8f-0803e933eb80"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Kým sa vývar/voda zohrieva, zohrejeme si v hlbokej panvici olivový olej, pridáme nadrobno nasekanú cibuľu a opečieme dosklovita. Prisypeme nepremytú ryžu arborio (môžete použiť aj carnaroli ryžu) a poriadne premiešame, aby sa ryža obalila vo vrstve oleja. Opekáme cca 4 minúty, pričom ryžu pravidelne premiešavame. Prilejeme víno a za občasného miešania privedieme do varu. Varíme cca 2 minúty, kým sa víno neodparí." },
                    { new Guid("8ce3a103-f2bc-48d2-ab0b-7102e18c80b8"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Paradajky nakrájame na štvrtiny a vložíme do misky. Pokvapkáme ich olivovým olejom (cca 5 PL panenského olivového oleja), pridáme prelisované strúčiky cesnaku a ochutíme soľou a čiernym korením. Premiešame lyžicou a necháme pár minút odležať. Následne celú zmes preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme 25 minút." },
                    { new Guid("8e096b47-83c1-454c-82ee-a99015deb466"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Rizoto stiahneme zo sporáka, pridáme k nemu plátky masla a nastrúhaný parmezán a vareškou jemne premiešame. Podľa potreby dochutíme soľou, čiernym korením, trochou sušeného oregana a bazalky. Rizoto servírujeme v hlbokých tanieroch, navrch dáme pečené paradajky a ozdobíme lístkami čerstvej bazalky. Rizoto podávame hneď po uvarení, vtedy chutí najlepšie, s pohárom bieleho vína priam dokonale!" },
                    { new Guid("a02102c6-8307-4972-b1ef-f238d8f1a0a0"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "Predvarený cícer z konzervy prepláchneme, preložíme do hrnca, zalejeme vodou, jemne osolíme a privedieme do varu. Keď začne vrieť, znížime teplotu a prikrytý varíme približne 20 minút. Mäkký cícer prepláchneme studenou vodou a zbavíme šupiek. Presypeme ho do výkonného mixéra a pridáme k nemu ostatné ingrediencie na hummus. Vymixujeme dohladka a v prípade potreby pridáme trochu vody. Dochutíme soľou, čiernym korením a citrónovou šťavou." },
                    { new Guid("b459ad6f-37b2-4cef-9b17-cc75cf1da34e"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "Hummus pred podávaním ochutíme trochou mletej červenej papriky, pokvapkáme olivovým olejom a ozdobíme nakrájanou cibuľou, paradajkami, kolieskami uhorky a hrsťou zelených a čiernych olív. Servírujeme s plátkami citróna, slanými krekrami a výberom rôznych salám a syrov." },
                    { new Guid("b540f01c-515d-4e3c-b538-6f1a6ff651a2"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "V menšom hrnci zohrejeme kurací alebo zeleninový vývar. Ak vývar nemáte, môžete použiť aj vodu - do menšieho hrnca dajte zohriať 700 ml vody a keď bude horúca, pridajte do nej lyžičku soli a dobre premiešajte. Vývar, prípadne vodu zohrievame preto, aby mali podobnú teplotu ako ryža. Vďaka tomu sa nezastaví proces varenia a budete mať rizoto presne také, aké má byť - krémové a neskutočne dobré." },
                    { new Guid("cc46e596-a5b7-4b47-8b29-d925c2c6f37d"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "Paradajky nakrájame na menšie kúsky a vložíme do misky. Zalejeme ich olivovým olejom, pridáme prelisované strúčiky cesnaku, ochutíme soľou a čiernym korením a dobre premiešame. Necháme pár minút postáť. Následne paradajky preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme približne 30 minút, kým nezmäknú." },
                    { new Guid("e8f27cbf-ba1f-4380-9308-47e0adf0b8c0"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "Bagetu alebo iné pečivo nakrájame na približne rovnaké kúsky. Ak použijete bezlepkové svetlé žemle K-free od Kauflandu, prekrojte ich na polovicu. Jednotlivé kúsky potrieme zvyšným olivovým olejom, ktorý zostal v miske a opečieme na grile, panvici alebo vložíme na 10 minút do rúry. Chrumkavé pečivo potrieme pestom, na to dáme plátok mozzarelly, grilované paradajky a lístky čerstvej bazalky." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleComments",
                keyColumn: "Id",
                keyValue: new Guid("5122af55-bafe-4732-b90e-a5c499e7df4b"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("0bb9a5d2-1d14-407f-8094-fab3ac34297b"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("17d08354-c0a8-40ce-87ba-c5e2d1cf04a7"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("1b81005c-79d0-44f9-8027-44308d717570"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("2f5e4a6b-d1bf-495d-a7de-8c5639d26034"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("38b57f79-26ee-4fe5-adcb-01a079cf871f"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("3a7e1f64-e9d4-45c8-8aaf-0974e478d45f"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("4884e6e4-f306-4933-a600-12dd8399afa5"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("5845bfb1-e7f5-4fe0-ad08-a29c927299e6"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("7d919f15-d559-43cc-84cd-e0e624938a7e"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("7eb09ff0-0d8c-49d9-b0c8-3438973c00cc"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("862adb06-6141-4af3-a78f-922904a0c0b8"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("97b1f5ba-7590-4fd1-b936-f4b63ebee06e"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("9eeb8f4b-3d2c-487e-951d-1f222bf91330"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("af52eff0-d126-4cb1-b69b-a187e9258767"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("b390c4e1-baf5-464f-bac8-52b2d982e67e"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("c71bcfc4-c04c-4d3f-90ff-cb6d4954d65f"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("debb446f-1bbf-4dc5-9d29-81527527e473"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("e9f38c7d-5b9d-4376-9acf-dce4b1b33aef"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("fa933aae-1da6-4551-9298-4447183d0e25"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("ffdc4e37-2b55-4a95-aee4-6da1ad70a14d"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("06533be1-7c0b-4657-b7f2-5b49d7b47e6a"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("0742c703-8c42-4e34-b6e6-6dd01df48774"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("098aae72-87fa-43f4-9f4a-dae261c406b3"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("2373b6b5-afeb-4ab7-9ada-be7f466a09b8"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("31e28653-c92c-4403-a6c4-9213cc9589c5"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("394eef94-6343-4ac6-9f18-25a519d690bb"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("3951046c-2d71-4fcf-b5ff-e070d6b11636"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("39ab9159-abe3-4792-b31c-fbace56a855e"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("39bed748-79a6-4c61-8d56-f3ebc4ace01c"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("42dbfac8-30b2-4021-a65a-277e1d8c690c"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("43df8e97-f94e-4280-8146-1e1daaab51dc"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("5a8583fd-4930-4118-a89b-bf2e08274962"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("5e62e578-8abb-43ac-b993-c16f750e4860"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("68e0d2dd-56f1-4c38-98d0-02d5b0570f9d"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("7c5eea18-a915-402b-9308-aa9e980f58f6"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("7e75b035-c3c1-4021-ba02-97540f6d871d"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("8288271b-5d1a-46fe-a000-9a32a59b2fec"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("867e72b4-461d-46c9-a13c-e519a261bd45"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("893e2fe5-f098-46e9-91e0-857d2471d1f8"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("89a106c3-bf3b-45dd-bc14-854aacb6316d"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("89b3f6eb-5ee6-4e0d-b9b9-6111dad9940c"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("96e7758f-9a3b-4393-bbf8-721d47d66a39"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("97280559-e326-4cfc-8977-f23dd618feeb"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("a78a2471-3330-4914-a17a-1ad003655129"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("b1d44cad-0583-4c01-9946-3bf0b219112c"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("b3de39ff-0c53-4d67-8671-2d2f7cbf78e4"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("b712f41b-91d1-4780-9ca6-4cce444ac34d"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("cf7370a5-0d63-479a-9a27-998a71c44b82"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("d151d926-347c-472f-a2c9-14868fade684"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("d783930d-939e-49e7-958b-20f1c348622a"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("d88a768b-087f-4fb4-8962-c39be818624e"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("1911c3f6-31a5-4bb9-873e-1b84a2ef99d9"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("1e844085-08c4-48e1-bf8f-0803e933eb80"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("8ce3a103-f2bc-48d2-ab0b-7102e18c80b8"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("8e096b47-83c1-454c-82ee-a99015deb466"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("a02102c6-8307-4972-b1ef-f238d8f1a0a0"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("b459ad6f-37b2-4cef-9b17-cc75cf1da34e"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("b540f01c-515d-4e3c-b538-6f1a6ff651a2"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("cc46e596-a5b7-4b47-8b29-d925c2c6f37d"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("e8f27cbf-ba1f-4380-9308-47e0adf0b8c0"));

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "PasswordSalt",
                table: "Users",
                newName: "Password");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 25, 12, 13, 43, 272, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 5, 12, 13, 43, 272, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 27, 12, 13, 43, 272, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 12, 13, 43, 272, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 20, 12, 13, 43, 272, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 6, 12, 13, 43, 272, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 23, 12, 13, 43, 272, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 3, 12, 13, 43, 272, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 23, 12, 13, 43, 272, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 12, 13, 43, 272, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.InsertData(
                table: "ArticleComments",
                columns: new[] { "Id", "ArticleId", "DateAdded", "Description", "Name" },
                values: new object[] { new Guid("10fc697f-bf54-424a-95ac-39222134e86e"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new DateTime(2024, 4, 4, 12, 13, 43, 272, DateTimeKind.Local).AddTicks(2282), "mnam do pyska", "jozka" });

            migrationBuilder.InsertData(
                table: "ArticleTag",
                columns: new[] { "Id", "ArticleId", "TagId" },
                values: new object[,]
                {
                    { new Guid("0876e03a-035e-4072-b2f5-c9439d0b1c39"), new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("09dfc3b0-4f11-41d5-9671-9c8aa8d534ed"), new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("1795c653-6428-404b-b4a4-c0c66b64b16d"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("17cb6e38-c01d-4c3f-8549-2b4bcc2af302"), new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("1948a652-f5f2-41b7-af74-c329b248019b"), new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("2573f26c-6e6a-4c44-b456-e9df38972792"), new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") },
                    { new Guid("2a95defa-90fc-440c-b42c-8c7d8e16312c"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") },
                    { new Guid("3f82ecab-79f4-4798-8c46-a5a1bf44b251"), new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("46104c9e-bc3d-4cae-a0c9-8128ebb1a0d7"), new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") },
                    { new Guid("4c30d0d9-e194-4e07-9315-921efa725f79"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },
                    { new Guid("5c135a01-e2fb-4554-9117-1ca26dfda6df"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") },
                    { new Guid("5f8ee199-8c09-47f1-9251-4b9418be1500"), new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },
                    { new Guid("66db1dc9-bc79-42e9-98b5-135e95947507"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("732d4a22-fc49-45cc-8c0d-a4fae74e1d67"), new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("91c80069-0bbf-43d0-abb4-be0fc743c5d2"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("aea952dd-64dc-4e87-848c-07285b405992"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("b351109a-2e45-4295-9b26-20cb513b49af"), new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("bef3d572-16b2-43cb-8d17-c481c46d107d"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("b1eac43b-9a2a-4e37-94d2-0a59a493c7d3") },
                    { new Guid("d5055ef5-d0b7-4233-bb04-f16283663c8b"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("d7302f55-66ad-40ba-93fa-f7eb1e6f8f7f"), new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("c1d698f0-1f87-4c30-9a31-c26e75d99c4f") }
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { new Guid("26172a51-e541-40f2-8b7a-4fc1ed6090f4"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "soľ a čierne korenie" },
                    { new Guid("2f30ded7-39f7-4390-9c64-d91f491f0298"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "250 g predvareného cíceru" },
                    { new Guid("2f8b125e-7507-4545-a0d9-0d2de15c02c0"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "300 g ryže arborio" },
                    { new Guid("3d99bc5e-2904-452b-842b-fdcbd6f6db2d"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "25 ml šťavy z citróna" },
                    { new Guid("4507734c-c3d7-493f-ab23-b289e61153b9"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1 PL panenského olivového oleja" },
                    { new Guid("49ff44a4-d03c-4872-bae4-71554cb0d653"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "sušená bazalka" },
                    { new Guid("4f3bfa91-0c0d-4779-829e-d6e9b4409863"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "sušené oregano" },
                    { new Guid("53022b16-3192-4220-91cd-ee2c3ad3a2ce"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "60 g sezamovej pasty" },
                    { new Guid("59e594de-ced4-4cbd-a73d-3d126ed5c04c"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "200 ml bieleho suchého vína" },
                    { new Guid("5d1b5655-c9bf-4848-93cf-b394acc6da7b"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "500 g cherry paradajok" },
                    { new Guid("5f7804e3-91c9-42a9-9e99-29e09242667a"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "300 ml paradajkového pretlaku/passaty" },
                    { new Guid("6bfef51d-3533-4db4-9990-880f349949ac"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "soľ a čierne korenie" },
                    { new Guid("726651a2-4537-4483-9961-b71f4198bc14"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "500 g cherry paradajok" },
                    { new Guid("791a9472-20b6-4700-acbc-dcf992236b35"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "4 strúčiky cesnaku" },
                    { new Guid("854b5ac1-7ce1-435b-9012-7c90c0afbcaf"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "3 strúčiky cesnaku" },
                    { new Guid("863ac28e-5398-4876-acc8-68280bdbb6d6"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1/2 ČL rímskej rasce" },
                    { new Guid("86c8cfff-ac8c-4dc6-b335-7168ac4ddef5"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "40 g nakrájaných olív Kalamata (ja som použila olivy Kalamata K-Favourites, ktoré nájdete v Kauflande)" },
                    { new Guid("90ed20d1-84fc-4322-8c9c-ff8357e7c7db"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "panenský olivový olej" },
                    { new Guid("9350253f-fcb2-4bf9-a1f5-5af123233df1"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "2 PL studenej vody'" },
                    { new Guid("9b892ffe-51ce-4299-99cd-cb0e91a49657"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "1 cibuľa" },
                    { new Guid("9da697e4-5752-4c60-a275-75176ccf1406"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "3 plátky masla" },
                    { new Guid("b59e2366-6f66-4a6a-a3a1-512503dce3f3"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "700 ml vývaru/vody" },
                    { new Guid("bb5b89d7-5834-4c44-92c7-c03b6a926842"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "hrsť lístkov bazalky" },
                    { new Guid("bc630790-23bd-4a22-bf7c-6a1858678d7a"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "bazalkové pesto" },
                    { new Guid("bed2cd0e-0d3f-40e7-a420-fb4511a7ad22"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "100 g parmezánu" },
                    { new Guid("bf81614e-19d9-4334-a92b-c2eb22a1e5c6"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "1 bageta alebo iné pečivo (pre verziu bez lepku odporúčam použiť 1 balenie bezlepkových svetlých žemlí K-free, ktoré nájdete v Kauflande)" },
                    { new Guid("cbec752d-0c77-4cf4-b6e3-527d82407a8e"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "hrsť čerstvej bazalky" },
                    { new Guid("cc8a01bb-ffb3-4822-b0b1-0815796e5cb0"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1 - 2 strúčiky cesnaku" },
                    { new Guid("e11c3dd2-ed4f-4714-a9b6-4890f6cf963a"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "soľ a čierne korenie" },
                    { new Guid("e8f4df34-75c0-4ba9-8947-acb02a9f608a"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "7 PL panenského olivového oleja" },
                    { new Guid("ec7fc74a-cecd-4efb-ae50-6f220751b04d"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "mozzarella" }
                });

            migrationBuilder.InsertData(
                table: "Step",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { new Guid("0d847b0d-1e4c-45c8-adb2-22224def78f1"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Paradajky nakrájame na štvrtiny a vložíme do misky. Pokvapkáme ich olivovým olejom (cca 5 PL panenského olivového oleja), pridáme prelisované strúčiky cesnaku a ochutíme soľou a čiernym korením. Premiešame lyžicou a necháme pár minút odležať. Následne celú zmes preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme 25 minút." },
                    { new Guid("3fad7a2e-5fca-46b2-8139-0f808e3735fe"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Kým sa vývar/voda zohrieva, zohrejeme si v hlbokej panvici olivový olej, pridáme nadrobno nasekanú cibuľu a opečieme dosklovita. Prisypeme nepremytú ryžu arborio (môžete použiť aj carnaroli ryžu) a poriadne premiešame, aby sa ryža obalila vo vrstve oleja. Opekáme cca 4 minúty, pričom ryžu pravidelne premiešavame. Prilejeme víno a za občasného miešania privedieme do varu. Varíme cca 2 minúty, kým sa víno neodparí." },
                    { new Guid("53705a07-feeb-4ecf-ac40-0afd0f23326b"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "Hummus pred podávaním ochutíme trochou mletej červenej papriky, pokvapkáme olivovým olejom a ozdobíme nakrájanou cibuľou, paradajkami, kolieskami uhorky a hrsťou zelených a čiernych olív. Servírujeme s plátkami citróna, slanými krekrami a výberom rôznych salám a syrov." },
                    { new Guid("943fdffb-a2b1-4a97-9823-12f37759d908"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "Paradajky nakrájame na menšie kúsky a vložíme do misky. Zalejeme ich olivovým olejom, pridáme prelisované strúčiky cesnaku, ochutíme soľou a čiernym korením a dobre premiešame. Necháme pár minút postáť. Následne paradajky preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme približne 30 minút, kým nezmäknú." },
                    { new Guid("9d3b8994-9270-4e29-95ac-fdbc61fe8c97"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Prilejeme paradajkový pretlak/passatu a dobre premiešame. Znížime teplotu na stredný plameň, pridáme naberačku teplého vývaru alebo osolenej vody a pravidelne miešame, kým sa voda nevstrebe. Pokračujeme v postupnom pridávaní vody a zakaždým premiešavame, kým sa voda nevstrebe a ryža sa neuvarí al dente. Ryža je hotová vtedy, keď je obklopená krémovou tekutinou a po ochutnaní je jemne chrumkavá. Celý proces varenia trvá cca 25 minút." },
                    { new Guid("a091f670-738b-4595-a201-73689dbe9da6"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "V menšom hrnci zohrejeme kurací alebo zeleninový vývar. Ak vývar nemáte, môžete použiť aj vodu - do menšieho hrnca dajte zohriať 700 ml vody a keď bude horúca, pridajte do nej lyžičku soli a dobre premiešajte. Vývar, prípadne vodu zohrievame preto, aby mali podobnú teplotu ako ryža. Vďaka tomu sa nezastaví proces varenia a budete mať rizoto presne také, aké má byť - krémové a neskutočne dobré." },
                    { new Guid("c34151f9-1f9d-49f8-a060-faf7901312f1"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "Bagetu alebo iné pečivo nakrájame na približne rovnaké kúsky. Ak použijete bezlepkové svetlé žemle K-free od Kauflandu, prekrojte ich na polovicu. Jednotlivé kúsky potrieme zvyšným olivovým olejom, ktorý zostal v miske a opečieme na grile, panvici alebo vložíme na 10 minút do rúry. Chrumkavé pečivo potrieme pestom, na to dáme plátok mozzarelly, grilované paradajky a lístky čerstvej bazalky." },
                    { new Guid("df1aaa9b-ae31-44ce-9b41-53010b8651b8"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "Predvarený cícer z konzervy prepláchneme, preložíme do hrnca, zalejeme vodou, jemne osolíme a privedieme do varu. Keď začne vrieť, znížime teplotu a prikrytý varíme približne 20 minút. Mäkký cícer prepláchneme studenou vodou a zbavíme šupiek. Presypeme ho do výkonného mixéra a pridáme k nemu ostatné ingrediencie na hummus. Vymixujeme dohladka a v prípade potreby pridáme trochu vody. Dochutíme soľou, čiernym korením a citrónovou šťavou." },
                    { new Guid("e97740eb-8fca-44fa-b303-bc976bb8c285"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Rizoto stiahneme zo sporáka, pridáme k nemu plátky masla a nastrúhaný parmezán a vareškou jemne premiešame. Podľa potreby dochutíme soľou, čiernym korením, trochou sušeného oregana a bazalky. Rizoto servírujeme v hlbokých tanieroch, navrch dáme pečené paradajky a ozdobíme lístkami čerstvej bazalky. Rizoto podávame hneď po uvarení, vtedy chutí najlepšie, s pohárom bieleho vína priam dokonale!" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { new Guid("0c754691-fff0-4738-82dc-f9c4daffeadd"), new DateOnly(1994, 4, 6), "admin@gmail.com", "JustAdmin", "admin", 0 },
                    { new Guid("6105e9f8-da03-400b-a703-28dbafd9a95d"), new DateOnly(2004, 4, 6), "user@gmail.com", "JustUser", "pw", 0 }
                });
        }
    }
}
