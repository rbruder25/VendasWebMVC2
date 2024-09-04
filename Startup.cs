using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VendasWebMVC2.Data;
using VendasWebMVC2.Services;

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
            services.AddControllersWithViews();

            services.AddDbContext<VendasWebMVC2Context>(options =>
                options.UseMySql(
                    Configuration.GetConnectionString("VendasWebMVC2Context"),
                    new MySqlServerVersion(new Version(8, 0, 21)), // Coloque a versão do MySQL que você está utilizando
                    builder => builder.MigrationsAssembly("VendasWebMVC2")));

            services.AddScoped<SeedingService>();
            services.AddScoped<ServicoVendedor>();
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (!environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            else
            {
                // Criando um escopo manualmente para resolver o SeedingService
                using (var scope = app.Services.CreateScope())
                {
                    var seedingService = scope.ServiceProvider.GetRequiredService<SeedingService>();
                    seedingService.Seed();
                }
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

        void Configure(WebApplication app, IWebHostEnvironment environment);

        void ConfigureServices(IServiceCollection services);
    }

    public static class StartupExtensions
    {
        public static WebApplicationBuilder UseStartup<TStartup>(this WebApplicationBuilder builder) where TStartup : IStartup
        {
            var startup = Activator.CreateInstance(typeof(TStartup), builder.Configuration) as IStartup;
            if (startup == null)
                throw new ArgumentException("Classe startup.cs inválida");

            startup.ConfigureServices(builder.Services);

            var app = builder.Build();

            startup.Configure(app, app.Environment);

            app.Run();

            return builder;
        }
    }
}