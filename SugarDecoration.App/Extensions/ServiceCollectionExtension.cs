using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Contracts.Admin;
using SugarDecoration.Core.Services;
using SugarDecoration.Core.Services.Admin;
using SugarDecoration.Infrastructure.Data;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models.Account;
using static SugarDecoration.Infrastructure.Data.Constants.RoleConstants;


namespace SugarDecoration.Extensions
{
	public static class ServiceCollectionExtension
	{

		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
			services.AddScoped<ICakeService, CakeService>();
			services.AddScoped<IAdminCakeService, AdminCakeService>();
			services.AddScoped<IBiscuitService, BiscuitService>();
			services.AddScoped<IAdminBiscuitService, AdminBiscuitService>();
			services.AddTransient<IHomeService, HomeService>();
			services.AddTransient<ICartService, CartService>();
			services.AddScoped<IAdminOrderService, AdminOrderService>();
			services.AddScoped<IOrderService, OrderService>();
			services.AddTransient<IApplicationUserService, ApplicationUserService>();

			services.AddAuthorization(options =>
			{
				options.AddPolicy("Administrator", policy => policy.RequireRole(AdminRoleName));
				options.AddPolicy("User", policy => policy.RequireRole(UserRoleName));
			});
			services.AddAuthentication(options =>
			{
				options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
			})
			.AddCookie(options =>
			{
				options.LoginPath = "/User/Login";
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
			.AddEntityFrameworkStores<SugarDecorationDb>()
			.AddDefaultTokenProviders();

			return services;
		}

	}
}
