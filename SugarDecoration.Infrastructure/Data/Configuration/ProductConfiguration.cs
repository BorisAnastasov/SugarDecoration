using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Infrastructure.Data.Configuration
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(SeedProducts());
        }

        private static List<Product> SeedProducts()
        {
            var products = new List<Product>();

            //Cakes

            //1
            var product = new Product
            {
                Id = 1,
                Title = "Пирати(Адриана 7)",
                Price = 100.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/Pirates(Adriana 7).jpg"
            };
            products.Add(product);

            //2
            product = new Product
            {
                Id = 2,
                Title = "Розово сладко(Иванина 8)",
                Price = 120.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/PinkSweet(Ivanina 8).jpg"
            };
            products.Add(product);

            //3
            product = new Product
            {
                Id = 3,
                Title = "Симба(Кирил 1)",
                Price = 150.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/Simba(Kiril 1).jpg"
            };
            products.Add(product);

            //4
            product = new Product
            {
                Id = 4,
                Title = "Why, god, why?",
                Price = 120.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/Turning30.jpg"
            };
            products.Add(product);

            //5
            product = new Product
            {
                Id = 5,
                Title = "Погачата на Георги",
                Price = 110.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/BlueCakeWithFeathers.jpg"
            };
            products.Add(product);

            //6
            product = new Product
            {
                Id = 6,
                Title = "Препятствия по пътя",
                Price = 60.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/ToughtWay.jpg"
            };
            products.Add(product);

            //7
            product = new Product
            {
                Id = 7,
                Title = "Карате(Веско 10)",
                Price = 70.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/Karate(Vesko10).jpg"
            };
            products.Add(product);

            //8
            product = new Product
            {
                Id = 8,
                Title = "Барби(Мариела 7)",
                Price = 65.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/Barbie(Mariela 10).jpg"
            };
            products.Add(product);

            //9
            product = new Product
            {
                Id = 9,
                Title = "Мечо Пух(Никола 1)",
                Price = 80.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/AnimalPicnic(Nikola 1).jpg"
            };
            products.Add(product);

            //10
            product = new Product
            {
                Id = 10,
                Title = "Сини Пеперуди(Никол 7)",
                Price = 50.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/BlueButterflies(Nikol 7).jpg"
            };
            products.Add(product);

            //11
            product = new Product
            {
                Id = 11,
                Title = "Мини Маус(Теодора 2)",
                Price = 80.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/MiniMaus(Teodora 2).jpg"
            };
            products.Add(product);

            //12
            product = new Product
            {
                Id = 12,
                Title = "Кристиано Роналдо(Методи 8)",
                Price = 100.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/CristianRonaldo(Metodi 8).jpg"
            };
            products.Add(product);

            //13
            product = new Product
            {
                Id = 13,
                Title = "Розова принцеса(Мариета 10)",
                Price = 150.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/PinkPrincess(Marieta 10).jpg"
            };
            products.Add(product);

            //14
            product = new Product
            {
                Id = 14,
                Title = "Състезание с коли(Кристиян 3)",
                Price = 120.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/RaceWithCars(Kristian 3).jpg"
            };
            products.Add(product);

            //15
            product = new Product
            {
                Id = 15,
                Title = "Хлапетата/Пирин(Денис 5)",
                Price = 110.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/Hlapetata(Denis 5).jpg"
            };
            products.Add(product);

            //16
            product = new Product
            {
                Id = 16,
                Title = "Розови цветя(Бориса 4)",
                Price = 60.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/PinkFlowers(Borisa 4).jpg"
            };
            products.Add(product);

            //17
            product = new Product
            {
                Id = 17,
                Title = "Розова гимнастика(Антония 13)",
                Price = 70.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/PinkGymnastic(Antonia 13).jpg"
            };
            products.Add(product);

            //18
            product = new Product
            {
                Id = 18,
                Title = "Аржентина/Меси(Илиян)",
                Price = 65.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/Messi(Iliqn).jpg"
            };
            products.Add(product);

            //19
            product = new Product
            {
                Id = 19,
                Title = "Лего(Адриан 3)",
                Price = 80.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/Lego(Adrian 3).jpg"
            };
            products.Add(product);

            //20
            product = new Product
            {
                Id = 20,
                Title = "Златни рози",
                Price = 50.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/cake/GoldenRoses.jpg"
            };
            products.Add(product);


            //Biscuits

            //21
            product = new Product
            {
                Id = 21,
                Title = "Коледни елхи",
                Price = 10.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/ChristmasTrees.jpg"
            };
            products.Add(product);

            //22
            product = new Product
            {
                Id = 22,
                Title = "Коледни фигури",
                Price = 12.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/ChristmasFigures.jpg"
            };
            products.Add(product);

            //23
            product = new Product
            {
                Id = 23,
                Title = "Зимни сладки",
                Price = 15.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/WinterFigures.jpg"
            };
            products.Add(product);

            //24
            product = new Product
            {
                Id = 24,
                Title = "Декоративни еднорози",
                Price = 13.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/DecorativePonies.jpg"
            };
            products.Add(product);

            //25
            product = new Product
            {
                Id = 25,
                Title = "Пролетна тема",
                Price = 11.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/SpringThema.jpg"
            };
            products.Add(product);

            //26
            product = new Product
            {
                Id = 26,
                Title = "Декоративни котета",
                Price = 10.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/DecorativeKittens.jpg"
            };
            products.Add(product);

            //27
            product = new Product
            {
                Id = 27,
                Title = "Коледни сладки",
                Price = 12.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/ChristmasBiscuits.jpg"
            };
            products.Add(product);

            //28
            product = new Product
            {
                Id = 28,
                Title = "Пролетна любов",
                Price = 15.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/SpringLove.jpg"
            };
            products.Add(product);

            //29
            product = new Product
            {
                Id = 29,
                Title = "Бонбони мечки на клечка",
                Price = 13.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/BearsBonbons.jpg"
            };
            products.Add(product);

            //30
            product = new Product
            {
                Id = 30,
                Title = "Мини маус",
                Price = 11.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/MiniMaus.jpg"
            };
            products.Add(product);

            //31
            product = new Product
            {
                Id = 31,
                Title = "Бебешки сладки",
                Price = 10.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/BabysBiscuits.jpg"
            };
            products.Add(product);

            //32
            product = new Product
            {
                Id = 32,
                Title = "Мики маус",
                Price = 12.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/MikeyMaus.jpg"
            };
            products.Add(product);

            //33
            product = new Product
            {
                Id = 33,
                Title = "Vet time",
                Price = 15.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/VetTime.jpg"
            };
            products.Add(product);

            //34
            product = new Product
            {
                Id = 34,
                Title = "Форма мини маус",
                Price = 13.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/FormMiniMaus.jpg"
            };
            products.Add(product);

            //35
            product = new Product
            {
                Id = 35,
                Title = "Кехчета еднорог",
                Price = 11.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/MuffinsPony.jpg"
            };
            products.Add(product);

            //36
            product = new Product
            {
                Id = 36,
                Title = "Кехчета мики маус",
                Price = 10.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/MuffinsMikeyMaus.jpg"
            };
            products.Add(product);

            //37
            product = new Product
            {
                Id = 37,
                Title = "Кехчета с мечета",
                Price = 12.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/MuffinsWithBears.jpg"
            };
            products.Add(product);

            //38
            product = new Product
            {
                Id = 38,
                Title = "Бисквити във формата на единица",
                Price = 15.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/FormOfOne.jpg"
            };
            products.Add(product);

            //39
            product = new Product
            {
                Id = 39,
                Title = "Меченца",
                Price = 13.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/Bears.jpg"
            };
            products.Add(product);

            //40
            product = new Product
            {
                Id = 40,
                Title = "Четирилистна детелина",
                Price = 11.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "~/images/seeding/biscuit/VierLeaf.jpg"
            };
            products.Add(product);

            return products;
        }
    }
}
