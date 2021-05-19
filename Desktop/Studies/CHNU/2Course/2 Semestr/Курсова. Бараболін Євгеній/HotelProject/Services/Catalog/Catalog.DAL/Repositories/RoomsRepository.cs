using Catalog.DAL.Entities;
using Catalog.DAL.Interfaces.Interfaces;
using Catalog.DAL.EfDBContext;

namespace Catalog.DAL.Repositories
{
    public class RoomsRepository : GenericRepository<Rooms>, IRoomsRepository
    {
        public RoomsRepository(CatalogDbContext context) : base(context)
        {
        }
    }
}
