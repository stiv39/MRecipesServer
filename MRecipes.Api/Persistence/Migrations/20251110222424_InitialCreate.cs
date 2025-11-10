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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "ArticleTag",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    { new Guid("70a314d3-c514-4c72-8086-eb8479872069"), new DateOnly(1995, 11, 10), "admin@gmail.com", "JustAdmin", "72FB6CEA3520ACB1BF2AA3D2110B31A1DC12E342C5D446CF2CA290E064C7B5A138D96F358466E5C4349E739635716D4544F23DDB8BAE0903F23C81B6FB887420", "77+9eQwb77+92bhUXxEAE23vv73vv705e++/ve+/ve+/ve+/vRvvv71V77+9cu+/vTbvv70777+9ay9W77+977+977+977+9Oe+/ve+/vVDvv73vv70o77+977+9FGHvv70vD++/vUDvv73vv73vv73dnXvvv71S77+9KA==", 1 },
                    { new Guid("b640a42d-6f9e-4284-b1ff-926971b1c32a"), new DateOnly(2005, 11, 10), "user@gmail.com", "JustUser", "A10EF1777E1CE5BA2A50A7B452CD4B3FF69B3A6BAAA8808CDB0603A5E06B2942FF88BE51F507E36404D20609153A58EAA32B15C4EDD48111CFA0C7B0EBABE6C0", "aw18He+/ve+/vQBtO++/vVbvv709Ee+/ve+/vS9bIhjvv73vv73vv70M77+9Ae+/vTnvv70977+9Lhvvv73vv70w77+9Le+/ve+/ve+/vW9byqHvv73vv70zNSjvv73vv71L77+9Fzzvv70DSe+/ve+/ve+/ve+/vS8=", 0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "AuthorId", "DateAdded", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 10, 29, 23, 24, 24, 346, DateTimeKind.Local).AddTicks(9147), "popis", "Arašidové brownies s malinami" },
                    { new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 11, 9, 23, 24, 24, 346, DateTimeKind.Local).AddTicks(9134), "Tento víkend sme zvrtli novú variáciu rizota! Pôvodne som chcela spraviť tekvicové, ale z debničky na mňa \"žmurkali\" voňavé cherry paradajky, takže bolo spontánne rozhodnuté v prospech dnešného receptu na paradajkové rizoto. :) Rizoto je jeden z mojich najobľúbenejších receptov, jeho príprava nie je vôbec zložitá, stačí vám naň zopár ingrediencií a dokážete ho pripraviť na desiatky spôsobov v závislosti od sezóny. Na mojom blogu nájdete recept na hubové, ale i cviklové rizoto a čoskoro pribudnú aj ďalšie, keďže vás chcem naňho namotať :) Rizoto je úžasne krémové, prevoňané pečenými paradajkami s cesnakom a čerstvou bazalkou. Čochvíľa nám začne sezóna paradajok, tie skleníkové si však môžete dopriať už dnes a využiť ich rovno pri testovaní tohto receptu, prípadne odporúčam vyskúšať moju rýchlu paradajkovú polievku, paradajkový džem či mäsové guľky v paradajkovej omáčke. Verím, že si pochutíte!", "Famózne paradajkové rizoto" },
                    { new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 10, 31, 23, 24, 24, 346, DateTimeKind.Local).AddTicks(9144), "popis", "Jednoduchý grécky šalát" },
                    { new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 11, 3, 23, 24, 24, 346, DateTimeKind.Local).AddTicks(9142), "popis", "Zeleninový tart z lístkového cesta" },
                    { new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 10, 24, 23, 24, 24, 346, DateTimeKind.Local).AddTicks(9154), "popis", "Čokoládový tart" },
                    { new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 11, 10, 23, 24, 24, 346, DateTimeKind.Local).AddTicks(9127), "Ako tak pozerám do kalendára, Veľká noc je už za rohom! Tentokrát mi začiatok roka ubehol ultra rýchlo a človek sa ani nenazdá a bude tu máj a s ním aj ja - opäť o rok staršia. :D Ale nebudem predbiehať, teším sa na Veľkú noc a naše rodinné nedeľné raňajky. Veľkonočnú pasku, hrudku, vajcia natvrdo, údeniny, cviklu s chrenom a zemiakový šalát. Ale nie vždy musí byť Veľká noc len v tradičnom šate. :) Každý rok do nej pridávam aj nejakú tú novinku, naposledy to bola veľkonočná roláda s malinovým krémom, mrkvové mafiny, či avokádová nátierka s granátovým jablkom. A teraz sa môžu moji najbližší tešiť na výborný olivový hummus! Kombinácia cíceru, sezamovej pasty, cesnaku, citrónovej šťavy a olív Kalamata, je výborným krokom na vykročenie do inej svetovej kuchyne. :) Hummus servírovaný s chrumkavou cibuľkou, olivami, kolieskami uhorky a paradajok, pokvapkaný olivovým olejom - u nás doma sa zjedol rýchlosťou blesku a to nie sme milovníci cíceru. Všetky ingrediencie potrebné na tento recept, nájdete pod jednou strechou v Kauflande. Ak ešte nepoznáte ich značku K-Favourites, odporúčam vyskúšať - ingrediencie sú chuťovo výborné a cena príjemná.", "Olivový hummus" },
                    { new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 10, 27, 23, 24, 24, 346, DateTimeKind.Local).AddTicks(9151), "popis", "Tikka Masala" },
                    { new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 11, 7, 23, 24, 24, 346, DateTimeKind.Local).AddTicks(9139), "Blíži sa jar a s ňou aj všetky milé stretnutia s našimi blízkymi. U nás doma som zaviedla tradíciu nedeľných dlhých raňajok a vždy keď máme pred sebou voľný víkend, rada na tieto dlhé raňajky pozývam aj svojich najbližších. Jedlo a konverzácie pri spoločnom stole, ktoré ho sprevádzajú, sú pre mňa jedny z najmilších okamihov, preto rada vymýšľam vždy nové a nové kombinácie jedál, ktorými by som ich pohostila. :) A najradšej sa inšpirujem práve v talianskej kuchyni, keďže tá je známa svojou jednoduchosťou, kvalitnými ingredienciami a pritom zaručene chutným výsledkom. Mnohí z vás už určite poznajú recept na chrumkavú paradajkovú bruschettu, ktorú nájdete v mojej prvej kuchárskej knihe. Tento recept je jej malou obmenou, je však vhodný pre všetkých bezlepkáčov, nakoľko v ňom nájdete aj tip na bezgluténové pečivo od Kauflandu. V ich sortimente nájdete pod značkou K-free bezgluténové pečivo a cestoviny, ktoré rada využívam pri príprave bezlepkových receptov. Na chrumkavú bruschettu vám stačí zopár ingrediencií a výsledok je neuveriteľne chutný! Budem sa tešiť, ak recept najbližšie vyskúšate a dáte mi vedieť, ako vám chutilo.", "Chrumkavá paradajková bruschetta" },
                    { new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 10, 27, 23, 24, 24, 346, DateTimeKind.Local).AddTicks(9149), "popis", "Paella s morskými plodmi" },
                    { new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2025, 10, 16, 23, 24, 24, 346, DateTimeKind.Local).AddTicks(9156), "popis", "Špagety Bolognese" }
                });

            migrationBuilder.InsertData(
                table: "ArticleComments",
                columns: new[] { "Id", "ArticleId", "DateAdded", "Description", "Name" },
                values: new object[] { new Guid("131f5ce6-3ecb-424a-bd6e-901ca05cf011"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new DateTime(2025, 11, 8, 23, 24, 24, 346, DateTimeKind.Local).AddTicks(9188), "mnam do pyska", "jozka" });

            migrationBuilder.InsertData(
                table: "ArticleTag",
                columns: new[] { "Id", "ArticleId", "TagId" },
                values: new object[,]
                {
                    { new Guid("02864679-86a5-4a3c-938f-10f85becee50"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("10fbd90d-8348-4476-bd34-102a816a0034"), new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("1d0490db-8256-422a-bdd5-79f0a0eaf292"), new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") },
                    { new Guid("28308f8d-df77-4ac8-b538-507c1d5e6e2e"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("2e653475-f80d-4eb0-901e-90f7b472ed7e"), new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("c1d698f0-1f87-4c30-9a31-c26e75d99c4f") },
                    { new Guid("37b2ff1f-34eb-4c33-ab9c-8d020d11f7ec"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("b1eac43b-9a2a-4e37-94d2-0a59a493c7d3") },
                    { new Guid("3bbbe167-995d-453e-bebb-1efc16ebbcef"), new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") },
                    { new Guid("4f50c1e0-a0a4-40ab-9617-340b65e31158"), new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("57d73990-0a08-4fe2-a95a-aa968149670d"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("86c3517a-50a9-450e-a93a-6266b4d89b3b"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("8827e82f-6979-4534-9bc2-3b7379537533"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },
                    { new Guid("9892d9dc-6ec7-49b3-a560-d86fc5a47369"), new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },
                    { new Guid("a6eae0de-4ad4-40af-acac-22a75e5b90ff"), new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("b560d809-89a9-4eae-bd63-623f93f798c2"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("bf8b8d1f-1c52-4875-85bb-f19798a4f6f4"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") },
                    { new Guid("bfb56316-cc15-4f54-aaeb-819ca925fa5e"), new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("cee0dab5-94d5-4f51-a2e1-a89a88438bcb"), new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("d668a1de-d9a6-4cfb-859c-e77b026dbf43"), new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
                    { new Guid("edecc511-ae8a-47b9-8c98-1a07e1e00f53"), new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"), new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
                    { new Guid("f6acf27d-0001-4f2e-8c78-2a26f21d92a5"), new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") }
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { new Guid("019570da-b5fb-4589-aff2-4bd0a28c95ea"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "mozzarella" },
                    { new Guid("0254cfaa-47d8-4dd9-9cc2-8bce913bb323"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1 - 2 strúčiky cesnaku" },
                    { new Guid("061538e1-5df1-4626-b44a-81ecf583ffbf"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "4 strúčiky cesnaku" },
                    { new Guid("066adaee-5bb7-4f94-af72-90d28402acc5"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1 PL panenského olivového oleja" },
                    { new Guid("0757f4d8-6926-4e37-9329-ffa6c46d3215"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "200 ml bieleho suchého vína" },
                    { new Guid("10479e2c-4948-4798-8b37-99cd28cc83e2"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "sušené oregano" },
                    { new Guid("11b1a312-6420-40d8-bc26-e4bfa8b6eb9a"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "25 ml šťavy z citróna" },
                    { new Guid("180aa483-8d57-489e-af12-a963de53b9ba"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "2 PL studenej vody'" },
                    { new Guid("4094477f-9264-4eb1-be52-ec22626e6362"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "250 g predvareného cíceru" },
                    { new Guid("46f6c476-20f0-493c-a4fb-6542f9c799ce"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "1 bageta alebo iné pečivo (pre verziu bez lepku odporúčam použiť 1 balenie bezlepkových svetlých žemlí K-free, ktoré nájdete v Kauflande)" },
                    { new Guid("552a0e05-6a6b-4461-9b7d-d4ac88fc42f0"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "hrsť čerstvej bazalky" },
                    { new Guid("57783e9a-e9c2-4d82-b070-3e8e8b27783c"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "1/2 ČL rímskej rasce" },
                    { new Guid("5a47787d-aef4-429d-8951-0ac772743089"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "500 g cherry paradajok" },
                    { new Guid("71350754-7e5d-49da-bc54-f047e53c32b3"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "soľ a čierne korenie" },
                    { new Guid("7417bef1-0dd7-49f1-90f9-dcdaf219cef4"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "300 g ryže arborio" },
                    { new Guid("7741df84-3885-4e11-b2ad-2b8bb1501d84"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "1 cibuľa" },
                    { new Guid("89d3b621-a20d-4f4b-ac5c-e572180ab71f"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "100 g parmezánu" },
                    { new Guid("966cdbc8-7923-4805-9c05-7eae370e584e"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "3 strúčiky cesnaku" },
                    { new Guid("a3c8660a-0702-476f-8615-b082b1fab5c3"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "sušená bazalka" },
                    { new Guid("ac9fae03-f98c-4d7a-8239-3d2c10dc5f4e"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "40 g nakrájaných olív Kalamata (ja som použila olivy Kalamata K-Favourites, ktoré nájdete v Kauflande)" },
                    { new Guid("bbdd1db1-373b-491a-939a-93d5ab3a813b"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "panenský olivový olej" },
                    { new Guid("bd01e731-8f4c-474a-abb9-eaf19bbf29a7"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "soľ a čierne korenie" },
                    { new Guid("c0a6ea98-2a3f-4caf-99dc-78b9aa54fdbc"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "7 PL panenského olivového oleja" },
                    { new Guid("c5799ba8-f0a7-4902-81b9-f5d36a26ee9a"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "500 g cherry paradajok" },
                    { new Guid("d1d7fa33-a658-470e-abb5-5d323cbca271"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "700 ml vývaru/vody" },
                    { new Guid("d9d41dec-36c5-4fbb-9391-f16f50545540"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "soľ a čierne korenie" },
                    { new Guid("e6adaa1c-f239-439a-9abc-4ee533134dc0"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "hrsť lístkov bazalky" },
                    { new Guid("e7aad0d2-ff19-4c9b-b72b-4bfd02dbcd8c"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "3 plátky masla" },
                    { new Guid("f52ff107-7c86-4a1b-a3be-cb3957a9ee24"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "300 ml paradajkového pretlaku/passaty" },
                    { new Guid("f56b2216-f10e-4d60-a22d-887f40c64d18"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "60 g sezamovej pasty" },
                    { new Guid("f796e29b-9c76-431b-8bcf-fbf54f453567"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "bazalkové pesto" }
                });

            migrationBuilder.InsertData(
                table: "Step",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { new Guid("0a80defc-3da0-460c-8b17-b1eaf5ab9c5b"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "V menšom hrnci zohrejeme kurací alebo zeleninový vývar. Ak vývar nemáte, môžete použiť aj vodu - do menšieho hrnca dajte zohriať 700 ml vody a keď bude horúca, pridajte do nej lyžičku soli a dobre premiešajte. Vývar, prípadne vodu zohrievame preto, aby mali podobnú teplotu ako ryža. Vďaka tomu sa nezastaví proces varenia a budete mať rizoto presne také, aké má byť - krémové a neskutočne dobré." },
                    { new Guid("1d735be0-fd39-490c-8640-6598fa25d1ff"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Kým sa vývar/voda zohrieva, zohrejeme si v hlbokej panvici olivový olej, pridáme nadrobno nasekanú cibuľu a opečieme dosklovita. Prisypeme nepremytú ryžu arborio (môžete použiť aj carnaroli ryžu) a poriadne premiešame, aby sa ryža obalila vo vrstve oleja. Opekáme cca 4 minúty, pričom ryžu pravidelne premiešavame. Prilejeme víno a za občasného miešania privedieme do varu. Varíme cca 2 minúty, kým sa víno neodparí." },
                    { new Guid("441ad46d-ee68-4419-9858-502862edb183"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "Predvarený cícer z konzervy prepláchneme, preložíme do hrnca, zalejeme vodou, jemne osolíme a privedieme do varu. Keď začne vrieť, znížime teplotu a prikrytý varíme približne 20 minút. Mäkký cícer prepláchneme studenou vodou a zbavíme šupiek. Presypeme ho do výkonného mixéra a pridáme k nemu ostatné ingrediencie na hummus. Vymixujeme dohladka a v prípade potreby pridáme trochu vody. Dochutíme soľou, čiernym korením a citrónovou šťavou." },
                    { new Guid("4a2876ac-c3d7-4c94-9d0f-0696600c03d2"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "Bagetu alebo iné pečivo nakrájame na približne rovnaké kúsky. Ak použijete bezlepkové svetlé žemle K-free od Kauflandu, prekrojte ich na polovicu. Jednotlivé kúsky potrieme zvyšným olivovým olejom, ktorý zostal v miske a opečieme na grile, panvici alebo vložíme na 10 minút do rúry. Chrumkavé pečivo potrieme pestom, na to dáme plátok mozzarelly, grilované paradajky a lístky čerstvej bazalky." },
                    { new Guid("bda9829d-627a-4581-b8bc-8647e6464fca"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Rizoto stiahneme zo sporáka, pridáme k nemu plátky masla a nastrúhaný parmezán a vareškou jemne premiešame. Podľa potreby dochutíme soľou, čiernym korením, trochou sušeného oregana a bazalky. Rizoto servírujeme v hlbokých tanieroch, navrch dáme pečené paradajky a ozdobíme lístkami čerstvej bazalky. Rizoto podávame hneď po uvarení, vtedy chutí najlepšie, s pohárom bieleho vína priam dokonale!" },
                    { new Guid("c25019cf-74c6-4a8d-9067-a34b88119ff1"), new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), "Hummus pred podávaním ochutíme trochou mletej červenej papriky, pokvapkáme olivovým olejom a ozdobíme nakrájanou cibuľou, paradajkami, kolieskami uhorky a hrsťou zelených a čiernych olív. Servírujeme s plátkami citróna, slanými krekrami a výberom rôznych salám a syrov." },
                    { new Guid("c8bac7ba-3f20-4cdd-90c2-de9ae55efe2c"), new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), "Paradajky nakrájame na menšie kúsky a vložíme do misky. Zalejeme ich olivovým olejom, pridáme prelisované strúčiky cesnaku, ochutíme soľou a čiernym korením a dobre premiešame. Necháme pár minút postáť. Následne paradajky preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme približne 30 minút, kým nezmäknú." },
                    { new Guid("d3f9845c-b87e-475e-a62f-f78db30c33e1"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Prilejeme paradajkový pretlak/passatu a dobre premiešame. Znížime teplotu na stredný plameň, pridáme naberačku teplého vývaru alebo osolenej vody a pravidelne miešame, kým sa voda nevstrebe. Pokračujeme v postupnom pridávaní vody a zakaždým premiešavame, kým sa voda nevstrebe a ryža sa neuvarí al dente. Ryža je hotová vtedy, keď je obklopená krémovou tekutinou a po ochutnaní je jemne chrumkavá. Celý proces varenia trvá cca 25 minút." },
                    { new Guid("d7d98939-7422-4b71-bc9c-c3e471f35e9b"), new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), "Paradajky nakrájame na štvrtiny a vložíme do misky. Pokvapkáme ich olivovým olejom (cca 5 PL panenského olivového oleja), pridáme prelisované strúčiky cesnaku a ochutíme soľou a čiernym korením. Premiešame lyžicou a necháme pár minút odležať. Následne celú zmes preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme 25 minút." }
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
