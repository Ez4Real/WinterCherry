using Booking.API.ConnectionFactory;
using Booking.API.Interfaces;
using Booking.API.Interfaces.IConnectionFactory;
using Booking.API.Interfaces.IRepositories;
using Booking.API.Interfaces.IServices;
using Booking.API.Mapper;
using Booking.API.Repositories;
using Booking.API.Services;
using Booking.API.UnitOfWorks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Booking.API
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

            #region Repositories
            services.AddTransient<ICheckInRepository, CheckInRepository>();
            #endregion

            #region Services
            services.AddTransient<ICheckInService, CheckInService>();
            #endregion

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            #region Connection
            services.AddTransient<IBookingConnectionFactory, BookingConnectionFactory>();
            #endregion

            #region Automapper
            services.AddAutoMapper(typeof(MappingProfile));
            #endregion

            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Booking.API", Version = "v1" });
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
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Booking.API v1"));
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