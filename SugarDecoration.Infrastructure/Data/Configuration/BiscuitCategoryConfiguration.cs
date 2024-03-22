using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Infrastructure.Data.Configuration
{
    public class BiscuitCategoryConfiguration : IEntityTypeConfiguration<BiscuitCategory>
    {
        public void Configure(EntityTypeBuilder<BiscuitCategory> builder)
        {
            builder.HasData(
            new BiscuitCategory
            {
                Id = 1,
                Name = "Коледни",
            },
            new BiscuitCategory
            {
                Id = 2,
                Name = "Декоративни",
            },
            new BiscuitCategory
            {
                Id = 3,
                Name = "Специален повод",
            });
        }
    }
}
