using Booking.API.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API.Entities
{
    public class CheckIn : IEntity
    {
        public int Id { get; set; }
        public int ClientID { get; set; }
        public int RoomID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string? Note { get; set; }
    }
}
