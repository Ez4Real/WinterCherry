using Hotel.API.Entities;
using Hotel.API.Interfaces.Interfaces;
using Hotel.API.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.Services
{
    public class RoomsService : IRoomsService
    {
        private IUnitOfWork _unitOfWork { get; set; }

        public RoomsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Rooms>> GetAllRoomsAysnc()
        {
            return await _unitOfWork.RoomsRepository.GetAllAsync();
        }

        public async Task<Rooms> GetRoomsByIdAysnc(int Id)
        {
            return await _unitOfWork.RoomsRepository.GetByIdAsync(Id);
        }

        public async Task<Rooms> AddRoomsAysnc(Rooms rooms)
        {
            var res = await _unitOfWork.RoomsRepository.AddAsync(rooms);
            //_unitOfWork.RoomsRepo.SaveChangesAsync();
            return res;
        }

        public async Task<Rooms> UpdateRoomsAysnc(Rooms rooms)
        {
            var res = await _unitOfWork.RoomsRepository.UpdateAsync(rooms);
            //_unitOfWork.RoomsRepo.SaveChangesAsync();
            return res;
        }

        public async Task<Rooms> DeleteRoomsAysnc(int Id)
        {
            var res = await _unitOfWork.RoomsRepository.DeleteAsync(Id);
            //_unitOfWork.RoomsRepo.SaveChangesAsync();
            return res;
        }
    }
}
