using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PsyAgregator.Data;
using PsyAgregator.Repositories;
using PsyAgregator.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace PsyAgregator
{
    public class Startup
    {
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 7;
                options.Password.RequireUppercase = true;

                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<PsychologistContext>();

            services.AddTransient<IPsychologistRepository, PsychologistRepository>();
            //services.AddDbContext<PsychologistContext>(options =>
            //options.UseSqlite("Data Source=psychologists.db"));

            services.AddDbContext<PsychologistContext>(options =>
                  options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddControllersWithViews();
        }

        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, PsychologistContext psychologistContext)
        {
            psychologistContext.Database.EnsureDeleted();
            psychologistContext.Database.EnsureCreated();

            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "Default",
                template: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" });
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Page not found");
            });
        }
    }
}
