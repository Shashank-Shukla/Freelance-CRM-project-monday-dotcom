using CRM_Monday.Data.DbContexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_Monday
{
    public class Startup
    {
        const string licenseKey = "Mgo+DSMBaFt/QHRqVVhkVFpHaV5CQmFJfFBmRGNTel16d11WESFaRnZdQV1hSXZSdkBnWHdceXZU;Mgo+DSMBPh8sVXJ0S0J+XE9AflRBQmJJYVF2R2BJfl56cVZMY1RBNQtUQF1hSn5Rdk1iWXpacXxWRmdd;ORg4AjUWIQA/Gnt2VVhkQlFacldJXnxIfkx0RWFab19wflBFal9ZVAciSV9jS31TdEVrWH9bdHVdRWJdUA==;MTA5MDQ4OUAzMjMwMmUzNDJlMzBYaFRzbHlRQUJtaDJ0SHR4WmtaSVZnOWtPL1BYOTN2VTZLYmtvNXdUNXJVPQ==;MTA5MDQ5MEAzMjMwMmUzNDJlMzBWOVJtMDZyYU5jbkd4V3p3Szh2cHl3K3JIZS9uZ2VNUmpGM0ZHdGVPL1dZPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFtKVmBWf1NpR2NbfE5xdF9DY1ZSTGYuP1ZhSXxQdkdjUX5edXBUTmNbVEU=;MTA5MDQ5MkAzMjMwMmUzNDJlMzBWSmVEd3d6OXBnSTNsc29FRjVERGRLZ3cyTlcreFJqeCtiVlNkS0x4ZCtzPQ==;MTA5MDQ5M0AzMjMwMmUzNDJlMzBBRUNTMDg0UWJHMFZKVU4rd0Q4K1YrYktpN3FZNzJ2YThvTjA4dzAzcFUwPQ==;Mgo+DSMBMAY9C3t2VVhkQlFacldJXnxIfkx0RWFab19wflBFal9ZVAciSV9jS31TdEVrWH9bdHVdQmJaUA==;MTA5MDQ5NUAzMjMwMmUzNDJlMzBDRnZYK0hhTnVicmZXT1BCdFpCNERhMDl6MUVKek1xRmZoeG1rNnhxdXBZPQ==;MTA5MDQ5NkAzMjMwMmUzNDJlMzBvYjdDbllCWDNTWVY5VG12NVI2WUpKcUVTREt6d0l5Z2ViWU9vUEJOVW5JPQ==;MTA5MDQ5N0AzMjMwMmUzNDJlMzBWSmVEd3d6OXBnSTNsc29FRjVERGRLZ3cyTlcreFJqeCtiVlNkS0x4ZCtzPQ==";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<UserDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));     // TO-DO: Configure DB
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(licenseKey);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
