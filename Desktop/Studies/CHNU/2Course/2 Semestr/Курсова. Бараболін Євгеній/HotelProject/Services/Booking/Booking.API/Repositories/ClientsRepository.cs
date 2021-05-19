using Booking.API.Entities;
using Booking.API.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API.Repositories
{
    public class ClientsRepository : GenericRepository<Clients>, IClientsRepository
    {
    }
}
