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
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/418972033_1093443198744611_18295542256863659_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=5f2048&_nc_ohc=oyt_fYQxpqQAb5wlkX3&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAq--jLQ5hLqOijtXT5wzON89KBi5WPe4zaYN49JBTEXA&oe=66234802",
            };
            products.Add(product);

            //2
            product = new Product
            {
                Id = 2,
                Title = "Розово сладко(Иванина 8)",
                Price = 120.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/419883159_1096690305086567_9154400905867001135_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=gqYPb7qhPtsAb4iSrqn&_nc_ht=scontent.fsof10-1.fna&oh=00_AfCk3kEV0NX_qoP0VkVRiebWy7Im1H9MGdvlERnwPmVPaw&oe=66233F51"
            };
            products.Add(product);

            //3
            product = new Product
            {
                Id = 3,
                Title = "Симба(Кирил 1)",
                Price = 150.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/419814170_1096690445086553_5920770385650976907_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=yL0QHtExJ9MAb6_q7wH&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDrTCMRxqDTpIfk4tXAoMzxO8lgSfCgpztL3btPJas8jQ&oe=662362CF"
            };
            products.Add(product);

            //4
            product = new Product
            {
                Id = 4,
                Title = "Why, god, why?",
                Price = 120.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/419895981_1096690478419883_5265202540193795239_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=s-BHu3ex-q8Ab6uHFDB&_nc_ht=scontent.fsof10-1.fna&oh=00_AfA-XudfSZAwJ5b_WxbFMTgwWf4RyaHMgN0OE0zCtWs_EQ&oe=66235113"
            };
            products.Add(product);

            //5
            product = new Product
            {
                Id = 5,
                Title = "Погачата на Георги",
                Price = 110.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/420271104_1099055744850023_5401028707936950121_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=ilC9jJPAWI4Ab6rAiX5&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBRVrXVCUcnYE0x6zvThlbpjyw2w0ehTrkhMGOhq4KTPA&oe=66234BBF"
            };
            products.Add(product);

            //6
            product = new Product
            {
                Id = 6,
                Title = "Препятствия по пътя",
                Price = 60.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/421273451_1100972814658316_2601163674327323390_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=IP9MBVAOblAAb6EO1G1&_nc_ht=scontent.fsof10-1.fna&oh=00_AfCmPwO7mWsQCMbO7Odnel69USm1kH9spgWawU6Sldn5gQ&oe=662353D7"
            };
            products.Add(product);

            //7
            product = new Product
            {
                Id = 7,
                Title = "Карате(Веско 10)",
                Price = 70.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/421003139_1100973004658297_8756545305937455944_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=5f2048&_nc_ohc=BcWMOIWll9cAb5Ih1TL&_nc_ht=scontent.fsof10-1.fna&oh=00_AfC250frGZak90Hv-gTE7N3SNU3SQ1ZXrXjskefrhxSn9A&oe=66234690"
            };
            products.Add(product);

            //8
            product = new Product
            {
                Id = 8,
                Title = "Барби(Мариела 7)",
                Price = 65.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/421307138_1100973057991625_4347484741087024842_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=5f2048&_nc_ohc=S0oVgoVPVMIAb4Hucnw&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDSI_2CwdWu5xmcwmmZ7bu0N7y8_i3keoPXegTZ-1hCoA&oe=66236B33"
            };
            products.Add(product);

            //9
            product = new Product
            {
                Id = 9,
                Title = "Мечо Пух(Никола 1)",
                Price = 80.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/421305166_1100973174658280_3232378763777122331_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=R4NYSjlEX9AAb6WnTxC&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDcbMLGgbShkm0ol086Q2EkcLN23V2fJ9YSGrJQpuqPXA&oe=662348EF"
            };
            products.Add(product);

            //10
            product = new Product
            {
                Id = 10,
                Title = "Сини Пеперуди(Никол 7)",
                Price = 50.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422453926_1103927064362891_1200521909121655771_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=5f2048&_nc_ohc=ZIy3sO497vcAb68LxRu&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBukpcRHGQ5RYzy24loiAyuH18GZznNHA_jIi5e3zyk2w&oe=66235C34"
            };
            products.Add(product);

            //11
            product = new Product
            {
                Id = 11,
                Title = "Мини Маус(Теодора 2)",
                Price = 80.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422917578_1103927104362887_2140454483848022782_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=5f2048&_nc_ohc=eOvOV-fhrVEAb634ibP&_nc_ht=scontent.fsof10-1.fna&oh=00_AfB9cekCjuO5MZZ33zx8q_JghkOZmrPogD_x7wGp1YIbow&oe=6623411C",
            };
            products.Add(product);

            //12
            product = new Product
            {
                Id = 12,
                Title = "Кристиано Роналдо(Методи 8)",
                Price = 100.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422283046_1103927131029551_320020852122884371_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=PhEHWe1_m-QAb75WnYN&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDKi9xqOjHabPgjJoGBMzx3cc5DqzIFHsgOtr8-JE0SrA&oe=66233FD9"
            };
            products.Add(product);

            //13
            product = new Product
            {
                Id = 13,
                Title = "Розова принцеса(Мариета 10)",
                Price = 150.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/421992174_1103927164362881_2666073469233497469_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=5f2048&_nc_ohc=GX25z23w5rcAb4KrcKH&_nc_ht=scontent.fsof10-1.fna&oh=00_AfByo6aJlE_Ba8y1okKX6-W5kJO7NB_fRYG4vx6byH96vA&oe=66234021"
            };
            products.Add(product);

            //14
            product = new Product
            {
                Id = 14,
                Title = "Състезание с коли(Кристиян 3)",
                Price = 120.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422395532_1103927251029539_8137194788006343813_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=5f2048&_nc_ohc=LO9gVorGTSwAb47oA1-&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAYzQlhoRH2fxmdGB5mWLk4HjdxQS5Q7r-4NoVf0nJZFg&oe=6623556B"
            };
            products.Add(product);

            //15
            product = new Product
            {
                Id = 15,
                Title = "Хлапетата/Пирин(Денис 5)",
                Price = 110.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422434325_1103927354362862_6819850698041677940_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=5f2048&_nc_ohc=ukNWu9a7loMAb7ZcZw-&_nc_ht=scontent.fsof10-1.fna&oh=00_AfD2dTbQWL1XwH5fNRhDIB6lN3yPrHWUUkyVO05H3ysOqg&oe=662374B7"
            };
            products.Add(product);

            //16
            product = new Product
            {
                Id = 16,
                Title = "Розови цветя(Бориса 4)",
                Price = 60.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422903500_1103933321028932_6325247546336233728_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_ohc=EZVht7CFsBAAb74jNz7&_nc_ht=scontent.fsof10-1.fna&oh=00_AfC4YIei0A5QDbwhJfNazjXgjmfw3HAHYw355iCKfaQh4w&oe=662355C3"
            };
            products.Add(product);

            //17
            product = new Product
            {
                Id = 17,
                Title = "Розова гимнастика(Антония 13)",
                Price = 70.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422123188_1103933404362257_1707931504307280465_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=woNTec0Hgy0Ab4fHTmr&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAf_kINoy3ZLN9sFSkoUD9plIOeZyoVwp-9p35ADQvKQA&oe=66234D99"
            };
            products.Add(product);

            //18
            product = new Product
            {
                Id = 18,
                Title = "Аржентина/Меси(Илиян)",
                Price = 65.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422337680_1103933437695587_2768842852153729910_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=n6kzvpKHKYMAb6zpLwr&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBHtcU1DObFEYGgH-rsdv3w7fH7n-zcWRFnT5T34Yk5sg&oe=66234479"
            };
            products.Add(product);

            //19
            product = new Product
            {
                Id = 19,
                Title = "Лего(Адриан 3)",
                Price = 80.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422945261_1104870920935172_7448345022192442547_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=jJ0e0YC9QSsAb65AEiE&_nc_ht=scontent.fsof10-1.fna&oh=00_AfADr8k4touilXWuDeGR0c_vO1UdvnZPEZQuxqZ7xoJg7g&oe=662356BB"
            };
            products.Add(product);

            //20
            product = new Product
            {
                Id = 20,
                Title = "Джунгла/животни(Марти 2)",
                Price = 50.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422954610_1104870957601835_5166553921804153623_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=03q5H16CEqIAb6Bx76T&_nc_ht=scontent.fsof10-1.fna&oh=00_AfCKtxi9DJ37h8NyQMt929wOjM4PNwLpcRU7Y04YYRxywQ&oe=6623553B"
            };
            products.Add(product);


            //Biscuits

            //11
            product = new Product
            {
                Id = 21,
                Title = "Коледни елхи",
                Price = 10.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.6435-9/127996258_3428591943933471_6613145035034934063_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=rPtEwbVYSpsAX8PKZXU&_nc_ht=scontent.fsof10-1.fna&oh=00_AfD393zUJS7ZhFbPMSxqEvvGouqHlkLrInYKA97sq2Hdvg&oe=6624BF3F"
            };
            products.Add(product);

            //12
            product = new Product
            {
                Id = 22,
                Title = "Коледни фигури",
                Price = 12.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.18169-9/12301697_913490672110290_3131707004579174335_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_ohc=ORKDJKSWeZoAX_k70au&_nc_ht=scontent.fsof10-1.fna&oh=00_AfCU2TCno1TEOAxjtlDR3eVOY3eJcWK_lWlPD7c2VyMphg&oe=6624A21A"
            };
            products.Add(product);

            //13
            product = new Product
            {
                Id = 23,
                Title = "Зимни сладки",
                Price = 15.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/414659694_1083679999720931_4686156170598756137_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=5f2048&_nc_ohc=as37wfBwQK8Ab5Mug42&_nc_ht=scontent.fsof10-1.fna&oh=00_AfCGK-reC7PqEOLEWwwzko1sROVZ_8CWj8q-W3YZtNi-0A&oe=66240241"
            };
            products.Add(product);

            //14
            product = new Product
            {
                Id = 24,
                Title = "Декоративни еднорози",
                Price = 13.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/346885612_1175653887168525_5354008429856402980_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=J8pQ0qQs7kAAb4s2bc_&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDJ68lAKqg0E20ah8YVoP4tpvzw3Zxktb1IyES2U4Vwmw&oe=6623EF48"
            };
            products.Add(product);

            //15
            product = new Product
            {
                Id = 25,
                Title = "Пролетна тема",
                Price = 11.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent-sof1-2.xx.fbcdn.net/v/t31.18172-8/13767216_1052053388254017_5059430311043810834_o.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=4rgx72Z99dsAX8T8yY9&_nc_ht=scontent-sof1-2.xx&oh=00_AfD7EXfGxSBOaVttui_hAOofFJXB-E7elqHjskgoEr5yHA&oe=6630E30F"
            };
            products.Add(product);


            //11
            product = new Product
            {
                Id = 26,
                Title = "Декоративни котета",
                Price = 10.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/347598820_1462268427940551_3378899760043768216_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=ssELXekml1UAb74Lw3p&_nc_ht=scontent.fsof10-1.fna&oh=00_AfC0Ewx8gIUxsz0I7sadvlZYWCtWMOpEAsoaBtjIrAyw8A&oe=66240EBF"
            };
            products.Add(product);

            //12
            product = new Product
            {
                Id = 27,
                Title = "Коледни сладки",
                Price = 12.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/408289112_1069083081180623_6103859634370956242_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=mv2MUmF-QO8Ab7EfHv7&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAMXi1gUAJXuSVoXopY7PIiihmWD1lAth0tzDis9JXyuw&oe=66240F1D"
            };
            products.Add(product);

            //13
            product = new Product
            {
                Id = 28,
                Title = "Бонбони пеперуди на клечка",
                Price = 15.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/338166827_548900843899794_5385569313968380087_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=PSCgPeCXrgcAb6j9QsW&_nc_ht=scontent.fsof10-1.fna&oh=00_AfATy6VoG94Cjh2NstybjuKj7sEvlXYDGyHO0ZFwaTaQEQ&oe=66242223"
            };
            products.Add(product);

            //14
            product = new Product
            {
                Id = 29,
                Title = "Бонбони мечки на клечка",
                Price = 13.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/338166827_548900843899794_5385569313968380087_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=PSCgPeCXrgcAb6j9QsW&_nc_ht=scontent.fsof10-1.fna&oh=00_AfATy6VoG94Cjh2NstybjuKj7sEvlXYDGyHO0ZFwaTaQEQ&oe=66242223"
            };
            products.Add(product);

            //15
            product = new Product
            {
                Id = 30,
                Title = "Мини маус",
                Price = 11.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/340453821_634241451866643_5453280737476644845_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=87i6kF4Ax98Ab4awAYD&_nc_ht=scontent.fsof10-1.fna&oh=00_AfA3MikW3e7agHZSVd4jqjP-v4rTxNW0EUzjduG4CbmMDg&oe=66241D17"
            };
            products.Add(product);

            //11
            product = new Product
            {
                Id = 31,
                Title = "Бебешки сладки",
                Price = 10.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/370618359_1006912454064353_122421549472800615_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=y_c-d4EXHPkAb6e8OeC&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDJ1pkGVuhbluUh4dSsyzTegN9yH9N5MqzKQjcHC_oGJg&oe=662406BD"
            };
            products.Add(product);

            //12
            product = new Product
            {
                Id = 32,
                Title = "Мини маус",
                Price = 12.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/395350593_1045984213490510_5049859778982539766_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=-uaRfcy596cAb6O7E27&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAewl4G0thADHLGKiM4rMrSJPJewbKZQ7KAETgMxt5Urw&oe=66240481"
            };
            products.Add(product);

            //13
            product = new Product
            {
                Id = 33,
                Title = "Vet time",
                Price = 15.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/412367668_1078476133574651_2014438863321533166_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=mK10dhm9R6IAb7eU1ZD&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDSYSsBkrpfhDSTcIhp5UvVFMv9HMJ5zp6r-Fsz5N0K5w&oe=6624123D"
            };
            products.Add(product);

            //14
            product = new Product
            {
                Id = 34,
                Title = "Форма мини маус",
                Price = 13.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/412421912_1079066630182268_8849429455852772027_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=5f2048&_nc_ohc=b7_xw_AY00YAb4G4USq&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBxwx2uLEDjZtvETiTF_PJtjEfpJAwarVUuIUHib9qNZg&oe=6624254C"
            };
            products.Add(product);

            //15
            product = new Product
            {
                Id = 35,
                Title = "Кехчета еднорог",
                Price = 11.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/273151658_4726256077500378_6856753579275926019_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=yfjlzEaBXswAb7NuBhi&_nc_ht=scontent.fsof10-1.fna&oh=00_AfASCVabXp4kXs0HV1oeLfu7xOkOQz8CC5fYXuFsgC8o0A&oe=66240545"
            };
            products.Add(product);

            //11
            product = new Product
            {
                Id = 36,
                Title = "Кехчета мики маус",
                Price = 10.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/273049030_4737053996420586_5343548874095564690_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=iG5P5AF1HXkAb6Vt5n3&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBunWEQPHjrel3Lq1DrsmVGbCPp768asWGQdmA-spF19A&oe=6623FAF4"
            };
            products.Add(product);

            //12
            product = new Product
            {
                Id = 37,
                Title = "Кехчета с мечета",
                Price = 12.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/275972733_4852334931559158_4876683130673051345_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=5f2048&_nc_ohc=kRjcinr4qo0Ab4CZZ8U&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAaSiY_pT9eZ7bGGXmwHemkUSg-OeZHxn_h9y-exNDTJg&oe=66240D76"
            };
            products.Add(product);

            //13
            product = new Product
            {
                Id = 38,
                Title = "Бисквити във формата на единица",
                Price = 15.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/275888286_4854907834635201_5576219607842184040_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=5f2048&_nc_ohc=kIBlo0Frm8cAb5nTa0I&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBVIdHdb4B3_nh2m6JVLQDlDsoPF093SXrHdgBGTNkYSg&oe=6623F44E"
            };
            products.Add(product);

            //14
            product = new Product
            {
                Id = 39,
                Title = "Меченца",
                Price = 13.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/278182286_4910435082415809_8231988911027352607_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=zj0DGN2EyjMAb6g6E5n&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBvUrNy0HtVFYqLWzY6C-t5_H2refxaZvBFfTEbZY0ZFw&oe=6623F7F8"
            };
            products.Add(product);

            //15
            product = new Product
            {
                Id = 40,
                Title = "Четирилистна детелина",
                Price = 11.00m,
                CreatedOn = DateTime.Now,
                ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.6435-9/82200699_2623632034429470_7680587017826074624_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=6G_BPMiyr-MAb7F2cJX&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAmCjYKJf4atPcvS1AKyw1Yiq4pfMxJpAgzXizkdoYPHA&oe=66459706"
            };
            products.Add(product);

            return products;
        }
    }
}
