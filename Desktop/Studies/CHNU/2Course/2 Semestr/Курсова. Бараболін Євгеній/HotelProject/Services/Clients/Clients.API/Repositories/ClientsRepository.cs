using Clients.API.EfDBContext;
using Clients.API.Entities;
using Clients.API.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clients.API.Repositories
{
    public class ClientsRepository : GenericRepository<Entities.Clients>, IClientsRepository
    {
        public ClientsRepository(ClientsDbContext context) : base(context)
        {
        }
    }
}
