using Booking.API.Interfaces;
using Booking.API.Interfaces.IRepositories;
using Booking.API.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API.Services
{
    public class CheckInService : ICheckInService
    {
        private ICheckInRepository _checkInRepository;

        public CheckInService(ICheckInRepository checkInRepository)
        {
            _checkInRepository = checkInRepository;
        }

        public async Task<IEnumerable<Entities.CheckIn>> GetAllCheckInsAsync()
        {
            return await _checkInRepository.GetAllAsync();
        }
        public async Task<Entities.CheckIn> GetCheckInByIdAsync(int Id)
        {
            return await _checkInRepository.GetByIdAsync(Id);
        }
        public async Task<bool> AddCheckInAsync(Entities.CheckIn checkin)
        {
            return await _checkInRepository.AddAsync(checkin);
        }
        public async Task<bool> UpdateCheckInAsync(Entities.CheckIn checkin)
        {
            return await _checkInRepository.UpdateAsync(checkin);
        }
        public async Task<bool> DeleteCheckInAsync(int Id)
        {
            return await _checkInRepository.DeleteAsync(Id);
        }
    }
}
