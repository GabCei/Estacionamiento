using CeibaEstacionamientoGjmg.AccesoADatos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CeibaEstacionamientoGjmg
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
            services.AddMvc();

            var conexion = @"Server=GABRIEL-MUNOZ\SQLEXPRESS;Database=DbEstacionamiento;Trusted_Connection=True";

            services.AddDbContext<DbEstacionamientoContext>(options => options.UseSqlServer(conexion, b => b.MigrationsAssembly("CeibaEstacionamientoGjmg")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
