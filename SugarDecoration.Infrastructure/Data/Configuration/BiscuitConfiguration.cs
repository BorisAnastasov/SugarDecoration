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

            // Biscuit 1
            biscuits.Add(new Biscuit
            {
                Id = 1,
                Quantity = 10,
                CategoryId = 1,
                ProductId = 21
            });

            // Biscuit 2
            biscuits.Add(new Biscuit
            {
                Id = 2,
                Quantity = 8,
                CategoryId = 1,
                ProductId = 22
            });

            // Biscuit 3
            biscuits.Add(new Biscuit
            {
                Id = 3,
                Quantity = 7,
                CategoryId = 1,
                ProductId = 23
            });

            // Biscuit 4
            biscuits.Add(new Biscuit
            {
                Id = 4,
                Quantity = 6,
                CategoryId = 2,
                ProductId = 24
            });

            // Biscuit 5
            biscuits.Add(new Biscuit
            {
                Id = 5,
                Quantity = 9,
                CategoryId = 3,
                ProductId = 25
            });

            // Biscuit 6
            biscuits.Add(new Biscuit
            {
                Id = 6,
                Quantity = 8,
                CategoryId = 2,
                ProductId = 26
            });

            // Biscuit 7
            biscuits.Add(new Biscuit
            {
                Id = 7,
                Quantity = 5,
                CategoryId = 1,
                ProductId = 27
            });

            // Biscuit 8
            biscuits.Add(new Biscuit
            {
                Id = 8,
                Quantity = 4,
                CategoryId = 3,
                ProductId = 28
            });

            // Biscuit 9
            biscuits.Add(new Biscuit
            {
                Id = 9,
                Quantity = 6,
                CategoryId =3,
                ProductId = 29
            });

            // Biscuit 10
            biscuits.Add(new Biscuit
            {
                Id = 10,
                Quantity = 8,
                CategoryId = 3,
                ProductId = 30
            });

            // Biscuit 11
            biscuits.Add(new Biscuit
            {
                Id = 11,
                Quantity = 10,
                CategoryId = 3,
                ProductId = 31
            });

            // Biscuit 12
            biscuits.Add(new Biscuit
            {
                Id = 12,
                Quantity = 7,
                CategoryId = 3,
                ProductId = 32
            });

            // Biscuit 13
            biscuits.Add(new Biscuit
            {
                Id = 13,
                Quantity = 9,
                CategoryId = 3,
                ProductId = 33
            });

            // Biscuit 14
            biscuits.Add(new Biscuit
            {
                Id = 14,
                Quantity = 6,
                CategoryId = 2,
                ProductId = 34
            });

            // Biscuit 15
            biscuits.Add(new Biscuit
            {
                Id = 15,
                Quantity = 8,
                CategoryId = 2,
                ProductId = 35
            });

            // Biscuit 16
            biscuits.Add(new Biscuit
            {
                Id = 16,
                Quantity = 5,
                CategoryId = 2,
                ProductId = 36
            });

            // Biscuit 17
            biscuits.Add(new Biscuit
            {
                Id = 17,
                Quantity = 4,
                CategoryId = 3,
                ProductId = 37
            });

            // Biscuit 18
            biscuits.Add(new Biscuit
            {
                Id = 18,
                Quantity = 2,
                CategoryId = 3,
                ProductId = 38
            });

            // Biscuit 19
            biscuits.Add(new Biscuit
            {
                Id = 19,
                Quantity = 2,
                CategoryId = 2,
                ProductId = 39
            });

            // Biscuit 20
            biscuits.Add(new Biscuit
            {
                Id = 20,
                Quantity = 2,
                CategoryId = 3,
                ProductId = 40
            });

            return biscuits;
        }
    }
}
