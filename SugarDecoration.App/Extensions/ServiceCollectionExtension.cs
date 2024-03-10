using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SugarDecoration.Infrastructure.Data;

namespace SugarDecoration.Extensions
{
	public static class ServiceCollectionExtension
	{
		public static IServiceCollection AddAplicationServices(this IServiceCollection services)
		{
			return services;
		}
		public static IServiceCollection AddAplicationDbContext(this IServiceCollection services, IConfiguration config)
		{
			var connectionString = config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
			services.AddDbContext<SugarDecorationDb>(options =>
				options.UseSqlServer(connectionString));

			services.AddDatabaseDeveloperPageExceptionFilter();

			return services;
		}
		public static IServiceCollection AddAplicationIdentity(this IServiceCollection services, IConfiguration config)
		{
			services.AddDefaultIdentity<IdentityUser>(options =>
			{
				options.SignIn.RequireConfirmedAccount = false;
			}).AddEntityFrameworkStores<SugarDecorationDb>();

			return services;
		}
	}
}
