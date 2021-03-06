using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PCPartTracker.Data;
using PCPartTracker.Repositories;

namespace PCPartTracker
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
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddScoped<IPCRepositiory, PCRepository>();
            services.AddScoped<ICaseRepository, CaseRepository>();
            services.AddScoped<ICPURepository, CPURepository>();
            services.AddScoped<IGPURepository, GPURepository>();
            services.AddScoped<IHarddriveRepository, HardriveRepository>();
            services.AddScoped<IMotherboardRepository, MotherboardRepository>();
            services.AddScoped<IPSURepository, PSURepository>();
            services.AddScoped<IRAMRepository, RAMRepository>();


            //        services.AddDbContext<PCContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<Context>(options => options.UseSqlite(Configuration.GetConnectionString("SQLLiteConnection")).EnableSensitiveDataLogging(true));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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

            app.UseAuthorization();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
