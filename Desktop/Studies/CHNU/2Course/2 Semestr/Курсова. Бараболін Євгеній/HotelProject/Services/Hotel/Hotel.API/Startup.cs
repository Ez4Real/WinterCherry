using Hotel.API.EfDBContext;
using Hotel.API.Interfaces.Interfaces;
using Hotel.API.Interfaces.IRepositories;
using Hotel.API.Interfaces.IServices;
using Hotel.API.Repositories;
using Hotel.API.Services;
using Hotel.API.UnitOfWorks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API
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
            services.AddDbContext<HotelDbContext>();
            #region SQL repositories
            services.AddTransient<ICheckInRepository, CheckInRepository>();
            services.AddTransient<IClientsRepository, ClientsRepository>();
            services.AddTransient<ICommentsRepository, CommentsRepository>();
            services.AddTransient<IRoomImagesRepository, RoomImagesRepository>();
            services.AddTransient<IRoomsRepository, RoomsRepository>();
            #endregion

            #region SQL services
            services.AddTransient<ICheckInService, CheckInService>();
            services.AddTransient<IClientsService, ClientsService>();
            services.AddTransient<ICommentsService, CommentsService>();
            services.AddTransient<IRoomImagesService, RoomImagesService>();
            services.AddTransient<IRoomsService, RoomsService>();
            #endregion
            
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
