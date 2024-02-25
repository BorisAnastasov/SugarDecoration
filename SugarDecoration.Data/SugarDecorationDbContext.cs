using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SugarDecoration.Data.Models;

namespace SugarDecoration.Data
{
    public class SugarDecorationDbContext:IdentityDbContext
    {

        public SugarDecorationDbContext(DbContextOptions<SugarDecorationDbContext> options)
        : base(options) { }

        public DbSet<Cake> Cakes { get; set; }

        public DbSet<Biscuit> Biscuits{ get; set; }
        public DbSet<BiscuitCategory> BiscuitCategories{ get; set; }
        public DbSet<CakeCategory> CakeCategories{ get; set; }
        public DbSet<Review> Reviews{ get; set; }



    }
}
