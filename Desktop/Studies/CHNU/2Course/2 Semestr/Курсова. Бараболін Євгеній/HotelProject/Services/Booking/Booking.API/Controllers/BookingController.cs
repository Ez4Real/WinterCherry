using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking.API.Interfaces.IServices;
using Booking.API.Entities;

namespace Booking.API.Controllers
{
    public class BookingController : ControllerBase
    {
        private IBookingService _clientsService { get; }
        public BookingController(IBookingService clientsService)
        {
            _clientsService = clientsService;
        }

        #region BookingAPI
        [Route("/Booking")]
        [HttpGet]
        public async Task<IEnumerable<Booking>> GetAllBooking()
        {
            return await _clientsService.GetAllBookingAysnc();
        }

        [Route("/Booking/{id}")]
        [HttpGet]
        public async Task<Booking> GetBookingByIdAsync(int id)
        {
            return await _clientsService.GetBookingByIdAysnc(id);
        }

        [Route("/Booking")]
        [HttpPost]
        public async Task<Booking> AddBookingAsync([FromBody] Booking clients)
        {
            return await _clientsService.AddBookingAysnc(clients);
        }

        [Route("/Booking")]
        [HttpPut]
        public async Task<Booking> UpdateBookingAsync([FromBody] Booking clients)
        {
            return await _clientsService.UpdateBookingAysnc(clients);
        }

        [Route("/Booking/{id}")]
        [HttpDelete]
        public async Task<Booking> DeleteBookingAsync(int id)
        {
            return await _clientsService.DeleteBookingAysnc(id);
        }
        #endregion
    }
}
