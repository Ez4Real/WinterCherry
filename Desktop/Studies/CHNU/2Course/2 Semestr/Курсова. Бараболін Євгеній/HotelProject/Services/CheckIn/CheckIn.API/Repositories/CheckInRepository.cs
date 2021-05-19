using Booking.API.Interfaces.IConnectionFactory;
using Booking.API.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API.Repositories
{
    public class CheckInRepository : GenericRepository<Entities.CheckIn>, ICheckInRepository
    {
        public CheckInRepository(IBookingConnectionFactory connectionFactory) : base(connectionFactory, "CheckIn")
        { 
        }
    }
}
