using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clients.API.DTO
{
    public class ClientsDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public long IdentificationID { get; set; }
        public int CheckInAmount { get; set; }
        public decimal DiscountAmount { get; set; }
    }
}
