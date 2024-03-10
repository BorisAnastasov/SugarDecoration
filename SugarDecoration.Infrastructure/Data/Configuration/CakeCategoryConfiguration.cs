using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Infrastructure.Data.Configuration
{
	public class CakeCategoryConfiguration : IEntityTypeConfiguration<CakeCategory>
	{
		public void Configure(EntityTypeBuilder<CakeCategory> builder)
		{
			builder.HasData(
			new CakeCategory
			{
				Id = 1,
				Name = "Сватбена торта",
			},
			new CakeCategory
			{
				Id = 2,
				Name = "Детска торта",
			},
			new CakeCategory
			{
				Id = 3,
				Name = "Стандартна торта",
			},
			new CakeCategory
			{
				Id = 4,
				Name = "18+",
			}
			);
		}
	}
}
