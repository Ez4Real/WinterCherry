using AutoMapper;
using Catalog.API.DTO;
using Catalog.BLL.Interfaces.IServices;
using Catalog.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RoomsController
    {
        private readonly IRoomsService _roomsService;
        private readonly IMapper _mapper;
        public RoomsController(
            IRoomsService roomsService,
            IMapper mapper)
        {
            _roomsService = roomsService;
            _mapper = mapper;
        }


        #region RoomsAPIs
        // GET: /Rooms Get all Rooms
        [HttpGet]
        public async Task<IEnumerable<RoomsDTO>> GetAllRoomsAsync()
        {
            var rooms = await _roomsService.GetAllRoomsAysnc();
            var roomsDTO = _mapper.Map<IEnumerable<RoomsDTO>>(rooms);
            return roomsDTO;

        }

        // GET: /Rooms/{Id} Get Rooms by id
        [HttpGet("{Id}")]
        public async Task<Rooms> GetRoomsByIdAsync(int Id)
        {
            return await _roomsService.GetRoomsByIdAysnc(Id);
        }

        // POST: /Rooms Add new Rooms
        [HttpPost]
        public async Task<Rooms> AddRoomsAsync([FromBody] Rooms rooms)
        {
            return await _roomsService.AddRoomsAysnc(rooms);
        }

        // PUT: /Rooms Update existing Rooms
        [HttpPut]
        public async Task<Rooms> UpdateRoomsAsync([FromBody] Rooms rooms)
        {
            return await _roomsService.UpdateRoomsAysnc(rooms);
        }

        // DELETE: /Rooms/{Id} Delete existing Rooms
        [HttpDelete("{id}")]
        public async Task<Rooms> DeleteRoomsAsync(int id)
        {
            return await _roomsService.DeleteRoomsAysnc(id);
        }
        #endregion
    }
}
