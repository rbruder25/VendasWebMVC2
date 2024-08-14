using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VendasWebMVC2.Data;

namespace VendasWebMVC2
{
    public class Startup : IStartup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            IMvcBuilder mvcBuilder = services.AddControllersWithViews();

            services.AddDbContext<VendasWebMVC2Context>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("VendasWebMVC2Context")));
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


        }
    }

        public interface IStartup
        {
            IConfiguration Configuration { get; }

            void Configure(WebApplication app, IWebHostEnvironment inviromennt);

            void ConfigureServices(IServiceCollection services);
        }

        public static class StartupExtensions
        {
            public static WebApplicationBuilder UseStartup<TStartup>(this WebApplicationBuilder WebappBuilder) where TStartup : IStartup
            {


                var startup = Activator.CreateInstance(typeof(TStartup), WebappBuilder.Configuration) as IStartup;
                if (startup == null) throw new ArgumentException("classe startup.cs invalida");


                startup.ConfigureServices(WebappBuilder.Services);

                var app = WebappBuilder.Build();

                startup.Configure(app, app.Environment);

                app.Run();

            return WebappBuilder;

            }
        }
    
}

