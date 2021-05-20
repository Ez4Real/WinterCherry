using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API.Interfaces.IServices
{
    public interface ICheckInService
    {
        public Task<IEnumerable<Entities.CheckIn>> GetAllCheckInAsync();
        public Task<Entities.CheckIn> GetCheckInByIdAsync(int Id);
        public Task<bool> AddCheckInAsync(Entities.CheckIn checkin);
        public Task<bool> UpdateCheckInAsync(Entities.CheckIn checkin);
        public Task<bool> DeleteCheckInAsync(int Id);
    }
}
