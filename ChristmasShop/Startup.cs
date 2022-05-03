﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ChristmasShop.Data;
using ChristmasShop.Data.interfaces;
using Microsoft.EntityFrameworkCore;
using ChristmasShop.Data.Repository;
using ChristmasShop.Data.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Hosting;

namespace ChristmasShop
{
    public class Startup
    {

        private IConfigurationRoot _confSting;
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostenv)
        {
            _confSting = new ConfigurationBuilder().SetBasePath(hostenv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confSting.GetConnectionString("DefaultConnection")));
            //services.AddTransient<IAllCars, CarRepository>(); // bind interface and mocks
            //services.AddTransient<ICarsCategory, CategoryRepository>(); // bind interface and mocks
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/SignIn");
                options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Account/SignIn");
            });

            services.AddTransient<IUsers, UserRepository>();

            services.AddTransient<IAllTrees, TreeRepository>();
            services.AddTransient<ITreesCategory, CategoryTreeRepository>();
            services.AddTransient<IAllOrders, OrdersRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCart(sp));
            
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles(); // css and other files
            app.UseSession();
            // app.UseMvcWithDefaultRoute(); // track address (URL ADRESS AND USING CONTROL DEFAULT)


            app.UseStatusCodePages();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseRouting();

            app.UseAuthentication();
            //app.UseAuthorization();

            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "Tree/{action}/{category?}", defaults: new { Controller = "Tree", action="List"});

            });


            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }
        }
    }
}
