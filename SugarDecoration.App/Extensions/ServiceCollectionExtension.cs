using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Services;
using SugarDecoration.Infrastructure.Data;
using SugarDecoration.Infrastructure.Data.Contracts;

namespace SugarDecoration.Extensions
{
	public static class ServiceCollectionExtension
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
			services.AddScoped<ICakeService, CakeService>();
			services.AddScoped<IBiscuitService, BiscuitService>();
			return services;
		}
		public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
		{
			var connectionString = config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
			services.AddDbContext<SugarDecorationDb>(options =>
				options.UseSqlServer(connectionString));

			services.AddScoped<IRepository, Repository>();

			services.AddDatabaseDeveloperPageExceptionFilter();

			return services;
		}
		public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
		{
			services.AddDefaultIdentity<IdentityUser>(options =>
			{
				options.SignIn.RequireConfirmedAccount = false;
			}).AddEntityFrameworkStores<SugarDecorationDb>();

			return services;
		}
	}
}
