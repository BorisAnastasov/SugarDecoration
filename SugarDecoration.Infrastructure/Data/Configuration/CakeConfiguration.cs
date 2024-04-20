using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Infrastructure.Data.Configuration
{
	public class CakeConfiguration:IEntityTypeConfiguration<Cake>
	{
		public void Configure(EntityTypeBuilder<Cake> builder)
		{
            builder.HasData(SeedCakes());
		}

		private static List<Cake> SeedCakes() 
		{
            var cakes = new List<Cake>
            {
                new Cake
                {
                    Id = 1,
                    Layers = 1,
                    Portions = 35,
                    Form = "кръгла",
                    CategoryId = 2,
                    ProductId = 1 // References Product with Id = 1
                },
                new Cake
                {
                    Id = 2,
                    Layers = 1,
                    Portions = 30,
                    Form = "кръгла",
                    CategoryId = 2,
                    ProductId = 2 // References Product with Id = 2
                },
                new Cake
                {
                    Id = 3,
                    Layers = 1,
                    Portions = 30,
                    Form = "кръгла",
                    CategoryId = 2,
                    ProductId = 3 // References Product with Id = 3
                },
                new Cake
                {
                    Id = 4,
                    Layers = 1,
                    Portions = 20,
                    Form = "кръгла",
                    CategoryId = 5,
                    ProductId = 4 // References Product with Id = 4
                },
                new Cake
                {
                    Id = 5,
                    Layers = 1,
                    Portions = 30,
                    Form = "кръгла",
                    CategoryId = 5,
                    ProductId = 5 // References Product with Id = 5
                },
                new Cake
                {
                    Id = 6,
                    Layers = 2,
                    Portions = 20,
                    Form = "кръгла",
                    CategoryId = 2,
                    ProductId = 6 // References Product with Id = 6
                },
                new Cake
                {
                    Id = 7,
                    Layers = 1,
                    Portions = 25,
                    Form = "кръгла",
                    CategoryId = 2,
                    ProductId = 7 // References Product with Id = 7
                },
                new Cake
                {
                    Id = 8,
                    Layers = 1,
                    Portions = 30,
                    Form = "кръгла",
                    CategoryId = 2,
                    ProductId = 8 // References Product with Id = 8
                },
                new Cake
                {
                    Id = 9,
                    Layers = 1,
                    Portions = 35,
                    Form = "кръгла",
                    CategoryId = 2,
                    ProductId = 9 // References Product with Id = 9
                },
                new Cake
                {
                    Id = 10,
                    Layers = 1,
                    Portions = 10,
                    Form = "кръгла",
                    CategoryId = 2,
                    ProductId = 10 // References Product with Id = 10
                },
                new Cake
                {
                    Id = 11,
                    Layers = 1,
                    Portions = 35,
                    Form = "кръгла",
                    CategoryId = 2,
                    ProductId = 11 // References Product with Id = 11
                },
                new Cake
                {
                    Id = 12,
                    Layers = 1,
                    Portions = 30,
                    Form = "кръгла",
                    CategoryId = 2,
                    ProductId = 12 // References Product with Id = 12
                },
                new Cake
                {
                    Id = 13,
                    Layers = 1,
                    Portions = 30,
                    Form = "кръгла",
                    CategoryId = 2,
                    ProductId = 13 // References Product with Id = 13
                },
                new Cake
                {
                    Id = 14,
                    Layers = 1,
                    Portions = 20,
                    Form = "правоъгълна",
                    CategoryId = 2,
                    ProductId = 14 // References Product with Id = 14
                },
                new Cake
                {
                    Id = 15,
                    Layers = 2,
                    Portions = 30,
                    Form = "кръгла",
                    CategoryId = 2,
                    ProductId = 15 // References Product with Id = 15
                },
                new Cake
                {
                    Id = 16,
                    Layers = 1,
                    Portions = 20,
                    Form = "правоъгълна",
                    CategoryId = 2,
                    ProductId = 16 // References Product with Id = 16
                },
                new Cake
                {
                    Id = 17,
                    Layers = 1,
                    Portions = 35,
                    Form = "правоъгълна",
                    CategoryId = 2,
                    ProductId = 17 // References Product with Id = 17
                },
                new Cake
                {
                    Id = 18,
                    Layers = 2,
                    Portions = 30,
                    Form = "кръгла",
                    CategoryId = 2,
                    ProductId = 18 // References Product with Id = 18
                },
                new Cake
                {
                    Id = 19,
                    Layers = 1,
                    Portions = 35,
                    Form = "кръгла",
                    CategoryId = 2,
                    ProductId = 19 // References Product with Id = 19
                },
                new Cake
                {
                    Id = 20,
                    Layers = 2,
                    Portions = 25,
                    Form = "кръгла",
                    CategoryId = 1,
                    ProductId = 20 // References Product with Id = 20
                }
            };

            return cakes;
        }

    }

}
