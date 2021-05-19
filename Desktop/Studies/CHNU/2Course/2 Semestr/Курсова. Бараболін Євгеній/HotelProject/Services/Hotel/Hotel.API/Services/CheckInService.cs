using Hotel.API.Entities;
using Hotel.API.Interfaces.Interfaces;
using Hotel.API.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.Services
{
    public class CheckInService : ICheckInService
    {
        private IUnitOfWork _unitOfWork { get; set; }

        public CheckInService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<CheckIn>> GetAllCheckInAysnc()
        {
            return await _unitOfWork.CheckInRepository.GetAllAsync();
        }

        public async Task<CheckIn> GetCheckInByIdAysnc(int Id)
        {
            return await _unitOfWork.CheckInRepository.GetByIdAsync(Id);
        }

        public async Task<CheckIn> AddCheckInAysnc(CheckIn checkin)
        {
            var res = await _unitOfWork.CheckInRepository.AddAsync(checkin);
            //_unitOfWork.CheckInRepo.SaveChangesAsync();
            return res;
        }

        public async Task<CheckIn> UpdateCheckInAysnc(CheckIn checkin)
        {
            var res = await _unitOfWork.CheckInRepository.UpdateAsync(checkin);
            //_unitOfWork.CheckInRepo.SaveChangesAsync();
            return res;
        }

        public async Task<CheckIn> DeleteCheckInAysnc(int Id)
        {
            var res = await _unitOfWork.CheckInRepository.DeleteAsync(Id);
            //_unitOfWork.CheckInRepo.SaveChangesAsync();
            return res;
        }
    }
}
