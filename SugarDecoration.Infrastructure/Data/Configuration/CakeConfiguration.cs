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
            var cakes = new List<Cake>();

            cakes.Add(new Cake
            {
                Id = 1,
                Layers = 3,
                Portions = 35,
                Form = "кръгла",
                CategoryId = 1,
                ProductId = 1 // References Product with Id = 1
            });

            cakes.Add(new Cake
            {
                Id = 2,
                Layers = 2,
                Portions = 30,
                Form = "кръгла",
                CategoryId = 1,
                ProductId = 2 // References Product with Id = 2
            });

            cakes.Add(new Cake
            {
                Id = 3,
                Layers = 2,
                Portions = 30,
                Form = "кръгла",
                CategoryId = 1,
                ProductId = 3 // References Product with Id = 3
            });

            cakes.Add(new Cake
            {
                Id = 4,
                Layers = 1,
                Portions = 20,
                Form = "кръгла",
                CategoryId = 2,
                ProductId = 4 // References Product with Id = 4
            });

            cakes.Add(new Cake
            {
                Id = 5,
                Layers = 2,
                Portions = 30,
                Form = "кръгла",
                CategoryId = 1,
                ProductId = 5 // References Product with Id = 5
            });

            cakes.Add(new Cake
            {
                Id = 6,
                Layers = 1,
                Portions = 20,
                Form = "кръгла",
                CategoryId = 2,
                ProductId = 6 // References Product with Id = 6
            });

            cakes.Add(new Cake
            {
                Id = 7,
                Layers = 2,
                Portions = 25,
                Form = "кръгла",
                CategoryId = 2,
                ProductId = 7 // References Product with Id = 7
            });

            cakes.Add(new Cake
            {
                Id = 8,
                Layers = 1,
                Portions = 30,
                Form = "кръгла",
                CategoryId = 2,
                ProductId = 8 // References Product with Id = 8
            });

            cakes.Add(new Cake
            {
                Id = 9,
                Layers = 1,
                Portions = 35,
                Form = "кръгла",
                CategoryId = 3,
                ProductId = 9 // References Product with Id = 9
            });

            cakes.Add(new Cake
            {
                Id = 10,
                Layers = 1,
                Portions = 10,
                Form = "полукръгла",
                CategoryId = 2,
                ProductId = 10 // References Product with Id = 10
            });

            // Add more cakes here similarly...

            cakes.Add(new Cake
            {
                Id = 11,
                Layers = 3,
                Portions = 35,
                Form = "кръгла",
                CategoryId = 1,
                ProductId = 11 // References Product with Id = 11
            });

            cakes.Add(new Cake
            {
                Id = 12,
                Layers = 2,
                Portions = 30,
                Form = "кръгла",
                CategoryId = 1,
                ProductId = 12 // References Product with Id = 12
            });

            cakes.Add(new Cake
            {
                Id = 13,
                Layers = 2,
                Portions = 30,
                Form = "кръгла",
                CategoryId = 1,
                ProductId = 13 // References Product with Id = 13
            });

            cakes.Add(new Cake
            {
                Id = 14,
                Layers = 1,
                Portions = 20,
                Form = "кръгла",
                CategoryId = 2,
                ProductId = 14 // References Product with Id = 14
            });

            cakes.Add(new Cake
            {
                Id = 15,
                Layers = 2,
                Portions = 30,
                Form = "кръгла",
                CategoryId = 1,
                ProductId = 15 // References Product with Id = 15
            });

            cakes.Add(new Cake
            {
                Id = 16,
                Layers = 1,
                Portions = 20,
                Form = "кръгла",
                CategoryId = 2,
                ProductId = 16 // References Product with Id = 16
            });

            cakes.Add(new Cake
            {
                Id = 17,
                Layers = 2,
                Portions = 25,
                Form = "кръгла",
                CategoryId = 2,
                ProductId = 17 // References Product with Id = 17
            });

            cakes.Add(new Cake
            {
                Id = 18,
                Layers = 1,
                Portions = 30,
                Form = "кръгла",
                CategoryId = 2,
                ProductId = 18 // References Product with Id = 18
            });

            cakes.Add(new Cake
            {
                Id = 19,
                Layers = 1,
                Portions = 35,
                Form = "кръгла",
                CategoryId = 5,
                ProductId = 19 // References Product with Id = 19
            });

            cakes.Add(new Cake
            {
                Id = 20,
                Layers = 1,
                Portions = 10,
                Form = "полукръгла",
                CategoryId = 2,
                ProductId = 20 // References Product with Id = 20
            });

            return cakes;
        }

    }

}
