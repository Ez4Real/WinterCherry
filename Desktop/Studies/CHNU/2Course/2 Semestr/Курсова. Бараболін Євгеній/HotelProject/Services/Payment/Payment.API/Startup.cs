using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Payment.Application.Interfaces;
using Payment.Application.Interfaces.IRepositories;
using Payment.Application.Interfaces.IServices;
using Payment.Application.Mapper;
using Payment.Infrastructure.DBContext;
using Payment.Infrastructure.Repositories;
using Payment.Infrastructure.Services;
using Payment.Infrastructure.UnitOfWorks;

namespace Payment.API
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
            services.AddControllers();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<PaymentDBContext>();
            #region SQL repositories
            services.AddTransient<IClientsRepository, ClientsRepository>();
            #endregion

            #region SQL services
            services.AddTransient<IClientsService, ClientsService>();
            #endregion
            #region Automapper
            services.AddAutoMapper(typeof(MappingProfile));
            #endregion
            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Payment.API", Version = "v1" });
            });
            #endregion

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Payment.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
