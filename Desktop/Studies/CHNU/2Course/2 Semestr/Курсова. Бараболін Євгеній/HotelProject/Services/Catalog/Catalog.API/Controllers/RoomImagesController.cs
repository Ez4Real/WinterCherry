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
    public class RoomImagesController
    {
        private readonly IRoomImagesService _RoomImagesService;
        private readonly IMapper _mapper;
        public RoomImagesController(
            IRoomImagesService RoomImagesService,
            IMapper mapper)
        {
            _RoomImagesService = RoomImagesService;
            _mapper = mapper;
        }


        #region RoomImagesAPIs
        // GET: /RoomImages Get all RoomImages
        [HttpGet]
        public async Task<IEnumerable<RoomImagesDTO>> GetAllRoomImagesAsync()
        {
            var RoomImages = await _RoomImagesService.GetAllRoomImagesAysnc();
            var RoomImagesDTO = _mapper.Map<IEnumerable<RoomImagesDTO>>(RoomImages);
            return RoomImagesDTO;

        }

        // GET: /RoomImages/{Id} Get RoomImages by id
        [HttpGet("{Id}")]
        public async Task<RoomImages> GetRoomImagesByIdAsync(int Id)
        {
            return await _RoomImagesService.GetRoomImagesByIdAysnc(Id);
        }

        // POST: /RoomImages Add new RoomImages
        [HttpPost]
        public async Task<RoomImages> AddRoomImagesAsync([FromBody] RoomImages roomImages)
        {
            return await _RoomImagesService.AddRoomImagesAysnc(roomImages);
        }

        // PUT: /RoomImages Update existing RoomImages
        [HttpPut]
        public async Task<RoomImages> UpdateRoomImagesAsync([FromBody] RoomImages roomImages)
        {
            return await _RoomImagesService.UpdateRoomImagesAysnc(roomImages);
        }

        // DELETE: /RoomImages/{Id} Delete existing RoomImages
        [HttpDelete("{id}")]
        public async Task<RoomImages> DeleteRoomImagesAsync(int id)
        {
            return await _RoomImagesService.DeleteRoomImagesAysnc(id);
        }
        #endregion
    }
}
