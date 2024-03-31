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
                Title = "Съпруг и съпруга със сини и бели рози",
                Price = 100.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.6435-9/45418292_1900224123436935_5112515879866728448_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=5f2048&_nc_ohc=eFIio2QbBlEAX9Yzjue&_nc_ht=scontent-sof1-1.xx&oh=00_AfBoQ7qqdl47HZ7hWnAk-no9njwdW7bf1dMJizkc5xCsOQ&oe=6613AA58",
            };
            products.Add(product);

            //2
            product = new Product
            {
                Id = 2,
                Title = "Златни рози",
                Price = 120.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t31.18172-8/11950324_881502548642436_5301516909345454510_o.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=im4NrlMRDwoAX906LIT&_nc_ht=scontent-sof1-1.xx&oh=00_AfANMiRCdEFjBHMKqzdVQ8CfmwHERZjyswaGHkTpw3deDw&oe=66139F73"
            };
            products.Add(product);

            //3
            product = new Product
            {
                Id = 3,
                Title = "Съпруг и съпруга с червени рози и бели цветя",
                Price = 150.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent-sof1-2.xx.fbcdn.net/v/t1.6435-9/118890298_3193596277433040_3828589938106568560_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=5f2048&_nc_ohc=dMYD1Y2twPAAX-5TIdq&_nc_oc=AQmB6ydQvkgot9gup32CReBa78Uc9nJ0lxvLge5csyOGMtoviBAviNqd5ot6C3mvjZ4&_nc_ht=scontent-sof1-2.xx&oh=00_AfCKvMW1pK86G0-3Uvc3A4efBy5a7ZXvntK3EIguunlpsg&oe=6613AE2C"
            };
            products.Add(product);

            //4
            product = new Product
            {
                Id = 4,
                Title = "бели цветя",
                Price = 120.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t31.18172-8/11940464_881502551975769_3150965239804644226_o.jpg?_nc_cat=111&ccb=1-7&_nc_sid=5f2048&_nc_ohc=lIiz0CvrQOAAX8yrHv6&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDS01MUNTFuECPkpvob8zZZXmMJKbYgvCTwQahwOQCQIg&oe=6620333B"
            };
            products.Add(product);

            //5
            product = new Product
            {
                Id = 5,
                Title = "бели цветя",
                Price = 110.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.6435-9/81678509_2608157715976902_8711874778027261952_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=dn9ncHjKXt8AX8V4imn&_nc_oc=Adjiqz8TQNQuH0VsI2W2J8AQwDjcgr4XPGHPeTXPJ2qkeaZqY5bGxFIsMXkoAPWg4Jo&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAjqqJ0cgKuP1WozZm7dEPBE_51dVR12bcJ2UmxChzeYg&oe=66201CA0"
            };
            products.Add(product);

            //6
            product = new Product
            {
                Id = 6,
                Title = "Ауди (Христо 20)",
                Price = 60.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent-sof1-2.xx.fbcdn.net/v/t1.6435-9/137404609_3542798825846115_8434655239208905708_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=6mljKPhHnjIAX9LqFQP&_nc_ht=scontent-sof1-2.xx&oh=00_AfBpxiR_gQOHHryQJJG74wnITMjeC-uP-D7yn1swVD6-9w&oe=6630BA9C"
            };
            products.Add(product);

            //7
            product = new Product
            {
                Id = 7,
                Title = "Тик ток (Краси 9)",
                Price = 70.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent-sof1-2.xx.fbcdn.net/v/t1.6435-9/140654272_3565104620282202_1586972040598179455_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_ohc=Vj0NGhYBi5UAX8K_V_D&_nc_oc=AdhlsQ819_EuGRxSBpmepYYaVVPNKFAYniEjOeksAzIo73lVtWBOfl5WxyqG1XiN4Dg&_nc_ht=scontent-sof1-2.xx&oh=00_AfC9AO_padKrBp4jE-hg43Wd9pRoGwVrfaOVaUdMvX6yLw&oe=6630D046"
            };
            products.Add(product);

            //8
            product = new Product
            {
                Id = 8,
                Title = "Stranger Things (Емануела 12)",
                Price = 65.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent-sof1-2.xx.fbcdn.net/v/t1.6435-9/141452606_3575133479279316_4925539086264007770_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_ohc=2fq3kZ-mCbQAX8H16po&_nc_ht=scontent-sof1-2.xx&oh=00_AfCaQLmus1wBRboVdTFOEANkgvgwaROC7cLRXmUxpxSK8g&oe=6630B930"
            };
            products.Add(product);

            //9
            product = new Product
            {
                Id = 9,
                Title = "Шоколад, портокал и уиски (Юбилей 50)",
                Price = 80.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.6435-9/144275472_3592112990914698_7625468473701199444_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=0U-MJHaY2wcAX-Ulp2B&_nc_ht=scontent-sof1-1.xx&oh=00_AfB9kj9vo2afu6ByV-zqG_1Xhr86byOFMxbmJoRDyE-nIg&oe=6630C891"
            };
            products.Add(product);

            //10
            product = new Product
            {
                Id = 10,
                Title = "Бебе Бос (Николай 1/2)",
                Price = 50.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent-sof1-2.xx.fbcdn.net/v/t1.6435-9/144577998_3598291693630161_1749300887982667483_n.jpg?_nc_cat=111&ccb=1-7&_nc_sid=5f2048&_nc_ohc=-LGMg0ot0EkAX8TkT1w&_nc_ht=scontent-sof1-2.xx&oh=00_AfBxnZXhfdImfFwWDpZcFHSjWwyx0dVw9SoN_ujnIvrTWg&oe=6630C07C"
            };
            products.Add(product);

            //Biscuits

            //11
            product = new Product
            {
                Id = 11,
                Title = "Коледни елхи",
                Price = 10.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.6435-9/127996258_3428591943933471_6613145035034934063_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=rPtEwbVYSpsAX8PKZXU&_nc_ht=scontent.fsof10-1.fna&oh=00_AfD393zUJS7ZhFbPMSxqEvvGouqHlkLrInYKA97sq2Hdvg&oe=6624BF3F"
            };
            products.Add(product);

            //12
            product = new Product
            {
                Id = 12,
                Title = "Коледни фигури",
                Price = 12.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.18169-9/12301697_913490672110290_3131707004579174335_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_ohc=ORKDJKSWeZoAX_k70au&_nc_ht=scontent.fsof10-1.fna&oh=00_AfCU2TCno1TEOAxjtlDR3eVOY3eJcWK_lWlPD7c2VyMphg&oe=6624A21A"
            };
            products.Add(product);

            //13
            product = new Product
            {
                Id = 13,
                Title = "Еднорог",
                Price = 15.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/346885612_1175653887168525_5354008429856402980_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=hObhR06Be5kAX-tTgc6&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDokQeGR3jVPFokGOf4T-2ErzAqwXyrUMnNwn7NHqgQdw&oe=66025108"
            };
            products.Add(product);

            //14
            product = new Product
            {
                Id = 14,
                Title = "Баба Марта",
                Price = 13.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/429942016_1126158058806458_357351569670082917_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=52_xuh-8AD8AX8IJkDL&_nc_ht=scontent.fsof10-1.fna&oh=00_AfC2GOft8pteFCSZoG6CAy8Ot_y5swfu7kOtrW4GqwPhkw&oe=6602E783"
            };
            products.Add(product);

            //15
            product = new Product
            {
                Id = 15,
                Title = "Пролетна тема",
                Price = 11.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent-sof1-2.xx.fbcdn.net/v/t31.18172-8/13767216_1052053388254017_5059430311043810834_o.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=4rgx72Z99dsAX8T8yY9&_nc_ht=scontent-sof1-2.xx&oh=00_AfD7EXfGxSBOaVttui_hAOofFJXB-E7elqHjskgoEr5yHA&oe=6630E30F"
            };
            products.Add(product);

            return products;
        }
    }
}
