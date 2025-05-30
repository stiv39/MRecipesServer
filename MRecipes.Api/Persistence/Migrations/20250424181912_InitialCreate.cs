using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MRecipes.Api.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordSalt = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<int>(type: "INTEGER", nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Article_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ArticleId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleComments_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleImage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ArticleId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Image = table.Column<byte[]>(type: "BLOB", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "ArticleTag",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ArticleId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TagId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleTag_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ArticleId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredient_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ArticleId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), "Admin" });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825"), "Hlavný chod" },
                    { new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d"), "Bez laktózy" },
                    { new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c"), "Dezerty" },
                    { new Guid("b1eac43b-9a2a-4e37-94d2-0a59a493c7d3"), "Predjedlá" },
                    { new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843"), "Sladké" },
                    { new Guid("c1d698f0-1f87-4c30-9a31-c26e75d99c4f"), "Šaláty" },
                    { new Guid("d1e13f16-9e32-4d3e-8302-28516d982aef"), "Polievky" },
                    { new Guid("e13e2d0d-c51f-4fa9-97cb-4e6c018474cb"), "Nápoje" },
                    { new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5"), "Bez lepku" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "Name", "PasswordHash", "PasswordSalt", "Role" },
                values: new object[,]
                {
                    { new Guid("2e7744ab-ff9f-42b4-83fb-ab42b2aa66b6"), new DateOnly(2005, 4, 24), "user@gmail.com", "JustUser", "A10EF1777E1CE5BA2A50A7B452CD4B3FF69B3A6BAAA8808CDB0603A5E06B2942FF88BE51F507E36404D20609153A58EAA32B15C4EDD48111CFA0C7B0EBABE6C0", "aw18He+/ve+/vQBtO++/vVbvv709Ee+/ve+/vS9bIhjvv73vv73vv70M77+9Ae+/vTnvv70977+9Lhvvv73vv70w77+9Le+/ve+/ve+/vW9byqHvv73vv70zNSjvv73vv71L77+9Fzzvv70DSe+/ve+/ve+/ve+/vS8=", 0 },
                    { new Guid("cf4ffe09-0d11-446f-a268-e3c73f6e0d0c"), new DateOnly(1995, 4, 24), "admin@gmail.com", "JustAdmin", "72FB6CEA3520ACB1BF2AA3D2110B31A1DC12E342C5D446CF2CA290E064C7B5A138D96F358466E5C4349E739635716D4544F23DDB8BAE0903F23C81B6FB887420", "77+9eQwb77+92bhUXxEAE23vv73vv705e++/ve+/ve+/ve+/vRvvv71V77+9cu+/vTbvv70777+9ay9W77+977+977+977+9Oe+/ve+/vVDvv73vv70o77+977+9FGHvv70vD++/vUDvv73vv73vv73dnXvvv71S77+9KA==", 1 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "AuthorId", "DateAdded", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 4, 12, 20, 19, 12, 161, DateTimeKind.Local).AddTicks(6179), "popis", "Arašidové brownies s malinami" },
                    { new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 4, 23, 20, 19, 12, 161, DateTimeKind.Local).AddTicks(6166), "Tento víkend sme zvrtli novú variáciu rizota! Pôvodne som chcela spraviť tekvicové, ale z debničky na mňa \"žmurkali\" voňavé cherry paradajky, takže bolo spontánne rozhodnuté v prospech dnešného receptu na paradajkové rizoto. :) Rizoto je jeden z mojich najobľúbenejších receptov, jeho príprava nie je vôbec zložitá, stačí vám naň zopár ingrediencií a dokážete ho pripraviť na desiatky spôsobov v závislosti od sezóny. Na mojom blogu nájdete recept na hubové, ale i cviklové rizoto a čoskoro pribudnú aj ďalšie, keďže vás chcem naňho namotať :) Rizoto je úžasne krémové, prevoňané pečenými paradajkami s cesnakom a čerstvou bazalkou. Čochvíľa nám začne sezóna paradajok, tie skleníkové si však môžete dopriať už dnes a využiť ich rovno pri testovaní tohto receptu, prípadne odporúčam vyskúšať moju rýchlu paradajkovú polievku, paradajkový džem či mäsové guľky v paradajkovej omáčke. Verím, že si pochutíte!", "Famózne paradajkové rizoto" },
                    { new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 4, 14, 20, 19, 12, 161, DateTimeKind.Local).AddTicks(6176), "popis", "Jednoduchý grécky šalát" },
                    { new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 4, 17, 20, 19, 12, 161, DateTimeKind.Local).AddTicks(6173), "popis", "Zeleninový tart z lístkového cesta" },
                    { new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 4, 7, 20, 19, 12, 161, DateTimeKind.Local).AddTicks(6186), "popis", "Čokoládový tart" },
                    { new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 4, 24, 20, 19, 12, 161, DateTimeKind.Local).AddTicks(6162), "Ako tak pozerám do kalendára, Veľká noc je už za rohom! Tentokrát mi začiatok roka ubehol ultra rýchlo a človek sa ani nenazdá a bude tu máj a s ním aj ja - opäť o rok staršia. :D Ale nebudem predbiehať, teším sa na Veľkú noc a naše rodinné nedeľné raňajky. Veľkonočnú pasku, hrudku, vajcia natvrdo, údeniny, cviklu s chrenom a zemiakový šalát. Ale nie vždy musí byť Veľká noc len v tradičnom šate. :) Každý rok do nej pridávam aj nejakú tú novinku, naposledy to bola veľkonočná roláda s malinovým krémom, mrkvové mafiny, či avokádová nátierka s granátovým jablkom. A teraz sa môžu moji najbližší tešiť na výborný olivový hummus! Kombinácia cíceru, sezamovej pasty, cesnaku, citrónovej šťavy a olív Kalamata, je výborným krokom na vykročenie do inej svetovej kuchyne. :) Hummus servírovaný s chrumkavou cibuľkou, olivami, kolieskami uhorky a paradajok, pokvapkaný olivovým olejom - u nás doma sa zjedol rýchlosťou blesku a to nie sme milovníci cíceru. Všetky ingrediencie potrebné na tento recept, nájdete pod jednou strechou v Kauflande. Ak ešte nepoznáte ich značku K-Favourites, odporúčam vyskúšať - ingrediencie sú chuťovo výborné a cena príjemná.", "Olivový hummus" },
                    { new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 4, 10, 20, 19, 12, 161, DateTimeKind.Local).AddTicks(6183), "popis", "Tikka Masala" },
                    { new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 4, 21, 20, 19, 12, 161, DateTimeKind.Local).AddTicks(6171), "Blíži sa jar a s ňou aj všetky milé stretnutia s našimi blízkymi. U nás doma som zaviedla tradíciu nedeľných dlhých raňajok a vždy keď máme pred sebou voľný víkend, rada na tieto dlhé raňajky pozývam aj svojich najbližších. Jedlo a konverzácie pri spoločnom stole, ktoré ho sprevádzajú, sú pre mňa jedny z najmilších okamihov, preto rada vymýšľam vždy nové a nové kombinácie jedál, ktorými by som ich pohostila. :) A najradšej sa inšpirujem práve v talianskej kuchyni, keďže tá je známa svojou jednoduchosťou, kvalitnými ingredienciami a pritom zaručene chutným výsledkom. Mnohí z vás už určite poznajú recept na chrumkavú paradajkovú bruschettu, ktorú nájdete v mojej prvej kuchárskej knihe. Tento recept je jej malou obmenou, je však vhodný pre všetkých bezlepkáčov, nakoľko v ňom nájdete aj tip na bezgluténové pečivo od Kauflandu. V ich sortimente nájdete pod značkou K-free bezgluténové pečivo a cestoviny, ktoré rada využívam pri príprave bezlepkových receptov. Na chrumkavú bruschettu vám stačí zopár ingrediencií a výsledok je neuveriteľne chutný! Budem sa tešiť, ak recept najbližšie vyskúšate a dáte mi vedieť, ako vám chutilo.", "Chrumkavá paradajková bruschetta" },
                    { new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 4, 10, 20, 19, 12, 161, DateTimeKind.Local).AddTicks(6181), "popis", "Paella s morskými plodmi" },
                    { new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 3, 30, 20, 19, 12, 161, DateTimeKind.Local).AddTicks(6188), "popis", "Špagety Bolognese" }
                });

            migrationBuilder.InsertData(
                table: "ArticleComments",
                columns: new[] { "Id", "ArticleId", "DateAdded", "Description", "Name" },
                values: new object[] { new Guid("5e2eca48-f299-4ffd-8c7c-e2de7e837420"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new DateTime(2025, 4, 22, 20, 19, 12, 161, DateTimeKind.Local).AddTicks(6205), "mnam do pyska", "jozka" });

            migrationBuilder.InsertData(
                table: "ArticleTag",
                columns: new[] { "Id", "ArticleId", "TagId" },
                values: new object[,]
                {
                    { new Guid("06689632-7dfb-4263-a1fe-86ad19d312ca"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("0689b2bf-4a15-45b9-9bda-40ef5a84e85f"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },
                    { new Guid("0b094f41-8f87-4fb0-bc0d-46c2d24c5aa9"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("1257ba62-43a8-4abe-bf9c-00d8e65ef0c4"), new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },
                    { new Guid("13f10a3d-3ba7-4146-a428-64a3d4981b17"), new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("1b79e6fe-7041-4d26-95c0-572920daa51f"), new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("2c0a0dc6-df32-4cd6-ba9a-dbf58b8ffbca"), new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("2cc9b314-0d77-47d4-b9dc-97fb5a91aeb2"), new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("502ee046-dde4-4e85-83b0-1ac14f9294f8"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") },
                    { new Guid("63d8f7cb-87b7-46cc-a7ec-3ebac81f10b7"), new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("c1d698f0-1f87-4c30-9a31-c26e75d99c4f") },
                    { new Guid("82577e65-652a-41db-9b91-9d27a9f96539"), new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("8d41eb1c-ab3c-46f6-be4b-107480533811"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("90b9016e-6416-4b91-8d6f-936757ed6beb"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("9d50e034-75d1-4d33-91eb-586e9ccddce9"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("c42f0a7d-b068-4bee-8d05-f6fc923ec703"), new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("d888755c-749e-43bb-b20e-dad854ab7c8f"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") },
                    { new Guid("e1d1a55c-b915-41d0-935f-f4d24e02d7a4"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("b1eac43b-9a2a-4e37-94d2-0a59a493c7d3") },
                    { new Guid("e67b1a40-8f3a-43f4-b962-f6cbf29e3efa"), new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("f970ee82-f789-4373-b0d9-1cb2215fd3c2"), new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") },
                    { new Guid("fb7dd54f-82c0-47e8-8eb2-560fdf19bad1"), new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") }
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { new Guid("00c33344-93f5-4e9f-8c68-e08711335f46"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "100 g parmezánu" },
                    { new Guid("033be4b3-1828-43b8-8350-53787085f678"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "500 g cherry paradajok" },
                    { new Guid("0d38ad4a-0a72-46db-96d8-76756e4db844"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "3 plátky masla" },
                    { new Guid("0fef96f9-5be9-445e-acd9-15267635aab8"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "sušená bazalka" },
                    { new Guid("12979312-e281-4f56-bf48-c2c04e6c5c03"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "500 g cherry paradajok" },
                    { new Guid("1e4e7748-b8ff-4842-890f-241feda19c18"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1/2 ČL rímskej rasce" },
                    { new Guid("26506aa6-4fe5-4930-b511-243a6e1eb04f"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "soľ a čierne korenie" },
                    { new Guid("299d18b8-ff83-43a4-b622-a1ace5d93ca1"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "hrsť lístkov bazalky" },
                    { new Guid("2c4f52b1-fe04-44b9-9292-ee0912bd10e5"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1 - 2 strúčiky cesnaku" },
                    { new Guid("3c53ed3a-11cf-472c-a421-32f72ad9f024"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1 PL panenského olivového oleja" },
                    { new Guid("43da2dfb-40d1-4edb-b21a-803fe08a7a70"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "mozzarella" },
                    { new Guid("503c08e8-e29a-4ecf-998e-4769e18fb82c"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "sušené oregano" },
                    { new Guid("51d790d0-6423-4933-aca4-cd8610cee18a"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "300 g ryže arborio" },
                    { new Guid("5a7921f1-e780-4049-832c-84fc712cb2c7"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "2 PL studenej vody'" },
                    { new Guid("62dc5b90-ea8d-4e46-9b4f-3410ea27a88d"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "1 bageta alebo iné pečivo (pre verziu bez lepku odporúčam použiť 1 balenie bezlepkových svetlých žemlí K-free, ktoré nájdete v Kauflande)" },
                    { new Guid("6f967387-8440-477c-8cfc-03b0fb486400"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "40 g nakrájaných olív Kalamata (ja som použila olivy Kalamata K-Favourites, ktoré nájdete v Kauflande)" },
                    { new Guid("7565ec28-fca8-4ed1-8d81-04ecd6ec8fe7"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "300 ml paradajkového pretlaku/passaty" },
                    { new Guid("911fbbfe-d5fa-4432-8ae7-438af60362dd"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "700 ml vývaru/vody" },
                    { new Guid("b6bcb6d1-ed42-4f75-98d4-9b1cbf26bd25"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "soľ a čierne korenie" },
                    { new Guid("bdbdcfbf-c732-4834-8a42-906f09795b25"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "200 ml bieleho suchého vína" },
                    { new Guid("c4ebe4dc-ac2b-4dbd-b072-39a88438ea13"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "panenský olivový olej" },
                    { new Guid("ca1e32c0-61a5-4129-ba54-63e7369bf771"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "7 PL panenského olivového oleja" },
                    { new Guid("d7ba4c9e-59d0-4fb8-8dbf-84e82493fac9"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "25 ml šťavy z citróna" },
                    { new Guid("d90121cb-4ca8-48ca-a420-2d2cc0499e94"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "250 g predvareného cíceru" },
                    { new Guid("e859110a-b49f-4fd3-9385-14b86080bb00"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "1 cibuľa" },
                    { new Guid("e987548c-2766-4aeb-9998-b9e54247deb5"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "3 strúčiky cesnaku" },
                    { new Guid("f05ae3d1-46c6-45e0-a9c4-d7eb77f7df6e"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "hrsť čerstvej bazalky" },
                    { new Guid("fbfe6ead-90fe-46da-b426-89b37d0961d2"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "60 g sezamovej pasty" },
                    { new Guid("fc008f36-6661-4e13-aa8c-6cd62e882d2a"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "bazalkové pesto" },
                    { new Guid("fccf5ca7-1762-4d9e-987e-0cc5fa1bc266"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "4 strúčiky cesnaku" },
                    { new Guid("fd71ad43-ee76-4280-88d7-07ad43637d9d"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "soľ a čierne korenie" }
                });

            migrationBuilder.InsertData(
                table: "Step",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { new Guid("0573d544-0735-4699-9288-923fca5a1215"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "Predvarený cícer z konzervy prepláchneme, preložíme do hrnca, zalejeme vodou, jemne osolíme a privedieme do varu. Keď začne vrieť, znížime teplotu a prikrytý varíme približne 20 minút. Mäkký cícer prepláchneme studenou vodou a zbavíme šupiek. Presypeme ho do výkonného mixéra a pridáme k nemu ostatné ingrediencie na hummus. Vymixujeme dohladka a v prípade potreby pridáme trochu vody. Dochutíme soľou, čiernym korením a citrónovou šťavou." },
                    { new Guid("1a8b7431-2103-4fa4-9ccb-82dd2af5e185"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "Bagetu alebo iné pečivo nakrájame na približne rovnaké kúsky. Ak použijete bezlepkové svetlé žemle K-free od Kauflandu, prekrojte ich na polovicu. Jednotlivé kúsky potrieme zvyšným olivovým olejom, ktorý zostal v miske a opečieme na grile, panvici alebo vložíme na 10 minút do rúry. Chrumkavé pečivo potrieme pestom, na to dáme plátok mozzarelly, grilované paradajky a lístky čerstvej bazalky." },
                    { new Guid("3575dcc5-1799-4999-817e-ce6958eccea5"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Prilejeme paradajkový pretlak/passatu a dobre premiešame. Znížime teplotu na stredný plameň, pridáme naberačku teplého vývaru alebo osolenej vody a pravidelne miešame, kým sa voda nevstrebe. Pokračujeme v postupnom pridávaní vody a zakaždým premiešavame, kým sa voda nevstrebe a ryža sa neuvarí al dente. Ryža je hotová vtedy, keď je obklopená krémovou tekutinou a po ochutnaní je jemne chrumkavá. Celý proces varenia trvá cca 25 minút." },
                    { new Guid("40c1a039-5e1d-47a5-8d5a-7d45d55c3db4"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "Paradajky nakrájame na menšie kúsky a vložíme do misky. Zalejeme ich olivovým olejom, pridáme prelisované strúčiky cesnaku, ochutíme soľou a čiernym korením a dobre premiešame. Necháme pár minút postáť. Následne paradajky preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme približne 30 minút, kým nezmäknú." },
                    { new Guid("81cefcb4-35c9-44db-886e-82dd693684e5"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "Hummus pred podávaním ochutíme trochou mletej červenej papriky, pokvapkáme olivovým olejom a ozdobíme nakrájanou cibuľou, paradajkami, kolieskami uhorky a hrsťou zelených a čiernych olív. Servírujeme s plátkami citróna, slanými krekrami a výberom rôznych salám a syrov." },
                    { new Guid("a1f6ae40-7b14-4d6e-ad0c-5c1f68a58d14"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Paradajky nakrájame na štvrtiny a vložíme do misky. Pokvapkáme ich olivovým olejom (cca 5 PL panenského olivového oleja), pridáme prelisované strúčiky cesnaku a ochutíme soľou a čiernym korením. Premiešame lyžicou a necháme pár minút odležať. Následne celú zmes preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme 25 minút." },
                    { new Guid("dee57e82-d47b-4638-961d-c47ecbe335f5"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "V menšom hrnci zohrejeme kurací alebo zeleninový vývar. Ak vývar nemáte, môžete použiť aj vodu - do menšieho hrnca dajte zohriať 700 ml vody a keď bude horúca, pridajte do nej lyžičku soli a dobre premiešajte. Vývar, prípadne vodu zohrievame preto, aby mali podobnú teplotu ako ryža. Vďaka tomu sa nezastaví proces varenia a budete mať rizoto presne také, aké má byť - krémové a neskutočne dobré." },
                    { new Guid("eeab537e-cb20-45c2-8d7a-d4386e4e57b7"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Kým sa vývar/voda zohrieva, zohrejeme si v hlbokej panvici olivový olej, pridáme nadrobno nasekanú cibuľu a opečieme dosklovita. Prisypeme nepremytú ryžu arborio (môžete použiť aj carnaroli ryžu) a poriadne premiešame, aby sa ryža obalila vo vrstve oleja. Opekáme cca 4 minúty, pričom ryžu pravidelne premiešavame. Prilejeme víno a za občasného miešania privedieme do varu. Varíme cca 2 minúty, kým sa víno neodparí." },
                    { new Guid("fdadd3d8-990b-470c-9ad4-ddba8d662fca"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Rizoto stiahneme zo sporáka, pridáme k nemu plátky masla a nastrúhaný parmezán a vareškou jemne premiešame. Podľa potreby dochutíme soľou, čiernym korením, trochou sušeného oregana a bazalky. Rizoto servírujeme v hlbokých tanieroch, navrch dáme pečené paradajky a ozdobíme lístkami čerstvej bazalky. Rizoto podávame hneď po uvarení, vtedy chutí najlepšie, s pohárom bieleho vína priam dokonale!" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_AuthorId",
                table: "Article",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleComments_ArticleId",
                table: "ArticleComments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleImage_ArticleId",
                table: "ArticleImage",
                column: "ArticleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTag_ArticleId",
                table: "ArticleTag",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTag_TagId",
                table: "ArticleTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_ArticleId",
                table: "Ingredient",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Step_ArticleId",
                table: "Step",
                column: "ArticleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleComments");

            migrationBuilder.DropTable(
                name: "ArticleImage");

            migrationBuilder.DropTable(
                name: "ArticleTag");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Step");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
