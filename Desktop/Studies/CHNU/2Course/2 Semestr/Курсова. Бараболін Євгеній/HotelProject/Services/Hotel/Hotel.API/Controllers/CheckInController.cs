using Hotel.API.Entities;
using Hotel.API.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.Controllers
{
    public class CheckInController : ControllerBase
    {
            private ICheckInService _checkinService { get; }
            public CheckInController(ICheckInService checkinService)
            {
                _checkinService = checkinService;
            }

            #region CheckInAPI
            [Route("/CheckIn")]
            [HttpGet]
            public async Task<IEnumerable<CheckIn>> GetAllCheckIn()
            {
                return await _checkinService.GetAllCheckInAysnc();
            }

            [Route("/CheckIn/{id}")]
            [HttpGet]
            public async Task<CheckIn> GetCheckInByIdAsync(int id)
            {
                return await _checkinService.GetCheckInByIdAysnc(id);
            }

            [Route("/CheckIn")]
            [HttpPost]
            public async Task<CheckIn> AddCheckInAsync([FromBody] CheckIn checkin)
            {
                return await _checkinService.AddCheckInAysnc(checkin);
            }

            [Route("/CheckIn")]
            [HttpPut]
            public async Task<CheckIn> UpdateCheckInAsync([FromBody] CheckIn checkin)
            {
                return await _checkinService.UpdateCheckInAysnc(checkin);
            }

            [Route("/CheckIn/{id}")]
            [HttpDelete]
            public async Task<CheckIn> DeleteCheckInAsync(int id)
            {
                return await _checkinService.DeleteCheckInAysnc(id);
            }
            #endregion
        
    }
}
