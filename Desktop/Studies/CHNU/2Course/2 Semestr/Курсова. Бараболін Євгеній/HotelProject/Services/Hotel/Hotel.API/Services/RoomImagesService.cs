using Hotel.API.Entities;
using Hotel.API.Interfaces.Interfaces;
using Hotel.API.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.Services
{
    public class RoomImagesService : IRoomImagesService
    {
        private IUnitOfWork _unitOfWork { get; set; }

        public RoomImagesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<RoomImages>> GetAllRoomImagesAysnc()
        {
            return await _unitOfWork.RoomImagesRepository.GetAllAsync();
        }

        public async Task<RoomImages> GetRoomImagesByIdAysnc(int Id)
        {
            return await _unitOfWork.RoomImagesRepository.GetByIdAsync(Id);
        }

        public async Task<RoomImages> AddRoomImagesAysnc(RoomImages roomImages)
        {
            var res = await _unitOfWork.RoomImagesRepository.AddAsync(roomImages);
            //_unitOfWork.RoomImagesRepo.SaveChangesAsync();
            return res;
        }

        public async Task<RoomImages> UpdateRoomImagesAysnc(RoomImages roomImages)
        {
            var res = await _unitOfWork.RoomImagesRepository.UpdateAsync(roomImages);
            //_unitOfWork.RoomImagesRepo.SaveChangesAsync();
            return res;
        }

        public async Task<RoomImages> DeleteRoomImagesAysnc(int Id)
        {
            var res = await _unitOfWork.RoomImagesRepository.DeleteAsync(Id);
            //_unitOfWork.RoomImagesRepo.SaveChangesAsync();
            return res;
        }
    }
}
