using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MRecipes.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddArticleImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Article");

            migrationBuilder.CreateTable(
                name: "ArticleImage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleImage_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"),
                column: "DateAdded",
                value: new DateTime(2025, 3, 26, 21, 9, 4, 569, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"),
                column: "DateAdded",
                value: new DateTime(2025, 4, 6, 21, 9, 4, 569, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"),
                column: "DateAdded",
                value: new DateTime(2025, 3, 28, 21, 9, 4, 569, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"),
                column: "DateAdded",
                value: new DateTime(2025, 3, 31, 21, 9, 4, 569, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"),
                column: "DateAdded",
                value: new DateTime(2025, 3, 21, 21, 9, 4, 569, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"),
                column: "DateAdded",
                value: new DateTime(2025, 4, 7, 21, 9, 4, 569, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"),
                column: "DateAdded",
                value: new DateTime(2025, 3, 24, 21, 9, 4, 569, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"),
                column: "DateAdded",
                value: new DateTime(2025, 4, 4, 21, 9, 4, 569, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"),
                column: "DateAdded",
                value: new DateTime(2025, 3, 24, 21, 9, 4, 569, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"),
                column: "DateAdded",
                value: new DateTime(2025, 3, 13, 21, 9, 4, 569, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.InsertData(
                table: "ArticleComments",
                columns: new[] { "Id", "ArticleId", "DateAdded", "Description", "Name" },
                values: new object[] { new Guid("639cd036-1306-42a8-84bc-22943f959242"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new DateTime(2025, 4, 5, 21, 9, 4, 569, DateTimeKind.Local).AddTicks(280), "mnam do pyska", "jozka" });

            migrationBuilder.InsertData(
                table: "ArticleTag",
                columns: new[] { "Id", "ArticleId", "TagId" },
                values: new object[,]
                {
                    { new Guid("084f311b-c45a-47db-87ff-cdd2a3ff5a28"), new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("1db39e77-1ec0-42ec-b3c3-26437dfc16ca"), new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") },
                    { new Guid("282cf38b-1796-40be-8f5a-d07a10b23e7d"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },
                    { new Guid("2d87fc6a-4285-404d-8cdc-8c0a57df59a2"), new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("30c51e05-a53f-46b0-b614-2c7316eea70b"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("4c5d9d9e-2d67-4bc3-9df2-c3006ac4c962"), new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("5e903599-efab-4aaa-9f06-3efe96ace3b4"), new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("68d652c7-0e74-4ed1-b773-1ff0954e9216"), new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("8a6c3cd7-f5b2-445f-9959-1bead9847cab"), new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("c1d698f0-1f87-4c30-9a31-c26e75d99c4f") },
                    { new Guid("8d918b57-07e1-47ea-b84a-0923e65e3d8e"), new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },
                    { new Guid("98ece588-38b5-419c-8cb0-675ee4f4570a"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("b1eac43b-9a2a-4e37-94d2-0a59a493c7d3") },
                    { new Guid("9ebeba0f-96f7-4419-89b0-3f986f7dfd54"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("a9b90003-db1b-4a7e-9d5c-81d30fb33f50"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("c10411c5-20cf-4ee5-85ea-ff09123cd688"), new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("cd1795e4-fd67-46b3-82ce-9926c426719d"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("d04bb168-fc91-4142-9803-f01e8dd2a691"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") },
                    { new Guid("f11b74a0-effd-4ee8-a476-602200d33549"), new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("f524d683-db8f-4de9-b959-e6af75fb7849"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("fc61dbc0-354b-411f-abe4-fe231585beef"), new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") },
                    { new Guid("fdf9d1da-11c6-4573-a972-edf15bfe698a"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") }
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { new Guid("053ea85f-1118-414d-8cff-8945e5b75bc0"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "700 ml vývaru/vody" },
                    { new Guid("0feda18a-5980-4ab0-b8a3-4a41924bac5f"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "4 strúčiky cesnaku" },
                    { new Guid("1a53f80e-1d45-4773-8fb3-d551a2ec3801"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "25 ml šťavy z citróna" },
                    { new Guid("1c0d6543-f9a8-4e04-b819-0d5c2c040de4"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "hrsť čerstvej bazalky" },
                    { new Guid("2bfb6ef9-dc6b-49d1-8052-1c05f6e93dc1"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "250 g predvareného cíceru" },
                    { new Guid("3cf36753-1b5b-40cb-a157-2f86bb9d7df0"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1 - 2 strúčiky cesnaku" },
                    { new Guid("3df1a060-7890-4d8a-9097-ccf7ccd0cf0f"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1/2 ČL rímskej rasce" },
                    { new Guid("401ae98f-7a70-4310-8a14-f70fc01511c1"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1 PL panenského olivového oleja" },
                    { new Guid("44924b9d-d906-4360-b32c-577376787a96"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "sušená bazalka" },
                    { new Guid("5481a4b5-cbbb-44e8-ae6a-0ce4dcbeb756"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "2 PL studenej vody'" },
                    { new Guid("5b2dc63c-4d97-4f46-858b-042467ce29ef"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "1 cibuľa" },
                    { new Guid("5f009ba5-dc97-40cc-8a3c-53013851dc1f"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "1 bageta alebo iné pečivo (pre verziu bez lepku odporúčam použiť 1 balenie bezlepkových svetlých žemlí K-free, ktoré nájdete v Kauflande)" },
                    { new Guid("69386d65-9196-4b88-b10d-4c9a9ccbba77"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "200 ml bieleho suchého vína" },
                    { new Guid("6d0c67fa-1634-40e7-8597-ee63bde4a5bf"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "500 g cherry paradajok" },
                    { new Guid("6f544632-6e7b-41a4-beb2-e4a9ff2e8cec"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "7 PL panenského olivového oleja" },
                    { new Guid("7a5927d3-d98b-4a06-ab13-76478f7655f8"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "mozzarella" },
                    { new Guid("8ff30443-5bca-4190-b7ac-8b2c08b5f415"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "hrsť lístkov bazalky" },
                    { new Guid("9160ca1e-657f-4de1-af94-fcf9b0a773db"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "3 plátky masla" },
                    { new Guid("9663322c-b38f-41e6-a1c8-c618ae19b8ad"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "300 g ryže arborio" },
                    { new Guid("9c627d99-f589-4caf-a374-7f3b2386a4c8"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "bazalkové pesto" },
                    { new Guid("b138fa84-3d32-4951-a6a8-098c0a163604"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "soľ a čierne korenie" },
                    { new Guid("b2a57e57-8a00-4612-b827-b5ce18b8c9bc"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "sušené oregano" },
                    { new Guid("bdddd566-6caa-4a53-8100-c968ca7dbcc5"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "100 g parmezánu" },
                    { new Guid("df21f6ad-2dfd-400f-9f00-1698aa2ef27f"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "panenský olivový olej" },
                    { new Guid("e5bb350b-19c9-4449-8a5e-a2aed7c90e48"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "3 strúčiky cesnaku" },
                    { new Guid("ebc142b2-4a72-439c-8654-71ed6cbf5722"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "soľ a čierne korenie" },
                    { new Guid("ee7decbf-d27c-4320-a7e4-a922cefba894"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "soľ a čierne korenie" },
                    { new Guid("f4d40aa2-df82-4870-95e5-eef5c6b993f3"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "300 ml paradajkového pretlaku/passaty" },
                    { new Guid("f51024d2-b2cf-41ff-9f4d-ae3c5fbce94a"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "500 g cherry paradajok" },
                    { new Guid("fe97e253-eb84-4c65-be92-3a5baa2631a7"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "60 g sezamovej pasty" },
                    { new Guid("fff406fe-8a2d-415e-8e7e-1adf9776f3cd"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "40 g nakrájaných olív Kalamata (ja som použila olivy Kalamata K-Favourites, ktoré nájdete v Kauflande)" }
                });

            migrationBuilder.InsertData(
                table: "Step",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { new Guid("0d65c05a-c88e-4a83-90ad-0d625bc3b934"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Prilejeme paradajkový pretlak/passatu a dobre premiešame. Znížime teplotu na stredný plameň, pridáme naberačku teplého vývaru alebo osolenej vody a pravidelne miešame, kým sa voda nevstrebe. Pokračujeme v postupnom pridávaní vody a zakaždým premiešavame, kým sa voda nevstrebe a ryža sa neuvarí al dente. Ryža je hotová vtedy, keď je obklopená krémovou tekutinou a po ochutnaní je jemne chrumkavá. Celý proces varenia trvá cca 25 minút." },
                    { new Guid("110a07ad-6596-4eb9-bcbc-d8f5c21d38d3"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Paradajky nakrájame na štvrtiny a vložíme do misky. Pokvapkáme ich olivovým olejom (cca 5 PL panenského olivového oleja), pridáme prelisované strúčiky cesnaku a ochutíme soľou a čiernym korením. Premiešame lyžicou a necháme pár minút odležať. Následne celú zmes preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme 25 minút." },
                    { new Guid("137c7f2b-15c2-45f4-9d36-d51332af7c2c"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Kým sa vývar/voda zohrieva, zohrejeme si v hlbokej panvici olivový olej, pridáme nadrobno nasekanú cibuľu a opečieme dosklovita. Prisypeme nepremytú ryžu arborio (môžete použiť aj carnaroli ryžu) a poriadne premiešame, aby sa ryža obalila vo vrstve oleja. Opekáme cca 4 minúty, pričom ryžu pravidelne premiešavame. Prilejeme víno a za občasného miešania privedieme do varu. Varíme cca 2 minúty, kým sa víno neodparí." },
                    { new Guid("2216f933-a823-4b08-b592-01669bf22b7b"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "Paradajky nakrájame na menšie kúsky a vložíme do misky. Zalejeme ich olivovým olejom, pridáme prelisované strúčiky cesnaku, ochutíme soľou a čiernym korením a dobre premiešame. Necháme pár minút postáť. Následne paradajky preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme približne 30 minút, kým nezmäknú." },
                    { new Guid("4cd71676-03cd-4cb0-8151-cdeb38362d28"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "Hummus pred podávaním ochutíme trochou mletej červenej papriky, pokvapkáme olivovým olejom a ozdobíme nakrájanou cibuľou, paradajkami, kolieskami uhorky a hrsťou zelených a čiernych olív. Servírujeme s plátkami citróna, slanými krekrami a výberom rôznych salám a syrov." },
                    { new Guid("4f394ad0-8fea-456d-8e65-bfceda355a84"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "Bagetu alebo iné pečivo nakrájame na približne rovnaké kúsky. Ak použijete bezlepkové svetlé žemle K-free od Kauflandu, prekrojte ich na polovicu. Jednotlivé kúsky potrieme zvyšným olivovým olejom, ktorý zostal v miske a opečieme na grile, panvici alebo vložíme na 10 minút do rúry. Chrumkavé pečivo potrieme pestom, na to dáme plátok mozzarelly, grilované paradajky a lístky čerstvej bazalky." },
                    { new Guid("92937ecd-c5e8-4e29-adf9-abfd3ecd9442"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "Predvarený cícer z konzervy prepláchneme, preložíme do hrnca, zalejeme vodou, jemne osolíme a privedieme do varu. Keď začne vrieť, znížime teplotu a prikrytý varíme približne 20 minút. Mäkký cícer prepláchneme studenou vodou a zbavíme šupiek. Presypeme ho do výkonného mixéra a pridáme k nemu ostatné ingrediencie na hummus. Vymixujeme dohladka a v prípade potreby pridáme trochu vody. Dochutíme soľou, čiernym korením a citrónovou šťavou." },
                    { new Guid("a109899e-d81d-46d4-9e15-edc0f34bc093"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Rizoto stiahneme zo sporáka, pridáme k nemu plátky masla a nastrúhaný parmezán a vareškou jemne premiešame. Podľa potreby dochutíme soľou, čiernym korením, trochou sušeného oregana a bazalky. Rizoto servírujeme v hlbokých tanieroch, navrch dáme pečené paradajky a ozdobíme lístkami čerstvej bazalky. Rizoto podávame hneď po uvarení, vtedy chutí najlepšie, s pohárom bieleho vína priam dokonale!" },
                    { new Guid("f64d5716-de0d-46b1-8487-7e25cc78e2e2"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "V menšom hrnci zohrejeme kurací alebo zeleninový vývar. Ak vývar nemáte, môžete použiť aj vodu - do menšieho hrnca dajte zohriať 700 ml vody a keď bude horúca, pridajte do nej lyžičku soli a dobre premiešajte. Vývar, prípadne vodu zohrievame preto, aby mali podobnú teplotu ako ryža. Vďaka tomu sa nezastaví proces varenia a budete mať rizoto presne také, aké má byť - krémové a neskutočne dobré." }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "Name", "PasswordHash", "PasswordSalt", "Role" },
                values: new object[,]
                {
                    { new Guid("516f4012-5f25-4c1e-8e75-a076ce71a82d"), new DateOnly(1995, 4, 7), "admin@gmail.com", "JustAdmin", "72FB6CEA3520ACB1BF2AA3D2110B31A1DC12E342C5D446CF2CA290E064C7B5A138D96F358466E5C4349E739635716D4544F23DDB8BAE0903F23C81B6FB887420", "77+9eQwb77+92bhUXxEAE23vv73vv705e++/ve+/ve+/ve+/vRvvv71V77+9cu+/vTbvv70777+9ay9W77+977+977+977+9Oe+/ve+/vVDvv73vv70o77+977+9FGHvv70vD++/vUDvv73vv73vv73dnXvvv71S77+9KA==", 1 },
                    { new Guid("d535f09b-e140-4cda-9627-03068356ed7b"), new DateOnly(2005, 4, 7), "user@gmail.com", "JustUser", "A10EF1777E1CE5BA2A50A7B452CD4B3FF69B3A6BAAA8808CDB0603A5E06B2942FF88BE51F507E36404D20609153A58EAA32B15C4EDD48111CFA0C7B0EBABE6C0", "aw18He+/ve+/vQBtO++/vVbvv709Ee+/ve+/vS9bIhjvv73vv73vv70M77+9Ae+/vTnvv70977+9Lhvvv73vv70w77+9Le+/ve+/ve+/vW9byqHvv73vv70zNSjvv73vv71L77+9Fzzvv70DSe+/ve+/ve+/ve+/vS8=", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleImage_ArticleId",
                table: "ArticleImage",
                column: "ArticleId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleImage");

            migrationBuilder.DeleteData(
                table: "ArticleComments",
                keyColumn: "Id",
                keyValue: new Guid("639cd036-1306-42a8-84bc-22943f959242"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("084f311b-c45a-47db-87ff-cdd2a3ff5a28"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("1db39e77-1ec0-42ec-b3c3-26437dfc16ca"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("282cf38b-1796-40be-8f5a-d07a10b23e7d"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("2d87fc6a-4285-404d-8cdc-8c0a57df59a2"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("30c51e05-a53f-46b0-b614-2c7316eea70b"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("4c5d9d9e-2d67-4bc3-9df2-c3006ac4c962"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("5e903599-efab-4aaa-9f06-3efe96ace3b4"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("68d652c7-0e74-4ed1-b773-1ff0954e9216"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("8a6c3cd7-f5b2-445f-9959-1bead9847cab"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("8d918b57-07e1-47ea-b84a-0923e65e3d8e"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("98ece588-38b5-419c-8cb0-675ee4f4570a"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("9ebeba0f-96f7-4419-89b0-3f986f7dfd54"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("a9b90003-db1b-4a7e-9d5c-81d30fb33f50"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("c10411c5-20cf-4ee5-85ea-ff09123cd688"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("cd1795e4-fd67-46b3-82ce-9926c426719d"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("d04bb168-fc91-4142-9803-f01e8dd2a691"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("f11b74a0-effd-4ee8-a476-602200d33549"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("f524d683-db8f-4de9-b959-e6af75fb7849"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("fc61dbc0-354b-411f-abe4-fe231585beef"));

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumn: "Id",
                keyValue: new Guid("fdf9d1da-11c6-4573-a972-edf15bfe698a"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("053ea85f-1118-414d-8cff-8945e5b75bc0"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("0feda18a-5980-4ab0-b8a3-4a41924bac5f"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("1a53f80e-1d45-4773-8fb3-d551a2ec3801"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("1c0d6543-f9a8-4e04-b819-0d5c2c040de4"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("2bfb6ef9-dc6b-49d1-8052-1c05f6e93dc1"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("3cf36753-1b5b-40cb-a157-2f86bb9d7df0"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("3df1a060-7890-4d8a-9097-ccf7ccd0cf0f"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("401ae98f-7a70-4310-8a14-f70fc01511c1"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("44924b9d-d906-4360-b32c-577376787a96"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("5481a4b5-cbbb-44e8-ae6a-0ce4dcbeb756"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("5b2dc63c-4d97-4f46-858b-042467ce29ef"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("5f009ba5-dc97-40cc-8a3c-53013851dc1f"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("69386d65-9196-4b88-b10d-4c9a9ccbba77"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("6d0c67fa-1634-40e7-8597-ee63bde4a5bf"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("6f544632-6e7b-41a4-beb2-e4a9ff2e8cec"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("7a5927d3-d98b-4a06-ab13-76478f7655f8"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("8ff30443-5bca-4190-b7ac-8b2c08b5f415"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("9160ca1e-657f-4de1-af94-fcf9b0a773db"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("9663322c-b38f-41e6-a1c8-c618ae19b8ad"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("9c627d99-f589-4caf-a374-7f3b2386a4c8"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("b138fa84-3d32-4951-a6a8-098c0a163604"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("b2a57e57-8a00-4612-b827-b5ce18b8c9bc"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("bdddd566-6caa-4a53-8100-c968ca7dbcc5"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("df21f6ad-2dfd-400f-9f00-1698aa2ef27f"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("e5bb350b-19c9-4449-8a5e-a2aed7c90e48"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("ebc142b2-4a72-439c-8654-71ed6cbf5722"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("ee7decbf-d27c-4320-a7e4-a922cefba894"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("f4d40aa2-df82-4870-95e5-eef5c6b993f3"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("f51024d2-b2cf-41ff-9f4d-ae3c5fbce94a"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("fe97e253-eb84-4c65-be92-3a5baa2631a7"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("fff406fe-8a2d-415e-8e7e-1adf9776f3cd"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("0d65c05a-c88e-4a83-90ad-0d625bc3b934"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("110a07ad-6596-4eb9-bcbc-d8f5c21d38d3"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("137c7f2b-15c2-45f4-9d36-d51332af7c2c"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("2216f933-a823-4b08-b592-01669bf22b7b"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("4cd71676-03cd-4cb0-8151-cdeb38362d28"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("4f394ad0-8fea-456d-8e65-bfceda355a84"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("92937ecd-c5e8-4e29-adf9-abfd3ecd9442"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("a109899e-d81d-46d4-9e15-edc0f34bc093"));

            migrationBuilder.DeleteData(
                table: "Step",
                keyColumn: "Id",
                keyValue: new Guid("f64d5716-de0d-46b1-8487-7e25cc78e2e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("516f4012-5f25-4c1e-8e75-a076ce71a82d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d535f09b-e140-4cda-9627-03068356ed7b"));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Article",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"),
                columns: new[] { "DateAdded", "Image" },
                values: new object[] { new DateTime(2024, 4, 26, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2049), "123" });

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"),
                columns: new[] { "DateAdded", "Image" },
                values: new object[] { new DateTime(2024, 5, 7, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(1982), "012" });

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"),
                columns: new[] { "DateAdded", "Image" },
                values: new object[] { new DateTime(2024, 4, 28, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2046), "890" });

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"),
                columns: new[] { "DateAdded", "Image" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2043), "567" });

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"),
                columns: new[] { "DateAdded", "Image" },
                values: new object[] { new DateTime(2024, 4, 21, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2058), "011" });

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"),
                columns: new[] { "DateAdded", "Image" },
                values: new object[] { new DateTime(2024, 5, 8, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(1974), "789" });

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"),
                columns: new[] { "DateAdded", "Image" },
                values: new object[] { new DateTime(2024, 4, 24, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2055), "787" });

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"),
                columns: new[] { "DateAdded", "Image" },
                values: new object[] { new DateTime(2024, 5, 5, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2039), "345" });

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"),
                columns: new[] { "DateAdded", "Image" },
                values: new object[] { new DateTime(2024, 4, 24, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2052), "456" });

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"),
                columns: new[] { "DateAdded", "Image" },
                values: new object[] { new DateTime(2024, 4, 13, 23, 0, 49, 119, DateTimeKind.Local).AddTicks(2062), "341" });

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
    }
}
