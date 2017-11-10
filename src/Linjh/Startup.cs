using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Linjh.DBcontext;
using Microsoft.EntityFrameworkCore;
using Linjh.Repositories;
using Linjh.Models;
using Linjh.Repositories.Admin;

namespace Linjh
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
            services.AddMvc().AddSessionStateTempDataProvider(); ;

            //上下文服务注册
            services.AddDbContext<LinDbcontext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("LinDbcontext")));
            //后台用户仓储服务注册
            services.AddScoped<AdminUserRepository>();
            //Session服务
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                   name: "Admin",
                   template: "{area:exists}/{controller=Login}/{action=Index}/{id?}");
                
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
