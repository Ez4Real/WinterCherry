using Hotel.API.Entities;
using Hotel.API.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.Controllers
{
    public class RoomsController : ControllerBase
    {
        private IRoomsService _roomsService { get; }
        public RoomsController(IRoomsService roomsService)
        {
            _roomsService = roomsService;
        }

        [Route("/Rooms")]
        [HttpGet]
        public async Task<IEnumerable<Rooms>> GetAllRooms()
        {
            return await _roomsService.GetAllRoomsAysnc();
        }

        [Route("/Rooms/{id}")]
        [HttpGet]
        public async Task<Rooms> GetRoomsByIdAsync(int id)
        {
            return await _roomsService.GetRoomsByIdAysnc(id);
        }

        [Route("/Rooms")]
        [HttpPost]
        public async Task<Rooms> AddRoomsAsync([FromBody] Rooms rooms)
        {
            return await _roomsService.AddRoomsAysnc(rooms);
        }

        [Route("/Rooms")]
        [HttpPut]
        public async Task<Rooms> UpdateRoomsAsync([FromBody] Rooms rooms)
        {
            return await _roomsService.UpdateRoomsAysnc(rooms);
        }

        [Route("/Rooms/{id}")]
        [HttpDelete]
        public async Task<Rooms> DeleteRoomsAsync(int id)
        {
            return await _roomsService.DeleteRoomsAysnc(id);
        }
    }
}
