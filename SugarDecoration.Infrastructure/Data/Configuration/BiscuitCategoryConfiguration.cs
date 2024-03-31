using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Infrastructure.Data.Configuration
{
    public class BiscuitCategoryConfiguration : IEntityTypeConfiguration<BiscuitCategory>
    {
        public void Configure(EntityTypeBuilder<BiscuitCategory> builder)
        {
            builder.HasData(SeedBiscuitCategories());
        }

        private static List<BiscuitCategory> SeedBiscuitCategories() 
        {
            var biscuitCategories = new List<BiscuitCategory>();

            var biscuitCategory = new BiscuitCategory
            {
                Id = 1,
                Name = "Коледни"
            };

            biscuitCategories.Add(biscuitCategory);

            biscuitCategory = new BiscuitCategory
            {
                Id = 2,
                Name = "Декоративни"
            };

            biscuitCategories.Add(biscuitCategory);

            biscuitCategory = new BiscuitCategory
            {
                Id = 3,
                Name = "Специален повод"
            };

            biscuitCategories.Add(biscuitCategory);

            return biscuitCategories;
        }
    }
}
