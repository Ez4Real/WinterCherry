using Booking.API.Entities;
using Booking.API.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API.Controllers
{
    public class CheckInController : ControllerBase
    {
            private ICheckInService _checkinService { get; }
            public CheckInController(ICheckInService checkinService)
            {
                _checkinService = checkinService;
            }

            #region BookingAPI
            [Route("/CheckIn")]
            [HttpGet]
            public async Task<IEnumerable<Entities.CheckIn>> GetAllCheckIn()
            {
                return await _checkinService.GetAllCheckInsAsync();
            }

            [Route("/CheckIn/{id}")]
            [HttpGet]
            public async Task<Entities.CheckIn> GetCheckInByIdAsync(int id)
            {
                return await _checkinService.GetCheckInByIdAsync(id);
            }

            [Route("/CheckIn")]
            [HttpPost]
            public async Task<bool> AddCheckInAsync([FromBody] Entities.CheckIn checkin)
            {
                return await _checkinService.AddCheckInAsync(checkin);
            }

            [Route("/CheckIn")]
            [HttpPut]
            public async Task<bool> UpdateCheckInAsync([FromBody] Entities.CheckIn checkin)
            {
                return await _checkinService.UpdateCheckInAsync(checkin);
            }

            [Route("/CheckIn/{id}")]
            [HttpDelete]
            public async Task<bool> DeleteCheckInAsync(int id)
            {
                return await _checkinService.DeleteCheckInAsync(id);
            }
            #endregion
        
    }
}
