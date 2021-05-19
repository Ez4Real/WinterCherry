using Catalog.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.BLL.Interfaces.IServices
{
    public interface IRoomImagesService 
    {
        public Task<IEnumerable<RoomImages>> GetAllRoomImagesAysnc();

        public Task<RoomImages> GetRoomImagesByIdAysnc(int Id);

        public Task<RoomImages> AddRoomImagesAysnc(RoomImages roomImages);

        public Task<RoomImages> UpdateRoomImagesAysnc(RoomImages roomImages);

        public Task<RoomImages> DeleteRoomImagesAysnc(int Id);
    }
}
