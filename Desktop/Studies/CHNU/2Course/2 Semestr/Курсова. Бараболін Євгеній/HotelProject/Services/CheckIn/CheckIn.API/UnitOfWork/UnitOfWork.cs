using Booking.API.Interfaces;
using Booking.API.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ICheckInRepository _CheckInRepository;

        public UnitOfWork(ICheckInRepository CheckInRepository)
        {
            _CheckInRepository = CheckInRepository;
        }
        public ICheckInRepository CheckInRepository { get { return _CheckInRepository; } }
    }


}
