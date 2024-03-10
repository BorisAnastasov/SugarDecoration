using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Infrastructure.Data.Configuration
{
	public class CakeConfiguration:IEntityTypeConfiguration<Cake>
	{
		public void Configure(EntityTypeBuilder<Cake> builder)
		{
			builder.HasData(
			new Cake
			{
				Id = 1,
				Layers = 3,
				Portions = 35,
				Form = "кръгла",
				CategoryId = 1,
			},
			new Cake
			{
				Id = 2,
				Layers = 2,
				Portions = 30,
				Form = "кръгла",
				CategoryId = 1
			},
			new Cake
			{
				Id = 3,
				Layers = 2,
				Portions = 30,
				Form = "кръгла",
				CategoryId = 1
			}
			);
		}

	}
}
