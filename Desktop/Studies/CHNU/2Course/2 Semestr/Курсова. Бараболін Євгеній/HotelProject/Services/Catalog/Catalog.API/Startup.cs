using Catalog.BLL.Interfaces;
using Catalog.BLL.Interfaces.IServices;
using Catalog.BLL.Services;
using Catalog.BLL.UnitOfWork;
using Catalog.DAL.EfDBContext;
using Catalog.DAL.Interfaces.Interfaces;
using Catalog.DAL.Interfaces.IRepositories;
using Catalog.DAL.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace Catalog.API
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
            services.AddDbContext<CatalogDbContext>();
            #region SQL repositories
            services.AddTransient<IRoomImagesRepository, RoomImagesRepository>();
            services.AddTransient<IRoomsRepository, RoomsRepository>();
            #endregion

            #region SQL services
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
