using ExpressSystem.Models;
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

namespace ExpressSystem
{
    public class Startup
    {

        public IConfiguration _configuration { get; }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<OracleDBContext>(
                options => options.UseOracle(_configuration.GetConnectionString("OracleConn"), b => b.UseOracleSQLCompatibility("12"))
                );

            services.AddScoped<IUserRepository, OracleUserRepository>();
            services.AddScoped<IClientRepository, OracleClientRepository>();
            services.AddScoped<OracleDBContext>();

            services.AddControllersWithViews();
            services.AddControllers();
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            //app.UseStaticFiles();

            app.UseRouting();

            //app.UseAuthentication();   //身份验证
            //app.UseAuthorization();    //授权

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
