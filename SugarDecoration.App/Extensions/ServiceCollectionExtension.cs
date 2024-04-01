using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Services;
using SugarDecoration.Infrastructure.Data;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.IdentityModels;
using static SugarDecoration.Infrastructure.Data.Constants.RoleConstants;


namespace SugarDecoration.Extensions
{
	public static class ServiceCollectionExtension
	{ 

		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
			services.AddScoped<ICakeService, CakeService>();
			services.AddScoped<IBiscuitService, BiscuitService>();
			services.AddScoped<IHomeService, HomeService>();
			services.AddScoped<IProductService, ProductService>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Administrator", policy => policy.RequireRole(AdminRoleName));
                options.AddPolicy("User", policy => policy.RequireRole(UserRoleName));
            });

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
			services.AddDefaultIdentity<ApplicationUser>(options =>
			{
				options.SignIn.RequireConfirmedAccount = false;
			})
			.AddRoles<IdentityRole>()
			.AddEntityFrameworkStores<SugarDecorationDb>();

			return services;
		}

	}
}
