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

            //1
			var cake = new Cake
			{
                Id = 1,
                Layers = 3,
                Portions = 35,
                Form = "кръгла",
                CategoryId = 1,
                ProductId = 1
            };
			cakes.Add( cake );

            //2
            cake = new Cake
            {
                Id = 2,
                Layers = 2,
                Portions = 30,
                Form = "кръгла",
                CategoryId = 1,
                ProductId = 2
            };
            cakes.Add(cake);

            //3
            cake = new Cake
            {
                Id = 3,
                Layers = 2,
                Portions = 30,
                Form = "кръгла",
                CategoryId = 1,
                ProductId = 3
            };
            cakes.Add(cake);

            //4
            cake = new Cake
            {
                Id = 4,
                Layers = 1,
                Portions = 20,
                Form = "кръгла",
                CategoryId = 2,
                ProductId = 4
            };
            cakes.Add(cake);

            //5
            cake = new Cake
            {
                Id = 5,
                Layers = 2,
                Portions = 30,
                Form = "кръгла",
                CategoryId = 1,
                ProductId = 5,
            };
            cakes.Add(cake);

            //6
            cake = new Cake
            {
                Id = 6,
                Layers = 1,
                Form = "кръгла",
                Portions = 20,
                CategoryId = 5,
                ProductId = 6,
            };
            cakes.Add(cake);

            //7
            cake = new Cake
            {
                Id = 7,
                Layers = 2,
                Form = "кръгла",
                Portions = 25,
                CategoryId = 2,
                ProductId = 7,
            };
            cakes.Add(cake);

            //8
            cake = new Cake
            {
                Id = 8,
                Layers = 1,
                Form = "кръгла",
                Portions = 30,
                CategoryId = 2,
                ProductId = 8,
            };
            cakes.Add(cake);

            //9
            cake = new Cake
            {
                Id = 9,
                Layers = 1,
                Form = "кръгла",
                Portions = 35,
                CategoryId = 5,
                ProductId = 9,
            };
            cakes.Add(cake);

            //10
            cake = new Cake
            {
                Id = 10,
                Layers = 1,
                Form = "полукръгла",
                Portions = 10,
                CategoryId = 2,
                ProductId = 10,
            };
            cakes.Add(cake);

            return cakes;

        }

	}
}
