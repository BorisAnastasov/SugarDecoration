using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Infrastructure.Data.Configuration
{
    public class BiscuitConfiguration : IEntityTypeConfiguration<Biscuit>
    {
        public void Configure(EntityTypeBuilder<Biscuit> builder)
        {
            builder.HasData(
            new Biscuit 
            {
                Quantity = 10,
                CategoryId = 1,
                ProductId = 6
            },
            new Biscuit
            {
                Quantity = 8,
                CategoryId = 1,
                ProductId = 7
            },
            new Biscuit
            {
                Quantity = 10,
                CategoryId = 3,
                ProductId = 8
            },
            new Biscuit
            {
                Quantity = 12,
                CategoryId = 3,
                ProductId = 9
            }
            );
        }
    }
}
