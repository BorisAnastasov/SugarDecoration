using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Infrastructure.Data.Configuration
{
    public class CakeCategoryConfiguration : IEntityTypeConfiguration<CakeCategory>
    {
        public void Configure(EntityTypeBuilder<CakeCategory> builder)
        {
            builder.HasData(SeedCakeCategories());
        }

        private static List<CakeCategory> SeedCakeCategories()
        {
            var cakeCategories = new List<CakeCategory>();

            var cakeCategory = new CakeCategory
            {
                Id = 1,
                Name = "Сватбена торта"
            };
            cakeCategories.Add(cakeCategory);

            cakeCategory = new CakeCategory
            {
                Id = 2,
                Name = "Детска торта"
            };
            cakeCategories.Add(cakeCategory);

            cakeCategory = new CakeCategory
            {
                Id = 3,
                Name = "Стандартна торта"
            };
            cakeCategories.Add(cakeCategory);

            cakeCategory = new CakeCategory
            {
                Id = 4,
                Name = "18+"
            };
            cakeCategories.Add(cakeCategory);

            cakeCategory = new CakeCategory
            {
                Id = 5,
                Name = "Специални поводи"
            };
            cakeCategories.Add(cakeCategory);


            return cakeCategories;
        }
    }
}
