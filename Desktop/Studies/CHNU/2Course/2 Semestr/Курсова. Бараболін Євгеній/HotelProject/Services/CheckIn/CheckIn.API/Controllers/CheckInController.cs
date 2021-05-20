using AutoMapper;
using Booking.API.DTO;
using Booking.API.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Booking.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CheckInController
    {
        private readonly ICheckInService _checkInService;
        private readonly IMapper _mapper;
        public CheckInController(
            ICheckInService checkInService,
            IMapper mapper)
        {
            _checkInService = checkInService;
            _mapper = mapper;
        }


        #region CheckInAPIs
        // GET: /CheckIn Get all CheckIn
        [HttpGet]
        public async Task<IEnumerable<CheckInDTO>> GetAllCheckInAsync()
        {
            var checkIn = await _checkInService.GetAllCheckInAsync();
            var checkInDTO = _mapper.Map<IEnumerable<CheckInDTO>>(checkIn);
            return checkInDTO;

        }

        // GET: /CheckIn/{Id} Get CheckIn by id
        [HttpGet("{Id}")]
        public async Task<Entities.CheckIn> GetCheckInByIdAsync(int Id)
        {
            return await _checkInService.GetCheckInByIdAsync(Id);
        }

        // POST: /CheckIn Add new CheckIn
        [HttpPost]
        public async Task<bool> AddCheckInAsync([FromBody] Entities.CheckIn checkIn)
        {
            return await _checkInService.AddCheckInAsync(checkIn);
        }

        // PUT: /CheckIn Update existing CheckIn
        [HttpPut]
        public async Task<bool> UpdateCheckInAsync([FromBody] Entities.CheckIn checkIn)
        {
            return await _checkInService.UpdateCheckInAsync(checkIn);
        }

        // DELETE: /CheckIn/{Id} Delete existing CheckIn
        [HttpDelete("{id}")]
        public async Task<bool> DeleteCheckInAsync(int id)
        {
            return await _checkInService.DeleteCheckInAsync(id);
        }
        #endregion
    }
}
