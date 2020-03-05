using AgenciaViajes.Presentation.API.Context;
using AgenciaViajes.Presentation.API.Entities;
using AgenciaViajes.Presentation.API.Interfaces;
using AgenciaViajes.Presentation.API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AgenciaViajes.Presentation.API
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
            services.AddMvc().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddControllers();
            

            services.AddTransient<ICRUDMethods<TravelPackage>, TravelPackageService>();
            services.AddTransient<ICRUDMethods<Entities.Client>, ClientService>();
            services.AddTransient<ICRUDMethods<Booking>, BookingService>();
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlite("Filename=MyDatabase.db"));
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
