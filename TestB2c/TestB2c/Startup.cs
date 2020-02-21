using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository;
using Repository.GenericRepo;
using Repository.Managers;


namespace TestB2c
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<EmployeeContext>(option =>
            {
                option.UseSqlServer(Configuration.GetConnectionString("connectionString"));
            });
            services.AddScoped<PermanentEmployeeManager>();
            services.AddScoped<MedicalManager>();
            services.AddScoped<B2CUserManager>();
            //IGenericRepository<PermanentEmployee
            services.AddTransient(typeof(GenericRepository<>), typeof(GenericRepository<>));
            services.AddSingleton<B2CGraphClient>(new B2CGraphClient("2b34c559-5fbe-4248-ad52-a7e03c47c194", "GE@MZpyrD5Teg.ttg6@XjXmejTNH?i08", "cldtestsid.onmicrosoft.com"));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(builder =>
                builder.AllowAnyOrigin());

            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
        }
    }
}
