using Catalog.DAL.EfDBContext;
using Catalog.DAL.Entities;
using Catalog.DAL.Interfaces.IRepositories;

namespace Catalog.DAL.Repositories
{
    public class RoomImagesRepository : GenericRepository<RoomImages>, IRoomImagesRepository
    {
        public RoomImagesRepository(CatalogDbContext context) : base(context)
        {
        }
    }
}
