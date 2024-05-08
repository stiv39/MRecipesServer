using Microsoft.EntityFrameworkCore;
using MRecipes.Api.Models;

namespace MRecipes.Api.Persistence;

public class MRecipesDbContext : DbContext
{
    public MRecipesDbContext(DbContextOptions<MRecipesDbContext> options) : base(options)
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<ArticleComment> ArticleComments { get; set; }
    public DbSet<User> Users { get; set; }

     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(MRecipesDbContext).Assembly);

        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = Guid.NewGuid(),
                Email = "user@gmail.com",
                Name = "JustUser",
                PasswordHash = "A10EF1777E1CE5BA2A50A7B452CD4B3FF69B3A6BAAA8808CDB0603A5E06B2942FF88BE51F507E36404D20609153A58EAA32B15C4EDD48111CFA0C7B0EBABE6C0",
                PasswordSalt = "aw18He+/ve+/vQBtO++/vVbvv709Ee+/ve+/vS9bIhjvv73vv73vv70M77+9Ae+/vTnvv70977+9Lhvvv73vv70w77+9Le+/ve+/ve+/vW9byqHvv73vv70zNSjvv73vv71L77+9Fzzvv70DSe+/ve+/ve+/ve+/vS8=",
                Role = UserRole.User,
                BirthDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-20))
            },
            new User
            {
                Id = Guid.NewGuid(),
                Email = "admin@gmail.com",
                Name = "JustAdmin",
                PasswordHash = "72FB6CEA3520ACB1BF2AA3D2110B31A1DC12E342C5D446CF2CA290E064C7B5A138D96F358466E5C4349E739635716D4544F23DDB8BAE0903F23C81B6FB887420",
                PasswordSalt = "77+9eQwb77+92bhUXxEAE23vv73vv705e++/ve+/ve+/ve+/vRvvv71V77+9cu+/vTbvv70777+9ay9W77+977+977+977+9Oe+/ve+/vVDvv73vv70o77+977+9FGHvv70vD++/vUDvv73vv73vv73dnXvvv71S77+9KA==",
                Role = UserRole.Admin,
                BirthDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-30))
            }
            );

        modelBuilder.Entity<Author>().HasData(
            new Author { Id = Guid.Parse("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), Name = "Admin" }
            );

        modelBuilder.Entity<Tag>().HasData(
            new Tag { Id = Guid.Parse("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825"), Name = "Hlavný chod" },
            new Tag { Id = new Guid("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c"), Name = "Dezerty" },
            new Tag { Id = new Guid("b1eac43b-9a2a-4e37-94d2-0a59a493c7d3"), Name = "Predjedlá" },
            new Tag { Id = new Guid("c1d698f0-1f87-4c30-9a31-c26e75d99c4f"), Name = "Šaláty" },
            new Tag { Id = new Guid("d1e13f16-9e32-4d3e-8302-28516d982aef"), Name = "Polievky" },
            new Tag { Id = new Guid("e13e2d0d-c51f-4fa9-97cb-4e6c018474cb"), Name = "Nápoje" },
            new Tag { Id = new Guid("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5"), Name = "Bez lepku" },
            new Tag { Id = new Guid("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d"), Name = "Bez laktózy" },
            new Tag { Id = new Guid("b1f4c4c4-9b64-4aef-9016-4d8a26c44843"), Name = "Sladké" }
            );

        modelBuilder.Entity<Ingredient>().HasData(
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), Name = "250 g predvareného cíceru" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), Name = "60 g sezamovej pasty" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), Name = "40 g nakrájaných olív Kalamata (ja som použila olivy Kalamata K-Favourites, ktoré nájdete v Kauflande)" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), Name = "25 ml šťavy z citróna" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), Name = "1 - 2 strúčiky cesnaku" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), Name = "2 PL studenej vody'" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), Name = "1 PL panenského olivového oleja" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), Name = "1/2 ČL rímskej rasce" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), Name = "soľ a čierne korenie" },

            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "300 g ryže arborio" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "1 cibuľa" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "200 ml bieleho suchého vína" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "300 ml paradajkového pretlaku/passaty" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "700 ml vývaru/vody" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "3 plátky masla" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "100 g parmezánu" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "panenský olivový olej" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "soľ a čierne korenie" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "sušená bazalka" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "sušené oregano" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "hrsť čerstvej bazalky" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "500 g cherry paradajok" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "4 strúčiky cesnaku" },

            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), Name = "500 g cherry paradajok" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), Name = "7 PL panenského olivového oleja" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), Name = "3 strúčiky cesnaku" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), Name = "1 bageta alebo iné pečivo (pre verziu bez lepku odporúčam použiť 1 balenie bezlepkových svetlých žemlí K-free, ktoré nájdete v Kauflande)" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), Name = "mozzarella" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), Name = "bazalkové pesto" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), Name = "hrsť lístkov bazalky" },
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), Name = "soľ a čierne korenie" }
            );

        modelBuilder.Entity<Step>().HasData(
            new Step { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), Name = "Predvarený cícer z konzervy prepláchneme, preložíme do hrnca, zalejeme vodou, jemne osolíme a privedieme do varu. Keď začne vrieť, znížime teplotu a prikrytý varíme približne 20 minút. Mäkký cícer prepláchneme studenou vodou a zbavíme šupiek. Presypeme ho do výkonného mixéra a pridáme k nemu ostatné ingrediencie na hummus. Vymixujeme dohladka a v prípade potreby pridáme trochu vody. Dochutíme soľou, čiernym korením a citrónovou šťavou." },
            new Step { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), Name = "Hummus pred podávaním ochutíme trochou mletej červenej papriky, pokvapkáme olivovým olejom a ozdobíme nakrájanou cibuľou, paradajkami, kolieskami uhorky a hrsťou zelených a čiernych olív. Servírujeme s plátkami citróna, slanými krekrami a výberom rôznych salám a syrov." },

            new Step { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "Paradajky nakrájame na štvrtiny a vložíme do misky. Pokvapkáme ich olivovým olejom (cca 5 PL panenského olivového oleja), pridáme prelisované strúčiky cesnaku a ochutíme soľou a čiernym korením. Premiešame lyžicou a necháme pár minút odležať. Následne celú zmes preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme 25 minút." },
            new Step { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "V menšom hrnci zohrejeme kurací alebo zeleninový vývar. Ak vývar nemáte, môžete použiť aj vodu - do menšieho hrnca dajte zohriať 700 ml vody a keď bude horúca, pridajte do nej lyžičku soli a dobre premiešajte. Vývar, prípadne vodu zohrievame preto, aby mali podobnú teplotu ako ryža. Vďaka tomu sa nezastaví proces varenia a budete mať rizoto presne také, aké má byť - krémové a neskutočne dobré." },
            new Step { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "Kým sa vývar/voda zohrieva, zohrejeme si v hlbokej panvici olivový olej, pridáme nadrobno nasekanú cibuľu a opečieme dosklovita. Prisypeme nepremytú ryžu arborio (môžete použiť aj carnaroli ryžu) a poriadne premiešame, aby sa ryža obalila vo vrstve oleja. Opekáme cca 4 minúty, pričom ryžu pravidelne premiešavame. Prilejeme víno a za občasného miešania privedieme do varu. Varíme cca 2 minúty, kým sa víno neodparí." },
            new Step { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "Prilejeme paradajkový pretlak/passatu a dobre premiešame. Znížime teplotu na stredný plameň, pridáme naberačku teplého vývaru alebo osolenej vody a pravidelne miešame, kým sa voda nevstrebe. Pokračujeme v postupnom pridávaní vody a zakaždým premiešavame, kým sa voda nevstrebe a ryža sa neuvarí al dente. Ryža je hotová vtedy, keď je obklopená krémovou tekutinou a po ochutnaní je jemne chrumkavá. Celý proces varenia trvá cca 25 minút." },
            new Step { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), Name = "Rizoto stiahneme zo sporáka, pridáme k nemu plátky masla a nastrúhaný parmezán a vareškou jemne premiešame. Podľa potreby dochutíme soľou, čiernym korením, trochou sušeného oregana a bazalky. Rizoto servírujeme v hlbokých tanieroch, navrch dáme pečené paradajky a ozdobíme lístkami čerstvej bazalky. Rizoto podávame hneď po uvarení, vtedy chutí najlepšie, s pohárom bieleho vína priam dokonale!" },

            new Step { Id = Guid.NewGuid(), ArticleId = Guid.Parse("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), Name = "Paradajky nakrájame na menšie kúsky a vložíme do misky. Zalejeme ich olivovým olejom, pridáme prelisované strúčiky cesnaku, ochutíme soľou a čiernym korením a dobre premiešame. Necháme pár minút postáť. Následne paradajky preložíme na plech vyložený papierom na pečenie a vložíme do rúry vyhriatej na 200 °C. Pečieme približne 30 minút, kým nezmäknú." },
            new Step { Id = Guid.NewGuid(), ArticleId = Guid.Parse("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), Name = "Bagetu alebo iné pečivo nakrájame na približne rovnaké kúsky. Ak použijete bezlepkové svetlé žemle K-free od Kauflandu, prekrojte ich na polovicu. Jednotlivé kúsky potrieme zvyšným olivovým olejom, ktorý zostal v miske a opečieme na grile, panvici alebo vložíme na 10 minút do rúry. Chrumkavé pečivo potrieme pestom, na to dáme plátok mozzarelly, grilované paradajky a lístky čerstvej bazalky." }
            );

        modelBuilder.Entity<ArticleTag>().HasData(
            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), TagId = Guid.Parse("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), TagId = Guid.Parse("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") },

            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), TagId = Guid.Parse("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"), TagId = Guid.Parse("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },

            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), TagId = Guid.Parse("b1eac43b-9a2a-4e37-94d2-0a59a493c7d3") },
            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("b83ebc52-d646-4ab1-94df-72582f0d8c5a"), TagId = Guid.Parse("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },

            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("4c26d85b-3146-4ed2-9f2c-3993e02ee888"), TagId = Guid.Parse("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },

            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), TagId = Guid.Parse("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"), TagId = Guid.Parse("c1d698f0-1f87-4c30-9a31-c26e75d99c4f") },

            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("0860d50a-927f-4d9c-8780-6f8054c20814"), TagId = Guid.Parse("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") },
            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("0860d50a-927f-4d9c-8780-6f8054c20814"), TagId = Guid.Parse("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },
            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("0860d50a-927f-4d9c-8780-6f8054c20814"), TagId = Guid.Parse("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },

            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), TagId = Guid.Parse("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("c2902ef3-8e41-4f88-b9a3-31981e4ac220"), TagId = Guid.Parse("a1b6b079-1c3e-4bb0-8b33-ae6f3dc53e3d") },

            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), TagId = Guid.Parse("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"), TagId = Guid.Parse("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") },

            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("90378085-c0de-4c91-a83c-d216d246b2b1"), TagId = Guid.Parse("a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c") },
            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("90378085-c0de-4c91-a83c-d216d246b2b1"), TagId = Guid.Parse("b1f4c4c4-9b64-4aef-9016-4d8a26c44843") },

            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("e62c4460-2829-4f20-b747-5ef468d02d17"), TagId = Guid.Parse("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") },
            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("e62c4460-2829-4f20-b747-5ef468d02d17"), TagId = Guid.Parse("f1db63a1-21f1-49c4-8f0c-208e1f4a8ff5") }
            );

        modelBuilder.Entity<Article>().HasData(
            new Article
            {
                Id = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"),
                AuthorId = Guid.Parse("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"),
                DateAdded = DateTime.Now,
                Title = "Olivový hummus",
                Description = "Ako tak pozerám do kalendára, Veľká noc je už za rohom! Tentokrát mi začiatok roka ubehol ultra rýchlo a človek sa ani nenazdá a bude tu máj a s ním aj ja - opäť o rok staršia. :D Ale nebudem predbiehať, teším sa na Veľkú noc a naše rodinné nedeľné raňajky. Veľkonočnú pasku, hrudku, vajcia natvrdo, údeniny, cviklu s chrenom a zemiakový šalát. Ale nie vždy musí byť Veľká noc len v tradičnom šate. :) Každý rok do nej pridávam aj nejakú tú novinku, naposledy to bola veľkonočná roláda s malinovým krémom, mrkvové mafiny, či avokádová nátierka s granátovým jablkom. A teraz sa môžu moji najbližší tešiť na výborný olivový hummus! Kombinácia cíceru, sezamovej pasty, cesnaku, citrónovej šťavy a olív Kalamata, je výborným krokom na vykročenie do inej svetovej kuchyne. :) Hummus servírovaný s chrumkavou cibuľkou, olivami, kolieskami uhorky a paradajok, pokvapkaný olivovým olejom - u nás doma sa zjedol rýchlosťou blesku a to nie sme milovníci cíceru. Všetky ingrediencie potrebné na tento recept, nájdete pod jednou strechou v Kauflande. Ak ešte nepoznáte ich značku K-Favourites, odporúčam vyskúšať - ingrediencie sú chuťovo výborné a cena príjemná.",
                Image = "789"
            },
            new Article
            {
                Id = Guid.Parse("11d5122f-8e94-485a-bf2c-8c432b254cc3"),
                AuthorId = Guid.Parse("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"),
                DateAdded = DateTime.Now.AddDays(-1),
                Title = "Famózne paradajkové rizoto",
                Description = "Tento víkend sme zvrtli novú variáciu rizota! Pôvodne som chcela spraviť tekvicové, ale z debničky na mňa \"žmurkali\" voňavé cherry paradajky, takže bolo spontánne rozhodnuté v prospech dnešného receptu na paradajkové rizoto. :) Rizoto je jeden z mojich najobľúbenejších receptov, jeho príprava nie je vôbec zložitá, stačí vám naň zopár ingrediencií a dokážete ho pripraviť na desiatky spôsobov v závislosti od sezóny. Na mojom blogu nájdete recept na hubové, ale i cviklové rizoto a čoskoro pribudnú aj ďalšie, keďže vás chcem naňho namotať :) Rizoto je úžasne krémové, prevoňané pečenými paradajkami s cesnakom a čerstvou bazalkou. Čochvíľa nám začne sezóna paradajok, tie skleníkové si však môžete dopriať už dnes a využiť ich rovno pri testovaní tohto receptu, prípadne odporúčam vyskúšať moju rýchlu paradajkovú polievku, paradajkový džem či mäsové guľky v paradajkovej omáčke. Verím, že si pochutíte!",
                Image = "012"
            },
            new Article
            {
                Id = Guid.Parse("b83ebc52-d646-4ab1-94df-72582f0d8c5a"),
                AuthorId = Guid.Parse("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"),
                DateAdded = DateTime.Now.AddDays(-3),
                Title = "Chrumkavá paradajková bruschetta",
                Description = "Blíži sa jar a s ňou aj všetky milé stretnutia s našimi blízkymi. U nás doma som zaviedla tradíciu nedeľných dlhých raňajok a vždy keď máme pred sebou voľný víkend, rada na tieto dlhé raňajky pozývam aj svojich najbližších. Jedlo a konverzácie pri spoločnom stole, ktoré ho sprevádzajú, sú pre mňa jedny z najmilších okamihov, preto rada vymýšľam vždy nové a nové kombinácie jedál, ktorými by som ich pohostila. :) A najradšej sa inšpirujem práve v talianskej kuchyni, keďže tá je známa svojou jednoduchosťou, kvalitnými ingredienciami a pritom zaručene chutným výsledkom. Mnohí z vás už určite poznajú recept na chrumkavú paradajkovú bruschettu, ktorú nájdete v mojej prvej kuchárskej knihe. Tento recept je jej malou obmenou, je však vhodný pre všetkých bezlepkáčov, nakoľko v ňom nájdete aj tip na bezgluténové pečivo od Kauflandu. V ich sortimente nájdete pod značkou K-free bezgluténové pečivo a cestoviny, ktoré rada využívam pri príprave bezlepkových receptov. Na chrumkavú bruschettu vám stačí zopár ingrediencií a výsledok je neuveriteľne chutný! Budem sa tešiť, ak recept najbližšie vyskúšate a dáte mi vedieť, ako vám chutilo.",
                Image = "345"
            },
            new Article
            {
                Id = Guid.Parse("4c26d85b-3146-4ed2-9f2c-3993e02ee888"),
                AuthorId = Guid.Parse("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"),
                DateAdded = DateTime.Now.AddDays(-7),
                Title = "Zeleninový tart z lístkového cesta",
                Description = "popis",
                Image = "567"
            },
            new Article
            {
                Id = Guid.Parse("2e30dc7c-0c1f-4438-9a3e-3f47792fc82d"),
                AuthorId = Guid.Parse("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"),
                DateAdded = DateTime.Now.AddDays(-10),
                Title = "Jednoduchý grécky šalát",
                Description = "popis",
                Image = "890"
            },
            new Article
            {
                Id = Guid.Parse("0860d50a-927f-4d9c-8780-6f8054c20814"),
                AuthorId = Guid.Parse("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"),
                DateAdded = DateTime.Now.AddDays(-12),
                Title = "Arašidové brownies s malinami",
                Description = "popis",
                Image = "123"
            },
            new Article
            {
                Id = Guid.Parse("c2902ef3-8e41-4f88-b9a3-31981e4ac220"),
                AuthorId = Guid.Parse("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"),
                DateAdded = DateTime.Now.AddDays(-14),
                Title = "Paella s morskými plodmi",
                Description = "popis",
                Image = "456"
            },
            new Article
            {
                Id = Guid.Parse("b5e5d3c7-6b28-456e-87ed-d53c10c3f36d"),
                AuthorId = Guid.Parse("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"),
                DateAdded = DateTime.Now.AddDays(-14),
                Title = "Tikka Masala",
                Description = "popis",
                Image = "787"
            },
            new Article
            {
                Id = Guid.Parse("90378085-c0de-4c91-a83c-d216d246b2b1"),
                AuthorId = Guid.Parse("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"),
                DateAdded = DateTime.Now.AddDays(-17),
                Title = "Čokoládový tart",
                Description = "popis",
                Image = "011"
            },
            new Article
            {
                Id = Guid.Parse("e62c4460-2829-4f20-b747-5ef468d02d17"),
                AuthorId = Guid.Parse("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"),
                DateAdded = DateTime.Now.AddDays(-25),
                Title = "Špagety Bolognese",
                Description = "popis",
                Image = "341"
            }
            );

        modelBuilder.Entity<ArticleComment>().HasData(
            new ArticleComment { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), Name = "jozka", Description = "mnam do pyska", DateAdded = DateTime.Now.AddDays(-2) }
            );

        base.OnModelCreating(modelBuilder);
    }
}
