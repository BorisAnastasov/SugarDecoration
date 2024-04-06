using Microsoft.AspNetCore.Mvc;
using SugarDecoration.App.Extensions;
using SugarDecoration.App.ModelBinders;
using SugarDecoration.Extensions;

namespace SugarDecoration.App
{
	public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            

            // Add services to the container.
            builder.Services.AddApplicationDbContext(builder.Configuration);

            builder.Services.AddApplicationIdentity(builder.Configuration);

            builder.Services.AddApplicationServices();

			builder.Services.AddControllersWithViews(options =>
			{
				options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
                options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
			});

			builder.Services.AddRazorPages();

			var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                app.UseExceptionHandler("/Error");
            }
            else
            {
                app.UseStatusCodePagesWithRedirects("Error/{0}");
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.SeedRoles();

            app.Run();
        }
    }
}