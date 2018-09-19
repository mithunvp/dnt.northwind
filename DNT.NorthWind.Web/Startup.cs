using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNT.NorthWind.DataAccess.Interface;
using DNT.NorthWind.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DNT.NorthWind.DataAccess.Implementation;

namespace DNT.NorthWind.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddOptions();

            services.Configure<NorthWindConfiguration>(Configuration.GetSection("ConnectionStrings"));
            
            services.AddTransient<IDNTConnectionFactory, DNTConnectionFactory>();            
            services.AddScoped<IEmployeesRepository, EmployeesRepository>();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
