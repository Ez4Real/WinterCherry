using Catalog.BLL.Interfaces.IServices;
using Catalog.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    public class RoomImagesController : ControllerBase
    {
        private IRoomImagesService _roomsService { get; }
        public RoomImagesController(IRoomImagesService roomsService)
        {
            _roomsService = roomsService;
        }

        [Route("/RoomImages")]
        [HttpGet]
        public async Task<IEnumerable<RoomImages>> GetAllRoomImages()
        {
            return await _roomsService.GetAllRoomImagesAysnc();
        }

        [Route("/RoomImages/{id}")]
        [HttpGet]
        public async Task<RoomImages> GetRoomImagesByIdAsync(int id)
        {
            return await _roomsService.GetRoomImagesByIdAysnc(id);
        }

        [Route("/RoomImages")]
        [HttpPost]
        public async Task<RoomImages> AddRoomImagesAsync([FromBody] RoomImages rooms)
        {
            return await _roomsService.AddRoomImagesAysnc(rooms);
        }

        [Route("/RoomImages")]
        [HttpPut]
        public async Task<RoomImages> UpdateRoomImagesAsync([FromBody] RoomImages rooms)
        {
            return await _roomsService.UpdateRoomImagesAysnc(rooms);
        }

        [Route("/RoomImages/{id}")]
        [HttpDelete]
        public async Task<RoomImages> DeleteRoomImagesAsync(int id)
        {
            return await _roomsService.DeleteRoomImagesAysnc(id);
        }
    }
}
