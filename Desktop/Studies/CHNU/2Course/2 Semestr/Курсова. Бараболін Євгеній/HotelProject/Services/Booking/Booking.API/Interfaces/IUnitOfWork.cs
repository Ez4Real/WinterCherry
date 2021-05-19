using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API.Interfaces.Interfaces
{
    public interface IUnitOfWork
    {
        public ICheckInRepository CheckInRepository { get; }
        public IClientsRepository ClientsRepository { get; }

    }
}
