using Hotel.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.Interfaces.IServices
{
    public interface IRoomsService
    {
        public Task<IEnumerable<Rooms>> GetAllRoomsAysnc();

        public Task<Rooms> GetRoomsByIdAysnc(int Id);

        public Task<Rooms> AddRoomsAysnc(Rooms rooms);

        public Task<Rooms> UpdateRoomsAysnc(Rooms rooms);

        public Task<Rooms> DeleteRoomsAysnc(int Id);
    }
}
