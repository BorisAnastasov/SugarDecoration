namespace SugarDecoration.Infrastructure.Data
{
	using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore;

	public class SugarDecorationDb:IdentityDbContext
	{
		public SugarDecorationDb(DbContextOptions<SugarDecorationDb> options) : base(options) { }

		//Tables



		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}


	}
}
