using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using GamesWebAppDB.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GamesWebAppDB.Models;

namespace GamesWebAppDB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<AppUser, IdentityRole>().AddDefaultUI().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
            services.AddScoped<iGameRepo, GameRepo>();
            services.AddScoped<iGenreRepo, GenreRepo>();

            services.AddAuthentication().AddGoogle(options =>
            {
                options.ClientId = "192983882395-6ie7cfbkmmhrce3mmkuagm97pe00njj5.apps.googleusercontent.com";
                options.ClientSecret = "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";
                options.SignInScheme = IdentityConstants.ExternalScheme;
            });

            services.AddControllersWithViews();
            services.AddRazorPages();

            //shopping cart
            services.AddScoped<ShoppingCart>(sm => ShoppingCart.GetCart(sm));
            services.AddHttpContextAccessor();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Games}/{action=AllGames}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
