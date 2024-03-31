using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Infrastructure.Data.Configuration
{
    public class BiscuitConfiguration : IEntityTypeConfiguration<Biscuit>
    {
        public void Configure(EntityTypeBuilder<Biscuit> builder)
        {
            builder.HasData(SeedBiscuits());
        }

        private static List<Biscuit> SeedBiscuits()
        {
            var biscuits = new List<Biscuit>();

            //1
            var biscuit = new Biscuit
            {
                Id = 1,
                Quantity = 10,
                CategoryId = 1,
                ProductId = 11
            };
            biscuits.Add(biscuit);

            //2
            biscuit = new Biscuit
            {
                Id = 2,
                Quantity = 8,
                CategoryId = 1,
                ProductId = 12
            };
            biscuits.Add(biscuit);

            //3
            biscuit = new Biscuit
            {
                Id = 3,
                Quantity = 10,
                CategoryId = 3,
                ProductId = 13
            };
            biscuits.Add(biscuit);

            //4
            biscuit = new Biscuit
            {
                Id = 4,
                Quantity = 12,
                CategoryId = 3,
                ProductId = 14
            };
            biscuits.Add(biscuit);

            //5
            biscuit = new Biscuit
            {
                Id = 5,
                Quantity = 20,
                CategoryId = 3,
                ProductId = 15
            };
            biscuits.Add(biscuit);

            return biscuits;
        }
    }
}
