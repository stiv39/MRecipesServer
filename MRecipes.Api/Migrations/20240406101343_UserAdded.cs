using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MRecipes.Api.Migrations
{
    /// <inheritdoc />
    public partial class UserAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleComments",
                keyColumn: "Id",
                keyValue: new Guid("fc10f156-3774-41f6-83ed-83459559f2bb"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("136248fd-dc21-4968-836c-9541b08c3868"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("23861f53-4731-4730-a734-9e19ece0660e"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("2897a91c-5ff7-4a7e-9c12-591abd2a7aa2"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("29e02a90-5a05-497f-81cc-d36aa7e19612"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("2bf0c27b-a9a2-49fb-996d-aaaec418c3b1"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("2ef8316d-af3d-40a9-8df8-aabf527123cb"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("3569b9cf-0eef-4d34-9f56-d56130cf5fc4"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("4593d99c-bb6d-4276-ae92-dc0cfc9fc53a"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("4a6fbacd-6ff0-4b2c-b28b-a174f129391b"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("4e8b5c2a-ab83-4fda-b4e8-917e8d267c0c"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("53ada1d4-c54e-4df4-a6df-55449d0970f3"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("62d0eb97-83d2-484e-bcdb-930b3317b93e"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("833874df-efdf-42a9-b092-b604f6319db9"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("9f7c70f0-1c67-42bc-8c93-ba9a5a292eca"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("a05ae99b-fa4a-4db5-9e92-82e5bf849434"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("b170a889-79ef-4f90-a9bc-98bf8a8fdf6b"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("b7f03433-126c-4269-ab59-b9b541ab6aca"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("d7c7f292-f946-4080-a295-84006db7d40f"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("dad8edb9-f5be-492e-a437-862782f3d45d"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("db1b67e8-1830-40d6-b5e0-98de6e62fcfd"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("052fb1a2-5d73-4ede-902b-1ed2b129d6b8"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("208e54e2-cafd-4999-9e3d-a67f6edcff9b"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("21b5fa93-edb7-49fc-b621-4a8a9d031cef"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("36adf37d-31dc-4a55-b0fc-de2286450f60"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("41636e60-7dab-4ac2-959e-45a03a35e6e6"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("4716a606-2de3-4b78-b615-09692632acb9"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("4aa3561d-cd5d-4d58-bfc8-02236f0cce9c"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("5e59030e-693d-4308-8032-bab2e023515d"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("6067f54c-9c0b-4a98-b234-fbc617c96c5c"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("6a4f32a7-63d7-4a44-8115-b0b74d6ab237"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("6aed74aa-0537-4c36-9949-b33421a24a26"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("6ce91b4a-d319-438e-8208-0074ad5133be"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("7479830e-b3c9-479a-ac95-323fc2aa7da0"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("7b5f029b-a5d9-4c51-b920-c27d13738b22"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("7d327dd4-287e-4705-8582-baf6cff335a1"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("7d4ac2e7-a82e-4fe7-a7ef-ccd52b44c0db"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("7d890928-bb4d-46ae-b5fb-dcd5ef5bc1a1"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("80348bb4-0ee8-42bc-b7cd-b4451fcba283"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("8231444f-b32e-462d-bbc7-01123c9a70f7"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("8812cdb9-58e3-4498-a150-9e0e83b37bf4"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("a878e0fd-2436-464f-a634-0ae311731c92"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("b0fbcecd-3bd6-4464-9460-e0d4c8818a80"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("c056072f-f5db-4605-9b57-c1bec1135ccf"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("c1527b1d-0bb2-4932-a783-e8eaf14206e0"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("c1d124bc-ba74-40e8-8ea1-427e39da3da5"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("d378ee9c-2117-4391-9d4b-dff70f8969c3"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("d7af738f-3880-4423-87e0-1a96f7b2dfbb"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("d7f162cd-138f-4277-841c-3a6de805217f"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("dcbc85e3-cd11-4e98-b868-de818d8e7d19"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("f68d67b8-a8c8-4a00-b608-70ec086c4b9b"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("f7758601-2c32-4436-8122-2b89a5952f9a"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("09fbaa9e-5ac5-4ca9-88cf-91519c517fd7"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("6dff299f-3546-4176-a65f-bce6c1f79bfa"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("8e66c072-a15b-44ef-bc04-c9c8f3ed5af8"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("b04c8794-c7f4-4e55-b7cb-fb2c3b9af3e5"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("b3fefee7-cdd3-43ae-9d53-66f2eeb596ec"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("bf814623-28e5-46ed-ab59-fa2134eb37fb"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("d4cc9cc9-a289-48d7-aef2-71b6cc50d143"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("f18487e8-47e7-4818-a39a-bd6e6255fce9"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("fba4c226-04b0-49a0-a99d-9d54e165d4f4"));

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

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

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"),
                column: "DateAdded",
                value: new DateTime(2024, 1, 30, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"),
                column: "DateAdded",
                value: new DateTime(2024, 2, 10, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"),
                column: "DateAdded",
                value: new DateTime(2024, 2, 1, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"),
                column: "DateAdded",
                value: new DateTime(2024, 2, 4, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"),
                column: "DateAdded",
                value: new DateTime(2024, 1, 25, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"),
                column: "DateAdded",
                value: new DateTime(2024, 2, 11, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"),
                column: "DateAdded",
                value: new DateTime(2024, 1, 28, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"),
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"),
                column: "DateAdded",
                value: new DateTime(2024, 1, 28, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"),
                column: "DateAdded",
                value: new DateTime(2024, 1, 17, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.InsertData(
                table: "ArticleComments",
                columns: new[] { "Id", "ArticleId", "DateAdded", "Description", "Name" },
                values: new object[] { new Guid("fc10f156-3774-41f6-83ed-83459559f2bb"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new DateTime(2024, 2, 9, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(734), "mnam do pyska", "jozka" });

            migrationBuilder.InsertData(
                table: "ArticleTag",
                columns: new[] { "Id", "ArticleId", "TagId" },
                values: new object[,]
                {
                    { new Guid("136248fd-dc21-4968-836c-9541b08c3868"), new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("23861f53-4731-4730-a734-9e19ece0660e"), new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") },
                    { new Guid("2897a91c-5ff7-4a7e-9c12-591abd2a7aa2"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("29e02a90-5a05-497f-81cc-d36aa7e19612"), new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("2bf0c27b-a9a2-49fb-996d-aaaec418c3b1"), new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("2ef8316d-af3d-40a9-8df8-aabf527123cb"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") },
                    { new Guid("3569b9cf-0eef-4d34-9f56-d56130cf5fc4"), new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },
                    { new Guid("4593d99c-bb6d-4276-ae92-dc0cfc9fc53a"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("4a6fbacd-6ff0-4b2c-b28b-a174f129391b"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },
                    { new Guid("4e8b5c2a-ab83-4fda-b4e8-917e8d267c0c"), new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("53ada1d4-c54e-4df4-a6df-55449d0970f3"), new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("62d0eb97-83d2-484e-bcdb-930b3317b93e"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("833874df-efdf-42a9-b092-b604f6319db9"), new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") },
                    { new Guid("9f7c70f0-1c67-42bc-8c93-ba9a5a292eca"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("a05ae99b-fa4a-4db5-9e92-82e5bf849434"), new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("b170a889-79ef-4f90-a9bc-98bf8a8fdf6b"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("b1eac43b-9a2a-4e37-94d2-0a59a493c7d3") },
                    { new Guid("b7f03433-126c-4269-ab59-b9b541ab6aca"), new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("d7c7f292-f946-4080-a295-84006db7d40f"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("dad8edb9-f5be-492e-a437-862782f3d45d"), new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("c1d698f0-1f87-4c30-9a31-c26e75d99c4f") },
                    { new Guid("db1b67e8-1830-40d6-b5e0-98de6e62fcfd"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") }
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { new Guid("052fb1a2-5d73-4ede-902b-1ed2b129d6b8"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "700 ml vývaru/vody" },
                    { new Guid("208e54e2-cafd-4999-9e3d-a67f6edcff9b"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "300 ml paradajkového pretlaku/passaty" },
                    { new Guid("21b5fa93-edb7-49fc-b621-4a8a9d031cef"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "1 cibuľa" },
                    { new Guid("36adf37d-31dc-4a55-b0fc-de2286450f60"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "3 strúčiky cesnaku" },
                    { new Guid("41636e60-7dab-4ac2-959e-45a03a35e6e6"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "25 ml šťavy z citróna" },
                    { new Guid("4716a606-2de3-4b78-b615-09692632acb9"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "hrsť čerstvej bazalky" },
                    { new Guid("4aa3561d-cd5d-4d58-bfc8-02236f0cce9c"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "500 g cherry paradajok" },
                    { new Guid("5e59030e-693d-4308-8032-bab2e023515d"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1/2 ČL rímskej rasce" },
                    { new Guid("6067f54c-9c0b-4a98-b234-fbc617c96c5c"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "200 ml bieleho suchého vína" },
                    { new Guid("6a4f32a7-63d7-4a44-8115-b0b74d6ab237"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "bazalkové pesto" },
                    { new Guid("6aed74aa-0537-4c36-9949-b33421a24a26"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "60 g sezamovej pasty" },
                    { new Guid("6ce91b4a-d319-438e-8208-0074ad5133be"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "250 g predvareného cíceru" },
                    { new Guid("7479830e-b3c9-479a-ac95-323fc2aa7da0"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "soľ a čierne korenie" },
                    { new Guid("7b5f029b-a5d9-4c51-b920-c27d13738b22"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "4 strúčiky cesnaku" },
                    { new Guid("7d327dd4-287e-4705-8582-baf6cff335a1"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "2 PL studenej vody'" },
                    { new Guid("7d4ac2e7-a82e-4fe7-a7ef-ccd52b44c0db"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "hrsť lístkov bazalky" },
                    { new Guid("7d890928-bb4d-46ae-b5fb-dcd5ef5bc1a1"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "soľ a čierne korenie" },
                    { new Guid("80348bb4-0ee8-42bc-b7cd-b4451fcba283"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "panenský olivový olej" },
                    { new Guid("8231444f-b32e-462d-bbc7-01123c9a70f7"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "100 g parmezánu" },
                    { new Guid("8812cdb9-58e3-4498-a150-9e0e83b37bf4"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "sušená bazalka" },
                    { new Guid("a878e0fd-2436-464f-a634-0ae311731c92"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "300 g ryže arborio" },
                    { new Guid("b0fbcecd-3bd6-4464-9460-e0d4c8818a80"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "500 g cherry paradajok" },
                    { new Guid("c056072f-f5db-4605-9b57-c1bec1135ccf"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "soľ a čierne korenie" },
                    { new Guid("c1527b1d-0bb2-4932-a783-e8eaf14206e0"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "3 plátky masla" },
                    { new Guid("c1d124bc-ba74-40e8-8ea1-427e39da3da5"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1 PL panenského olivového oleja" },
                    { new Guid("d378ee9c-2117-4391-9d4b-dff70f8969c3"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1 - 2 strúčiky cesnaku" },
                    { new Guid("d7af738f-3880-4423-87e0-1a96f7b2dfbb"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "mozzarella" },
                    { new Guid("d7f162cd-138f-4277-841c-3a6de805217f"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "7 PL panenského olivového oleja" },
                    { new Guid("dcbc85e3-cd11-4e98-b868-de818d8e7d19"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "sušené oregano" },
                    { new Guid("f68d67b8-a8c8-4a00-b608-70ec086c4b9b"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "1 bageta alebo iné pečivo (pre verziu bez lepku odporúčam použiť 1 balenie bezlepkových svetlých žemlí K-free, ktoré nájdete v Kauflande)" },
                    { new Guid("f7758601-2c32-4436-8122-2b89a5952f9a"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "40 g nakrájaných olív Kalamata (ja som použila olivy Kalamata K-Favourites, ktoré nájdete v Kauflande)" }
                });

            migrationBuilder.InsertData(
                table: "Step",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { new Guid("09fbaa9e-5ac5-4ca9-88cf-91519c517fd7"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "Paradajky nakrájame na menšie kúsky a vložíme do misky. Zalejeme ich olivovým olejom, pridáme prelisované strúčiky cesnaku, ochutíme soľou a čiernym korením a dobre premiešame. Necháme pár minút postáť. Následne paradajky preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme približne 30 minút, kým nezmäknú." },
                    { new Guid("6dff299f-3546-4176-a65f-bce6c1f79bfa"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Kým sa vývar/voda zohrieva, zohrejeme si v hlbokej panvici olivový olej, pridáme nadrobno nasekanú cibuľu a opečieme dosklovita. Prisypeme nepremytú ryžu arborio (môžete použiť aj carnaroli ryžu) a poriadne premiešame, aby sa ryža obalila vo vrstve oleja. Opekáme cca 4 minúty, pričom ryžu pravidelne premiešavame. Prilejeme víno a za občasného miešania privedieme do varu. Varíme cca 2 minúty, kým sa víno neodparí." },
                    { new Guid("8e66c072-a15b-44ef-bc04-c9c8f3ed5af8"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "V menšom hrnci zohrejeme kurací alebo zeleninový vývar. Ak vývar nemáte, môžete použiť aj vodu - do menšieho hrnca dajte zohriať 700 ml vody a keď bude horúca, pridajte do nej lyžičku soli a dobre premiešajte. Vývar, prípadne vodu zohrievame preto, aby mali podobnú teplotu ako ryža. Vďaka tomu sa nezastaví proces varenia a budete mať rizoto presne také, aké má byť - krémové a neskutočne dobré." },
                    { new Guid("b04c8794-c7f4-4e55-b7cb-fb2c3b9af3e5"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Paradajky nakrájame na štvrtiny a vložíme do misky. Pokvapkáme ich olivovým olejom (cca 5 PL panenského olivového oleja), pridáme prelisované strúčiky cesnaku a ochutíme soľou a čiernym korením. Premiešame lyžicou a necháme pár minút odležať. Následne celú zmes preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme 25 minút." },
                    { new Guid("b3fefee7-cdd3-43ae-9d53-66f2eeb596ec"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "Bagetu alebo iné pečivo nakrájame na približne rovnaké kúsky. Ak použijete bezlepkové svetlé žemle K-free od Kauflandu, prekrojte ich na polovicu. Jednotlivé kúsky potrieme zvyšným olivovým olejom, ktorý zostal v miske a opečieme na grile, panvici alebo vložíme na 10 minút do rúry. Chrumkavé pečivo potrieme pestom, na to dáme plátok mozzarelly, grilované paradajky a lístky čerstvej bazalky." },
                    { new Guid("bf814623-28e5-46ed-ab59-fa2134eb37fb"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Prilejeme paradajkový pretlak/passatu a dobre premiešame. Znížime teplotu na stredný plameň, pridáme naberačku teplého vývaru alebo osolenej vody a pravidelne miešame, kým sa voda nevstrebe. Pokračujeme v postupnom pridávaní vody a zakaždým premiešavame, kým sa voda nevstrebe a ryža sa neuvarí al dente. Ryža je hotová vtedy, keď je obklopená krémovou tekutinou a po ochutnaní je jemne chrumkavá. Celý proces varenia trvá cca 25 minút." },
                    { new Guid("d4cc9cc9-a289-48d7-aef2-71b6cc50d143"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Rizoto stiahneme zo sporáka, pridáme k nemu plátky masla a nastrúhaný parmezán a vareškou jemne premiešame. Podľa potreby dochutíme soľou, čiernym korením, trochou sušeného oregana a bazalky. Rizoto servírujeme v hlbokých tanieroch, navrch dáme pečené paradajky a ozdobíme lístkami čerstvej bazalky. Rizoto podávame hneď po uvarení, vtedy chutí najlepšie, s pohárom bieleho vína priam dokonale!" },
                    { new Guid("f18487e8-47e7-4818-a39a-bd6e6255fce9"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "Predvarený cícer z konzervy prepláchneme, preložíme do hrnca, zalejeme vodou, jemne osolíme a privedieme do varu. Keď začne vrieť, znížime teplotu a prikrytý varíme približne 20 minút. Mäkký cícer prepláchneme studenou vodou a zbavíme šupiek. Presypeme ho do výkonného mixéra a pridáme k nemu ostatné ingrediencie na hummus. Vymixujeme dohladka a v prípade potreby pridáme trochu vody. Dochutíme soľou, čiernym korením a citrónovou šťavou." },
                    { new Guid("fba4c226-04b0-49a0-a99d-9d54e165d4f4"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "Hummus pred podávaním ochutíme trochou mletej červenej papriky, pokvapkáme olivovým olejom a ozdobíme nakrájanou cibuľou, paradajkami, kolieskami uhorky a hrsťou zelených a čiernych olív. Servírujeme s plátkami citróna, slanými krekrami a výberom rôznych salám a syrov." }
                });
        }
    }
}
