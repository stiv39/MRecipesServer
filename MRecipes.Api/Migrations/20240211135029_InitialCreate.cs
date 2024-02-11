using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MRecipes.Api.Migrations
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
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                table: "Article",
                columns: new[] { "Id", "AuthorId", "DateAdded", "Description", "Image", "Title" },
                values: new object[,]
                {
                    { new Guid("0860d50a-927f-4d9c-8780-6f8054c20814"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2024, 1, 30, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(697), "popis", "123", "Arašidové brownies s malinami" },
                    { new Guid("11d5122f-8e94-485a-bf2c-8c432b254cc3"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2024, 2, 10, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(683), "Tento víkend sme zvrtli novú variáciu rizota! Pôvodne som chcela spraviť tekvicové, ale z debničky na mňa \"žmurkali\" voňavé cherry paradajky, takže bolo spontánne rozhodnuté v prospech dnešného receptu na paradajkové rizoto. :) Rizoto je jeden z mojich najobľúbenejších receptov, jeho príprava nie je vôbec zložitá, stačí vám naň zopár ingrediencií a dokážete ho pripraviť na desiatky spôsobov v závislosti od sezóny. Na mojom blogu nájdete recept na hubové, ale i cviklové rizoto a čoskoro pribudnú aj ďalšie, keďže vás chcem naňho namotať :) Rizoto je úžasne krémové, prevoňané pečenými paradajkami s cesnakom a čerstvou bazalkou. Čochvíľa nám začne sezóna paradajok, tie skleníkové si však môžete dopriať už dnes a využiť ich rovno pri testovaní tohto receptu, prípadne odporúčam vyskúšať moju rýchlu paradajkovú polievku, paradajkový džem či mäsové guľky v paradajkovej omáčke. Verím, že si pochutíte!", "012", "Famózne paradajkové rizoto" },
                    { new Guid("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2024, 2, 1, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(693), "popis", "890", "Jednoduchý grécky šalát" },
                    { new Guid("4c26d85b-3146-4ed2-9f2c-3993e02ee888"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2024, 2, 4, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(691), "popis", "567", "Zeleninový tart z lístkového cesta" },
                    { new Guid("90378085-c0de-4c91-a83c-d216d246b2b1"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2024, 1, 25, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(705), "popis", "011", "Čokoládový tart" },
                    { new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2024, 2, 11, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(635), "Ako tak pozerám do kalendára, Veľká noc je už za rohom! Tentokrát mi začiatok roka ubehol ultra rýchlo a človek sa ani nenazdá a bude tu máj a s ním aj ja - opäť o rok staršia. :D Ale nebudem predbiehať, teším sa na Veľkú noc a naše rodinné nedeľné raňajky. Veľkonočnú pasku, hrudku, vajcia natvrdo, údeniny, cviklu s chrenom a zemiakový šalát. Ale nie vždy musí byť Veľká noc len v tradičnom šate. :) Každý rok do nej pridávam aj nejakú tú novinku, naposledy to bola veľkonočná roláda s malinovým krémom, mrkvové mafiny, či avokádová nátierka s granátovým jablkom. A teraz sa môžu moji najbližší tešiť na výborný olivový hummus! Kombinácia cíceru, sezamovej pasty, cesnaku, citrónovej šťavy a olív Kalamata, je výborným krokom na vykročenie do inej svetovej kuchyne. :) Hummus servírovaný s chrumkavou cibuľkou, olivami, kolieskami uhorky a paradajok, pokvapkaný olivovým olejom - u nás doma sa zjedol rýchlosťou blesku a to nie sme milovníci cíceru. Všetky ingrediencie potrebné na tento recept, nájdete pod jednou strechou v Kauflande. Ak ešte nepoznáte ich značku K-Favourites, odporúčam vyskúšať - ingrediencie sú chuťovo výborné a cena príjemná.", "789", "Olivový hummus" },
                    { new Guid("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2024, 1, 28, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(703), "popis", "787", "Tikka Masala" },
                    { new Guid("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2024, 2, 8, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(688), "Blíži sa jar a s ňou aj všetky milé stretnutia s našimi blízkymi. U nás doma som zaviedla tradíciu nedeľných dlhých raňajok a vždy keď máme pred sebou voľný víkend, rada na tieto dlhé raňajky pozývam aj svojich najbližších. Jedlo a konverzácie pri spoločnom stole, ktoré ho sprevádzajú, sú pre mňa jedny z najmilších okamihov, preto rada vymýšľam vždy nové a nové kombinácie jedál, ktorými by som ich pohostila. :) A najradšej sa inšpirujem práve v talianskej kuchyni, keďže tá je známa svojou jednoduchosťou, kvalitnými ingredienciami a pritom zaručene chutným výsledkom. Mnohí z vás už určite poznajú recept na chrumkavú paradajkovú bruschettu, ktorú nájdete v mojej prvej kuchárskej knihe. Tento recept je jej malou obmenou, je však vhodný pre všetkých bezlepkáčov, nakoľko v ňom nájdete aj tip na bezgluténové pečivo od Kauflandu. V ich sortimente nájdete pod značkou K-free bezgluténové pečivo a cestoviny, ktoré rada využívam pri príprave bezlepkových receptov. Na chrumkavú bruschettu vám stačí zopár ingrediencií a výsledok je neuveriteľne chutný! Budem sa tešiť, ak recept najbližšie vyskúšate a dáte mi vedieť, ako vám chutilo.", "345", "Chrumkavá paradajková bruschetta" },
                    { new Guid("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2024, 1, 28, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(700), "popis", "456", "Paella s morskými plodmi" },
                    { new Guid("e62c4460-2829-4f20-b747-5ef468d02d17"), new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), new DateTime(2024, 1, 17, 14, 50, 29, 34, DateTimeKind.Local).AddTicks(708), "popis", "341", "Špagety Bolognese" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Article_AuthorId",
                table: "Article",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleComments_ArticleId",
                table: "ArticleComments",
                column: "ArticleId");

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
                name: "ArticleTag");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Step");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
