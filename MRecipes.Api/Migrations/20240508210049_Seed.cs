using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MRecipes.Api.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 7, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 28, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 1, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 21, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 8, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 24, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 5, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 24, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 13, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.InsertData(
                table: "ArticleComments",
                columns: new[] { "Id", "ArticleId", "DateAdded", "Description", "Name" },
                values: new object[] { new Guid("02a62db2-3a9e-4581-ba4d-897d602d60ff"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new DateTime(2024, 5, 6, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2092), "mnam do pyska", "jozka" });

            migrationBuilder.InsertData(
                table: "ArticleTag",
                columns: new[] { "Id", "ArticleId", "TagId" },
                values: new object[,]
                {
                    { new Guid("0ae87288-e539-451c-8f29-35c532b94acc"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("1a6c1e4e-cdfc-481e-800e-4f69a5387340"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") },
                    { new Guid("3cae088f-1480-48e2-b630-7a0a9ce1e742"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("449ffa01-0111-4c09-8226-575a07ab6402"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },
                    { new Guid("45456774-2842-41f1-8b9c-f3a5289d34ec"), new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },
                    { new Guid("54495810-f10f-486c-9d7a-487816e5a382"), new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("56fc5445-74fd-42c8-8d85-7eb6a33290f3"), new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") },
                    { new Guid("5bc1f452-9b98-4e4f-b536-70fb30dfb07e"), new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("76b10ccf-bc7a-44a9-a4a0-4899f1343db6"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("7c605a5e-32aa-4d98-a663-e6ac0461a947"), new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("7ce82ec5-7a85-4983-8a0a-3134dcf79a5e"), new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("84be52e1-a476-461c-a6b2-88cafe0ba274"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") },
                    { new Guid("91f51fe3-6001-4c04-b27b-881fd4697363"), new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("9e474c1e-3452-4b72-be6f-e844b4f554c4"), new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("ae15d873-a955-4aa8-abb6-b4c259bdfff6"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("b24415ef-1ccd-4734-9259-d5867a201071"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("c31fc52b-f634-492c-8414-bd44bfe03c7f"), new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("cd030602-dc2e-4953-8c0d-f3432a37f97e"), new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") },
                    { new Guid("f65ef68e-3aa1-4851-b5c1-e8cd9791fb79"), new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("c1d698f0-1f87-4c30-9a31-c26e75d99c4f") },
                    { new Guid("fc7eeed9-2612-471f-9980-fd92da10276d"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("b1eac43b-9a2a-4e37-94d2-0a59a493c7d3") }
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { new Guid("0a7880ea-e6ac-4839-8bcb-647d33b8bfd5"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "soľ a čierne korenie" },
                    { new Guid("0c74cfe5-7b17-40ce-a03c-2a24f4922063"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "250 g predvareného cíceru" },
                    { new Guid("17123f71-4478-4a31-912d-e68820810ef0"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "4 strúčiky cesnaku" },
                    { new Guid("1f6605ca-7d1b-47fa-b625-5b2ebea41ba5"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "sušená bazalka" },
                    { new Guid("2ac29f76-9aa3-417c-90cc-c795a2ffe3c9"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "soľ a čierne korenie" },
                    { new Guid("30d6f000-fe31-4f74-a211-035e9d068387"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "100 g parmezánu" },
                    { new Guid("4679a9c8-2ab8-4af6-943e-ac67ee71d70c"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "sušené oregano" },
                    { new Guid("50f0f8f1-4c7d-4307-8ab9-70029e566f82"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "1 cibuľa" },
                    { new Guid("58df0d89-7f20-41e0-9325-3b2a9e66ff48"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1/2 ČL rímskej rasce" },
                    { new Guid("58fbd295-f00c-4f51-975c-d0b60ced93df"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "bazalkové pesto" },
                    { new Guid("5acb40a5-a361-49fc-90b9-f5394b8a9756"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "40 g nakrájaných olív Kalamata (ja som použila olivy Kalamata K-Favourites, ktoré nájdete v Kauflande)" },
                    { new Guid("5d5faf29-6129-49d5-b9ba-3675f47708f6"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1 PL panenského olivového oleja" },
                    { new Guid("60c6273a-d106-434a-a62d-7c88533719b1"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "2 PL studenej vody'" },
                    { new Guid("66657ecd-c4a2-42d2-bb4e-36e364bc337e"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1 - 2 strúčiky cesnaku" },
                    { new Guid("6887e2e9-9b9b-4a6f-ac08-06136ea605b1"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "7 PL panenského olivového oleja" },
                    { new Guid("7c016266-edfe-4333-b73c-08b78b0ad655"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "700 ml vývaru/vody" },
                    { new Guid("7c89713c-cf36-4d20-9059-bced069c1cfc"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "3 strúčiky cesnaku" },
                    { new Guid("84975732-841e-4ff2-bbdd-3bc6c3def801"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "500 g cherry paradajok" },
                    { new Guid("8d5039b2-8c37-4f0c-a4d8-943d5ab0b302"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "hrsť čerstvej bazalky" },
                    { new Guid("a06ed7e8-a65c-4e83-9456-e76cec2599aa"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "3 plátky masla" },
                    { new Guid("aceec46c-4b9a-4ca1-8bac-2c61bfed5f32"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "25 ml šťavy z citróna" },
                    { new Guid("b5225b2f-3a1d-4563-b765-94addc30facb"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "soľ a čierne korenie" },
                    { new Guid("c0f3c4f4-7b00-482e-987a-5f2f77057616"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "hrsť lístkov bazalky" },
                    { new Guid("c692f770-ea7e-423a-b117-250d6693a986"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "1 bageta alebo iné pečivo (pre verziu bez lepku odporúčam použiť 1 balenie bezlepkových svetlých žemlí K-free, ktoré nájdete v Kauflande)" },
                    { new Guid("d9cc7ca1-3df2-4c5c-ae5c-0f961f4cbab9"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "300 g ryže arborio" },
                    { new Guid("dca05e50-69e0-4dde-9b6a-e870dd5e4b5c"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "panenský olivový olej" },
                    { new Guid("de8ce65b-3060-4c57-9f0d-109bd4d9f9ac"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "mozzarella" },
                    { new Guid("df2ed06c-bea7-4894-bd31-8857e449bbb1"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "60 g sezamovej pasty" },
                    { new Guid("e6c0f094-2599-4334-82d1-cfe18b841333"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "500 g cherry paradajok" },
                    { new Guid("eb99e406-f4f6-4011-9d16-b0a9df4c01b0"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "300 ml paradajkového pretlaku/passaty" },
                    { new Guid("f74a85bf-72b0-4897-9cc2-5eb217cf19cc"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "200 ml bieleho suchého vína" }
                });

            migrationBuilder.InsertData(
                table: "Step",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { new Guid("268db77f-c11d-4bc0-bc5e-1691d13ef71b"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "Predvarený cícer z konzervy prepláchneme, preložíme do hrnca, zalejeme vodou, jemne osolíme a privedieme do varu. Keď začne vrieť, znížime teplotu a prikrytý varíme približne 20 minút. Mäkký cícer prepláchneme studenou vodou a zbavíme šupiek. Presypeme ho do výkonného mixéra a pridáme k nemu ostatné ingrediencie na hummus. Vymixujeme dohladka a v prípade potreby pridáme trochu vody. Dochutíme soľou, čiernym korením a citrónovou šťavou." },
                    { new Guid("29adbe97-f701-4cc9-89b0-2a5982212484"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Paradajky nakrájame na štvrtiny a vložíme do misky. Pokvapkáme ich olivovým olejom (cca 5 PL panenského olivového oleja), pridáme prelisované strúčiky cesnaku a ochutíme soľou a čiernym korením. Premiešame lyžicou a necháme pár minút odležať. Následne celú zmes preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme 25 minút." },
                    { new Guid("3257b873-b0b8-4e59-88d6-4939cebd7872"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "Hummus pred podávaním ochutíme trochou mletej červenej papriky, pokvapkáme olivovým olejom a ozdobíme nakrájanou cibuľou, paradajkami, kolieskami uhorky a hrsťou zelených a čiernych olív. Servírujeme s plátkami citróna, slanými krekrami a výberom rôznych salám a syrov." },
                    { new Guid("37cc4da3-fee2-4709-b5bc-b70408aa2e80"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Prilejeme paradajkový pretlak/passatu a dobre premiešame. Znížime teplotu na stredný plameň, pridáme naberačku teplého vývaru alebo osolenej vody a pravidelne miešame, kým sa voda nevstrebe. Pokračujeme v postupnom pridávaní vody a zakaždým premiešavame, kým sa voda nevstrebe a ryža sa neuvarí al dente. Ryža je hotová vtedy, keď je obklopená krémovou tekutinou a po ochutnaní je jemne chrumkavá. Celý proces varenia trvá cca 25 minút." },
                    { new Guid("5303ae71-a8cd-4b4c-8cc5-440f14eb133a"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "V menšom hrnci zohrejeme kurací alebo zeleninový vývar. Ak vývar nemáte, môžete použiť aj vodu - do menšieho hrnca dajte zohriať 700 ml vody a keď bude horúca, pridajte do nej lyžičku soli a dobre premiešajte. Vývar, prípadne vodu zohrievame preto, aby mali podobnú teplotu ako ryža. Vďaka tomu sa nezastaví proces varenia a budete mať rizoto presne také, aké má byť - krémové a neskutočne dobré." },
                    { new Guid("a90b1a33-70ae-4004-aef6-b68f1a403d1c"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "Bagetu alebo iné pečivo nakrájame na približne rovnaké kúsky. Ak použijete bezlepkové svetlé žemle K-free od Kauflandu, prekrojte ich na polovicu. Jednotlivé kúsky potrieme zvyšným olivovým olejom, ktorý zostal v miske a opečieme na grile, panvici alebo vložíme na 10 minút do rúry. Chrumkavé pečivo potrieme pestom, na to dáme plátok mozzarelly, grilované paradajky a lístky čerstvej bazalky." },
                    { new Guid("c413e8fe-b186-45b7-a985-eeea9a495314"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Kým sa vývar/voda zohrieva, zohrejeme si v hlbokej panvici olivový olej, pridáme nadrobno nasekanú cibuľu a opečieme dosklovita. Prisypeme nepremytú ryžu arborio (môžete použiť aj carnaroli ryžu) a poriadne premiešame, aby sa ryža obalila vo vrstve oleja. Opekáme cca 4 minúty, pričom ryžu pravidelne premiešavame. Prilejeme víno a za občasného miešania privedieme do varu. Varíme cca 2 minúty, kým sa víno neodparí." },
                    { new Guid("efe7e129-ee3d-4036-a1ff-fd7a6404d131"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "Paradajky nakrájame na menšie kúsky a vložíme do misky. Zalejeme ich olivovým olejom, pridáme prelisované strúčiky cesnaku, ochutíme soľou a čiernym korením a dobre premiešame. Necháme pár minút postáť. Následne paradajky preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme približne 30 minút, kým nezmäknú." },
                    { new Guid("f8bd2159-0c58-4af3-a2ad-d40ed45f837b"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Rizoto stiahneme zo sporáka, pridáme k nemu plátky masla a nastrúhaný parmezán a vareškou jemne premiešame. Podľa potreby dochutíme soľou, čiernym korením, trochou sušeného oregana a bazalky. Rizoto servírujeme v hlbokých tanieroch, navrch dáme pečené paradajky a ozdobíme lístkami čerstvej bazalky. Rizoto podávame hneď po uvarení, vtedy chutí najlepšie, s pohárom bieleho vína priam dokonale!" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "Name", "PasswordHash", "PasswordSalt", "Role" },
                values: new object[,]
                {
                    { new Guid("0520c0d5-c947-44db-8b28-a1f95638bac8"), new DateOnly(1994, 5, 8), "admin@gmail.com", "JustAdmin", "72FB6CEA3520ACB1BF2AA3D2110B31A1DC12E342C5D446CF2CA290E064C7B5A138D96F358466E5C4349E739635716D4544F23DDB8BAE0903F23C81B6FB887420", "77+9eQwb77+92bhUXxEAE23vv73vv705e++/ve+/ve+/ve+/vRvvv71V77+9cu+/vTbvv70777+9ay9W77+977+977+977+9Oe+/ve+/vVDvv73vv70o77+977+9FGHvv70vD++/vUDvv73vv73vv73dnXvvv71S77+9KA==", 1 },
                    { new Guid("9d1e2d8d-4f51-40ad-83ca-4cfb4f40ffa2"), new DateOnly(2004, 5, 8), "user@gmail.com", "JustUser", "A10EF1777E1CE5BA2A50A7B452CD4B3FF69B3A6BAAA8808CDB0603A5E06B2942FF88BE51F507E36404D20609153A58EAA32B15C4EDD48111CFA0C7B0EBABE6C0", "aw18He+/ve+/vQBtO++/vVbvv709Ee+/ve+/vS9bIhjvv73vv73vv70M77+9Ae+/vTnvv70977+9Lhvvv73vv70w77+9Le+/ve+/ve+/vW9byqHvv73vv70zNSjvv73vv71L77+9Fzzvv70DSe+/ve+/ve+/ve+/vS8=", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleComments",
                keyColumn: "Id",
                keyValue: new Guid("02a62db2-3a9e-4581-ba4d-897d602d60ff"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("0ae87288-e539-451c-8f29-35c532b94acc"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("1a6c1e4e-cdfc-481e-800e-4f69a5387340"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("3cae088f-1480-48e2-b630-7a0a9ce1e742"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("449ffa01-0111-4c09-8226-575a07ab6402"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("45456774-2842-41f1-8b9c-f3a5289d34ec"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("54495810-f10f-486c-9d7a-487816e5a382"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("56fc5445-74fd-42c8-8d85-7eb6a33290f3"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("5bc1f452-9b98-4e4f-b536-70fb30dfb07e"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("76b10ccf-bc7a-44a9-a4a0-4899f1343db6"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("7c605a5e-32aa-4d98-a663-e6ac0461a947"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("7ce82ec5-7a85-4983-8a0a-3134dcf79a5e"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("84be52e1-a476-461c-a6b2-88cafe0ba274"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("91f51fe3-6001-4c04-b27b-881fd4697363"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("9e474c1e-3452-4b72-be6f-e844b4f554c4"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("ae15d873-a955-4aa8-abb6-b4c259bdfff6"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("b24415ef-1ccd-4734-9259-d5867a201071"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("c31fc52b-f634-492c-8414-bd44bfe03c7f"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("cd030602-dc2e-4953-8c0d-f3432a37f97e"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("f65ef68e-3aa1-4851-b5c1-e8cd9791fb79"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("fc7eeed9-2612-471f-9980-fd92da10276d"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("0a7880ea-e6ac-4839-8bcb-647d33b8bfd5"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("0c74cfe5-7b17-40ce-a03c-2a24f4922063"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("17123f71-4478-4a31-912d-e68820810ef0"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("1f6605ca-7d1b-47fa-b625-5b2ebea41ba5"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("2ac29f76-9aa3-417c-90cc-c795a2ffe3c9"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("30d6f000-fe31-4f74-a211-035e9d068387"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("4679a9c8-2ab8-4af6-943e-ac67ee71d70c"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("50f0f8f1-4c7d-4307-8ab9-70029e566f82"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("58df0d89-7f20-41e0-9325-3b2a9e66ff48"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("58fbd295-f00c-4f51-975c-d0b60ced93df"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("5acb40a5-a361-49fc-90b9-f5394b8a9756"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("5d5faf29-6129-49d5-b9ba-3675f47708f6"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("60c6273a-d106-434a-a62d-7c88533719b1"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("66657ecd-c4a2-42d2-bb4e-36e364bc337e"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("6887e2e9-9b9b-4a6f-ac08-06136ea605b1"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("7c016266-edfe-4333-b73c-08b78b0ad655"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("7c89713c-cf36-4d20-9059-bced069c1cfc"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("84975732-841e-4ff2-bbdd-3bc6c3def801"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("8d5039b2-8c37-4f0c-a4d8-943d5ab0b302"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("a06ed7e8-a65c-4e83-9456-e76cec2599aa"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("aceec46c-4b9a-4ca1-8bac-2c61bfed5f32"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("b5225b2f-3a1d-4563-b765-94addc30facb"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("c0f3c4f4-7b00-482e-987a-5f2f77057616"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("c692f770-ea7e-423a-b117-250d6693a986"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("d9cc7ca1-3df2-4c5c-ae5c-0f961f4cbab9"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("dca05e50-69e0-4dde-9b6a-e870dd5e4b5c"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("de8ce65b-3060-4c57-9f0d-109bd4d9f9ac"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("df2ed06c-bea7-4894-bd31-8857e449bbb1"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("e6c0f094-2599-4334-82d1-cfe18b841333"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("eb99e406-f4f6-4011-9d16-b0a9df4c01b0"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("f74a85bf-72b0-4897-9cc2-5eb217cf19cc"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("268db77f-c11d-4bc0-bc5e-1691d13ef71b"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("29adbe97-f701-4cc9-89b0-2a5982212484"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("3257b873-b0b8-4e59-88d6-4939cebd7872"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("37cc4da3-fee2-4709-b5bc-b70408aa2e80"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("5303ae71-a8cd-4b4c-8cc5-440f14eb133a"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("a90b1a33-70ae-4004-aef6-b68f1a403d1c"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("c413e8fe-b186-45b7-a985-eeea9a495314"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("efe7e129-ee3d-4036-a1ff-fd7a6404d131"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("f8bd2159-0c58-4af3-a2ad-d40ed45f837b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0520c0d5-c947-44db-8b28-a1f95638bac8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d1e2d8d-4f51-40ad-83ca-4cfb4f40ffa2"));

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
    }
}
