using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CoreMVCProject1.Data;
using CoreMVCProject1.Models;
using CoreMVCProject1.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CoreMVCProject1
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(_configuration.GetConnectionString("CoreMVC")));
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddControllersWithViews();
            // services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseDefaultFiles();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
               // endpoints.MapControllers();

                endpoints.MapControllerRoute(
                    name: "Default",
                     pattern: "{controller=home}/{action=index}/{id?}"
                    );
                // endpoints.MapRazorPages();
            });

            //To Call next desired pipeline
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from 1st Middelware\n");
            //    await next();
            //});

            //Terminal Middelware
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        //throw new Exception();
            //        //await context.Response.WriteAsync(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            //        await context.Response.WriteAsync(_configuration["MyKey"]);
            //    });
            //});

            //Terminal Middleware
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello from 2nd Middleware");
            //});
        }
    }
}
